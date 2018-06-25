using System.ComponentModel.DataAnnotations.Schema;

namespace CMCVirtual.Domain.Entity
{
    [Table("C_WORK_TYPE_STOREDPROC")]
    internal class C_WorkTypeStoredProc
    {
        [Column("STATION_TYPE")]
        public int StationType { get; set; }

        [Column("WORK_TYPE")]
        public int WorkType { get; set; }

        [Column("STOREDPROC")]
        public string StoredProc { get; set; }

        [Column("STOREDPROC_INDEX")]
        public int StoredProcIndex { get; set; }

        [Column("RETURN_FLAG")]
        public int ReturnFlag { get; set; }

        [Column("ID")]
        public long Id { get; set; }
    }
}
