using CMCVirtual.DAO.Contracts;
using CMCVirtual.Extensions;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace CMCVirtual.DAO
{
    internal class StationDAO : BaseDAO, IStationDAO
    {
        public ICollection<Domain.Station> ListByHost(int hostNumber)
        {
            var retList = new List<Domain.Station>();
            var queryString = string.Format(
                              "SELECT A.HOSTID                 "
                            + "     , A.STATION_IDX            "
                            + "     , A.STATION_NUMBER         "
                            + "     , A.STATION_NAME           "
                            + "     , A.GROUP_NAME             "
                            + "     , B.STATION_TYPE           "
                            + "  FROM {0}.C_STATION_CONFIG_T A "
                            + "INNER JOIN {0}.C_STATION_TYPE B ON A.STATION_NUMBER = B.STATION_NUMBER "
                            + " WHERE 0 = 0                    "
                            + "   AND A.HOSTID = {1}           "
                            + " ORDER BY A.STATION_NAME        "
                            , SchemaDB, hostNumber)
                            ;

            foreach (var row in DbCommandSelect(queryString).Select())
            {
                retList.Add(CreateStationFromRow(row));
            }
            return retList;
        }

        public Domain.Station Get(long stationNumber)
        {
            Domain.Station retStation = null;
            var queryString = string.Format(
                              "SELECT A.HOSTID                 "
                            + "     , A.STATION_IDX            "
                            + "     , A.STATION_NUMBER         "
                            + "     , A.STATION_NAME           "
                            + "     , A.GROUP_NAME             "
                            + "     , B.STATION_TYPE           "
                            + "  FROM {0}.C_STATION_CONFIG_T A "
                            + "INNER JOIN {0}.C_STATION_TYPE B ON A.STATION_NUMBER = B.STATION_NUMBER "
                            + " WHERE 0 = 0                    "
                            + "   AND A.STATION_NUMBER = {1}   "
                            , SchemaDB, stationNumber)
                            ;

            foreach (var row in DbCommandSelect(queryString).Select())
            {
                retStation = CreateStationFromRow(row);
            }
            return retStation;
        }

        private Domain.Station CreateStationFromRow(DataRow row)
        {
            return new Domain.Station
            {
                HostId = row["HOSTID"        ].ToInteger(),
                Index  = row["STATION_IDX"   ].ToInteger(),
                Number = row["STATION_NUMBER"].ToLong(),
                Name   = row["STATION_NAME"  ].ToString(),
                Group  = row["GROUP_NAME"    ].ToString(),
                Type   = row["STATION_TYPE"  ].ToInteger()
            };
        }
    }
}