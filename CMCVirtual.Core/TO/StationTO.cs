using System.Collections.Generic;

namespace CMCVirtual.Core.TO
{
    public class StationTO
    {
        public string Name { get; set; }

        public long Number { get; set; }

        public string Group { get; set; }

        public int Type { get; set; }

        public ICollection<StepTO> Steps { get; set; }
    }
}
