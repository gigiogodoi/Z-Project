namespace CMCVirtual.Core.Enumerations
{
    public enum ControllerStatus
    {
        Idle,
        WaitUserInput,
        Busy
    }

    public enum ProcedureParameterDirection
    {
        In,
        Out,
        InOut
    }

    public enum ProcedureParameterType
    {
        VarChar,
        Number,
        RefCursor
    }

    public enum Rule
    {
        KeepInMemory=1,
        UntilLastInput=2,
        LastInput=3,
        Special=4,
        Jump=5
    }

    public enum Result
    {
        Pass,
        Fail
    }

    public enum ScanType
    {
        StationCommand,
        UndoCommand,
        VersionCommand,
        InputData
    }
}
