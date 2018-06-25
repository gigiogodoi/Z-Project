using System.Collections.Generic;

namespace CMCVirtual.DAO.Contracts
{
    public interface IStationDAO : IDAO
    {
        ICollection<Domain.Station> ListByHost(int hostNumber);

        Domain.Station Get(long stationNumber);
    }
}