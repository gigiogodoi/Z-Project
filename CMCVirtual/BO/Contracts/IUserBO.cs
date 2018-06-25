using CMCVirtual.Core.TO;

namespace CMCVirtual.BO.Contracts
{
    public interface IProfileBO
    {
        bool ValidateUserPassword(string userName, string password);

        LoginTO GetLastLogin();

        void WriteLogin(LoginTO loginTO);
    }
}
