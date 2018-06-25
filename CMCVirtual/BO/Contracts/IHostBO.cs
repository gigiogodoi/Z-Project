using CMCVirtual.Core.TO;
using System.Collections.Generic;

namespace CMCVirtual.BO.Contracts
{
    public interface IHostBO
    {
        ICollection<HostTO> ListAll();
    }
}
