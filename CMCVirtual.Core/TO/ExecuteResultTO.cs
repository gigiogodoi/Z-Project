using CMCVirtual.Core.Enumerations;

namespace CMCVirtual.Core.TO
{
    public class ExecuteResultTO
    {
        public Result Result         { get; set; }

        public string ExecuteMessage { get; set; }

        public string PromptMessage  { get; set; }
    }
}
