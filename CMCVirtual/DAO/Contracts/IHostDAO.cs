using System.Collections.Generic;

namespace CMCVirtual.DAO.Contracts
{
    public interface IHostDAO : IDAO
    {
        ICollection<string> ListProductNames();

        ICollection<Domain.Host> ListAll();

        ICollection<Domain.Host> ListByProductName(string productName);
    }
}
