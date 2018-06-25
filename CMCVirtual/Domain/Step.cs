using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCVirtual.Domain
{
    public class Step
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public int Index { get; set; }

        public int Second { get; set; }

        public int Fork { get; set; }

        public int Rule { get; set; }

        public bool Last { get; set; }

        public string Special { get; set; }

        public string Param { get; set; }

        public string CodeBig5 { get; set; }
    }
}
