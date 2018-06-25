using AutoMapper;
using CMCVirtual.BO.Contracts;
using CMCVirtual.Core.TO;
using CMCVirtual.DAO.Contracts;
using CMCVirtual.IoC;
using System.Collections.Generic;

namespace CMCVirtual.BO
{
    public class HostBO : BaseBO<IHostDAO>, IHostBO
    {
        public ICollection<HostTO> ListAll()
        {
            var domain = DefaultDAO.ListAll();
            return Mapper.Map<ICollection<HostTO>>(domain);
        }
    }
}