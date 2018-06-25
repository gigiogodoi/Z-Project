using CMCVirtual.Core.Enumerations;
using System;

namespace CMCVirtual.Core.TO
{
    public class ControllerResultTO : ExecuteResultTO
    {
        public Exception Exception { get; set; }
    }

    public class ControllerResultTO<TTO> : ControllerResultTO
    {
        public TTO TO { get; set; }
    }
}
