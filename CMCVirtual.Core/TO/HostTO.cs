using System.Collections.Generic;

namespace CMCVirtual.Core.TO
{
    public class HostTO
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public ICollection<StationTO> Stations { get; set; }
    }
}
