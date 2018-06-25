using CMCVirtual.Core.Enumerations;
using CMCVirtual.Core.TO;
using CMCVirtual.Extensions;
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace CMCVirtual.DAO
{
    internal abstract class BaseDAO
    {
        protected const string SchemaDB = "FXUSER";

        private static bool TestConnection = false;

        public BaseDAO()
        {
            if (TestConnection)
            {
                DbCommandSelect("SELECT SYSDATE FROM DUAL");
                TestConnection = false;
            }
        }

        protected DbConnection CreateDbConnection()
        {
            // Assume failure.
            DbConnection connection = null;
            var connectionSettings  = ConfigurationManager.ConnectionStrings["FXConnection"];
            var connectionString    = connectionSettings.ConnectionString;
            var providerName        = connectionSettings.ProviderName;

            // Create the DbProviderFactory and DbConnection.
            if (!string.IsNullOrEmpty(connectionString) && !string.IsNullOrEmpty(providerName))
            {
                try
                {
                    DbProviderFactory factory   = DbProviderFactories.GetFactory(providerName);
                    connection                  = factory.CreateConnection();
                    connection.ConnectionString = connectionString;
                }
                catch (Exception ex)
                {
                    // Set the connection to null if it was created.
                    if (connection != null)
                    {
                        connection = null;
                    }
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                throw new ApplicationException("Validar arquivo de configuração! ConnectionStrings e ProviderName");
            }
            return connection;
        }

        protected DataTable DbCommandSelect(string queryString)
        {
            var dataTable = new DataTable();

            using (var connection = CreateDbConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = queryString;
                    command.CommandType = CommandType.Text;
                    connection.Open();

                    using (var reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        dataTable = reader.ToDatatable();
                    }
                }
            }
            return dataTable;
        }

        protected void DbCommandNonquery(string nonQueryString)
        {
            using (var connection = CreateDbConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = nonQueryString;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        protected ResultTO DbCommandProcedure(ProcedureTO to)
        {
            var resultTO = new ResultTO();
            using (var connection = CreateDbConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "FXUSER." + to.Name;
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    foreach (var item in to.Parameters)
                    {
                        switch(item.Direction)
                        {
                            case ProcedureParameterDirection.In:
                                command.AddInputParameter(item.Name, item.Value, item.Type);
                                break;
                            case ProcedureParameterDirection.Out:
                                command.AddOutputParameter(item.Name, item.Type);
                                break;
                        }
                    }
                    command.ExecuteNonQuery();

                    resultTO.Message = command.Parameters[to.Parameters
                                                            .Where(i => i.Direction == ProcedureParameterDirection.Out)
                                                            .FirstOrDefault().Name].Value.ToString();

                    resultTO.Result  = (resultTO.Message == "OK") ? Result.Pass : Result.Fail;
                }
            }
            return resultTO;
        }
    }
}
