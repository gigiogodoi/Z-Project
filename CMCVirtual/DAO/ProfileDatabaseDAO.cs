using CMCVirtual.Core.TO;
using CMCVirtual.DAO.Contracts;
using CMCVirtual.Domain;
using CMCVirtual.Extensions;

namespace CMCVirtual.DAO
{
    internal class ProfileDatabaseDAO : ProfileBaseDAO, IProfileDatabaseDAO
    {
        public override Login GetLastLogin(string macAddress)
        {
            Domain.Login retLogin = null;
            var queryString = string.Format(
                              "SELECT STATION_NAME           "
                            + "     , STATION_NUMBER         "
                            + "     , MAC_ADDRESS            "
                            + "  FROM {0}.C_STATION_LOCATION "
                            + " WHERE 0 = 0                  "
                            + "   AND MAC_ADDRESS = '{1}'    "
                            + "   AND DEL_FLAG = 0           "
                            , SchemaDB, macAddress)
                            ;

            var result = DbCommandSelect(queryString);

            if (result.Rows.Count == 1)
            {
                retLogin = new Domain.Login
                {
                    StationNumber = result.Rows[0]["STATION_NUMBER"].ToLong(),
                    StationName   = result.Rows[0]["STATION_NAME"  ].ToString(),
                    MacAddress    = result.Rows[0]["MAC_ADDRESS"   ].ToString(),
                };
            }
            return retLogin;
        }

        public override void InsertLogin(LoginTO loginTO)
        {
            var queryString = string.Format(
                              "INSERT INTO {0}.C_STATION_LOCATION ( "
                            + "    MAC_ADDRESS,                     "
                            + "    STATION_NUMBER,                  "
                            + "    STATION_NAME,                    "
                            + "    DEL_FLAG                         "
                            + ") VALUES(                            "
                            + " '{1}',                              "
                            + "  {2},                               "
                            + " '{3}',                              "
                            + "   0                                 "
                            + ")                                    "
                            , SchemaDB
                            , loginTO.MacAddress
                            , loginTO.StationNumber
                            , loginTO.StationName)
                            ;

            DbCommandNonquery(queryString);
        }

        public override void DisableLogin(LoginTO loginTO)
        {
            var queryString = string.Format(
                              "UPDATE {0}.C_STATION_LOCATION "
                            + "   SET DEL_FLAG = 1           "
                            + " WHERE 0 = 0                  "
                            + "   AND MAC_ADDRESS    = '{1}' "
                            + "   AND STATION_NUMBER =  {2}  "
                            + "   AND STATION_NAME   = '{3}' "
                            , SchemaDB
                            , loginTO.MacAddress
                            , loginTO.StationNumber
                            , loginTO.StationName)
                            ;

            DbCommandNonquery(queryString);
        }
    }
}
