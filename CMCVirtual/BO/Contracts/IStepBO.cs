using CMCVirtual.Core.TO;
using System.Collections.Generic;

namespace CMCVirtual.BO.Contracts
{
    public interface IStepBO : IBaseBO<StepTO>
    {
        ICollection<StepTO> ListByStation(int stationType, long stationNumber);

        StepTO Get(int stationType, int stepNumber);

        ResultTO Execute(string data);
    }
}
