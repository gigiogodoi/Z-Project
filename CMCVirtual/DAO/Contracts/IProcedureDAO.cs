using CMCVirtual.Core.TO;
using System.Collections.Generic;

namespace CMCVirtual.DAO.Contracts
{
    public interface IProcedureDAO : IDAO
    {
        ICollection<Domain.Procedure> ListByStep(int stationType, int stepNumber);

        ResultTO Execute(ProcedureTO procedure);
    }
}
