using CMCVirtual.Core.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCVirtual.Domain
{
    public class Procedure
    {
        public string Name { get; set; }

        public int Index { get; set; }

        public ICollection<Domain.ProcedureParameter> Parameters { get; set; }
    }

    public class ProcedureParameter
    {
        public string Name { get; set; }

        public int Position { get; set; }

        public string Type { get; set; }

        public string Direction { get; set; }
    }
}
