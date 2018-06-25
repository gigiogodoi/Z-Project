using System.Collections.Generic;

namespace CMCVirtual.DAO.Contracts
{
    public interface IStepDAO : IDAO
    {
        ICollection<Domain.Step> ListByStation(long stationNumber);

        Domain.Step Get(int stepNumber);
    }
}
