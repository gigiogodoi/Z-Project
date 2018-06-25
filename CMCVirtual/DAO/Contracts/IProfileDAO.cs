using CMCVirtual.Core.TO;

namespace CMCVirtual.DAO.Contracts
{
    public interface IProfileDAO : IDAO
    {
        bool ValidateUserPassword(string userName, string password);

        Domain.Login GetLastLogin(string macAddress);

        void InsertLogin(LoginTO loginTO);

        void DisableLogin(LoginTO loginTO);
    }

    public interface IProfileDatabaseDAO : IProfileDAO { }

    public interface IProfileFileDAO : IProfileDAO { }
}