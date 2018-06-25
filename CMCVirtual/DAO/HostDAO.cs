using CMCVirtual.DAO.Contracts;
using CMCVirtual.Domain;
using CMCVirtual.Extensions;
using System.Collections.Generic;
using System.Data;

namespace CMCVirtual.DAO
{
    internal class HostDAO : BaseDAO, IHostDAO
    {
        public ICollection<string> ListProductNames()
        {
            var retList = new List<string>();
            var queryString = string.Format(
                              "SELECT DISTINCT SUBSTR(HOST_NAME, INSTR(HOST_NAME, '-')+1, 3) HOST_NAME"
                            + "  FROM {0}.C_HOST_NAME_T "
                            + " ORDER BY HOST_NAME      "
                            , SchemaDB)
                            ;

            foreach (var row in DbCommandSelect(queryString).Select())
            {
                retList.Add(row["HOST_NAME"].ToString());
            }
            return retList;
        }

        public ICollection<Domain.Host> ListAll()
        {
            var retList = new List<Domain.Host>();
            var queryString = string.Format(
                              "SELECT HOST_NAME         "
                            + "     , HOSTID            "
                            + "     , HOST_IP           "
                            + "     , HOST_PORT         "
                            + "  FROM {0}.C_HOST_NAME_T "
                            + " ORDER BY HOST_NAME      "
                            , SchemaDB)
                            ;

            foreach (var row in DbCommandSelect(queryString).Select())
            {
                retList.Add(CreateHostFromRow(row));
            }
            return retList;
        }

        public ICollection<Host> ListByProductName(string productName)
        {
            var retList = new List<Domain.Host>();
            var queryString = string.Format(
                              "SELECT HOST_NAME              "
                            + "     , HOSTID                 "
                            + "     , HOST_IP                "
                            + "     , HOST_PORT              "
                            + "  FROM {0}.C_HOST_NAME_T      "
                            + " WHERE 0=0                    "
                            + "   AND HOST_NAME LIKE '%{1}%' "
                            + " ORDER BY HOST_NAME           "
                            , SchemaDB, productName)
                            ;

            foreach (var row in DbCommandSelect(queryString).Select())
            {
                retList.Add(CreateHostFromRow(row));
            }
            return retList;
        }

        private Domain.Host CreateHostFromRow(DataRow row)
        {
            return new Domain.Host
            {
                HostId   = row["HOSTID"   ].ToInteger(),
                HostIp   = row["HOST_IP"  ].ToString(),
                HostName = row["HOST_NAME"].ToString(),
                HostPort = row["HOST_PORT"].ToString()
            };
        }
    }
}
