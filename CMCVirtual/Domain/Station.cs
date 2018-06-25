using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCVirtual.Domain
{
    public class Station
    {
        public int HostId { get; set; }

        public int Index { get; set; }

        public long Number { get; set; }

        public string Name { get; set; }

        public string Group { get; set; }

        public int Type { get; set; }
    }
}
