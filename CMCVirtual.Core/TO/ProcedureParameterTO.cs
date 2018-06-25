using CMCVirtual.Core.Enumerations;

namespace CMCVirtual.Core.TO
{
    public class ProcedureParameterTO
    {
        public string Name { get; set; }

        public object Value { get; set; }

        public ProcedureParameterType Type { get; set; }

        public ProcedureParameterDirection Direction { get; set; }
    }
}
