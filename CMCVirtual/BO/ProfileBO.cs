using AutoMapper;
using CMCVirtual.BO.Contracts;
using CMCVirtual.Core.TO;
using CMCVirtual.DAO.Contracts;
using CMCVirtual.Extensions;
using System.Net.NetworkInformation;
using System.Linq;

namespace CMCVirtual.BO
{
    public class ProfileBO : BaseBO<IProfileDatabaseDAO>, IProfileBO
    {
        public bool ValidateUserPassword(string userName, string password)
        {
            return DefaultDAO.ValidateUserPassword(userName, password);
        }

        public LoginTO GetLastLogin()
        {
            var macAddress = GetMacAddress();
            var domain     = DefaultDAO.GetLastLogin(macAddress);
            return Mapper.Map<LoginTO>(domain);
        }

        public void WriteLogin(LoginTO loginTO)
        {
            var lastTO = GetLastLogin();

            loginTO.MacAddress = GetMacAddress();

            if (lastTO == null)
            {
                DefaultDAO.InsertLogin(loginTO);
            }
            else if (!loginTO.CompareLogin(lastTO))
            {
                DefaultDAO.DisableLogin(lastTO);

                DefaultDAO.InsertLogin(loginTO);
            }
        }

        private string GetMacAddress()
        {
            var network = (from a in NetworkInterface.GetAllNetworkInterfaces()
                          where a.OperationalStatus == OperationalStatus.Up
                             && a.NetworkInterfaceType != NetworkInterfaceType.Loopback
                         select a).FirstOrDefault();

            return network.GetPhysicalAddress().ToString();
        }
    }
}