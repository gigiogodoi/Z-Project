using CMCVirtual.Core.TO;
using System.Collections.Generic;

namespace CMCVirtual.BO.Contracts
{
    public interface IStationBO : IBaseBO<StationTO>
    {
        bool IsLoad();

        void ChangeStation(long stationNumber);

        ExecuteResultTO Execute(string data);

        ICollection<StationTO> ListByHost(int hostNumber);

        StationTO Get(long stationNumber);

        ResultTO GoFirstStep();

        StepTO GetCurrentStep();
    }
}
