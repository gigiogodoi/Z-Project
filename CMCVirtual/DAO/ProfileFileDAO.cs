using CMCVirtual.Core.TO;
using CMCVirtual.DAO.Contracts;
using CMCVirtual.Domain;
using System.Configuration;
using CMCVirtual.Extensions;

namespace CMCVirtual.DAO
{
    internal class ProfileFileDAO : ProfileBaseDAO, IProfileFileDAO
    {
        private const string SETTINGS_KEY_NAME  = "LastStation";
        private const int INDEX_STATION_NAME    = 0;
        private const int INDEX_STATION_NUMBER  = 1;
        private const int INDEX_MAC_ADDRESS     = 2;

        public override Login GetLastLogin(string macAddress)
        {
            Login domain = null;
            var keyLogin = ConfigurationManager.AppSettings[SETTINGS_KEY_NAME].ToString();
            if (!string.IsNullOrEmpty(keyLogin))
            {
                var arrLogin = keyLogin.Split('@');
                domain = new Domain.Login
                {
                    StationName   = arrLogin[INDEX_STATION_NAME],
                    StationNumber = arrLogin[INDEX_STATION_NUMBER].ToLong(),
                    MacAddress    = arrLogin[INDEX_MAC_ADDRESS]
                };
            }
            return domain;
        }

        public override void InsertLogin(LoginTO loginTO)
        {
            // Write config file
            var configFile  = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var configValue = string.Format("{0}@{1}@{2}"
                                          , loginTO.StationName
                                          , loginTO.StationNumber
                                          , loginTO.MacAddress);
            configFile.AppSettings.Settings[SETTINGS_KEY_NAME].Value = configValue;
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
    }
}
