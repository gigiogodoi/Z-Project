using CMCVirtual.Core.Enumerations;
using System.Collections.Generic;

namespace CMCVirtual.Core.TO
{
    public class StepTO
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public int Index { get; set; }

        public int Second { get; set; }

        public int Fork { get; set; }

        public Rule Rule { get; set; }

        public bool Last { get; set; }

        public string Special { get; set; }

        public StepPromptDataTO Data { get; set; }

        public ICollection<ProcedureTO> Procedures { get; set; }
    }
}
