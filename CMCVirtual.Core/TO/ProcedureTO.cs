using System.Collections.Generic;

namespace CMCVirtual.Core.TO
{
    public class ProcedureTO
    {
        public string Name { get; set; }

        public int Index { get; set; }

        public ICollection<ProcedureParameterTO> Parameters { get; set; }
    }
}
