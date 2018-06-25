using CMCVirtual.Core.TO;
using CMCVirtual.DAO.Contracts;
using CMCVirtual.Domain;

namespace CMCVirtual.DAO
{
    internal abstract class ProfileBaseDAO : BaseDAO, IProfileDAO
    {
        public virtual bool ValidateUserPassword(string userName, string password)
        {
            var queryString = "SELECT 1 FROM DUAL";

            var result = DbCommandSelect(queryString);

            return (result.Rows.Count == 1);
        }

        public abstract Login GetLastLogin(string macAddress);

        public virtual void InsertLogin(LoginTO loginTO) {}

        public virtual void DisableLogin(LoginTO loginTO) {}
    }
}