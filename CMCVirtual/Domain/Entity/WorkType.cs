using System.ComponentModel.DataAnnotations.Schema;

namespace CMCVirtual.Domain.Entity
{
    [Table("C_WORK_TYPE")]
    internal class C_WorkType
    {
        [Column("STATION_TYPE")]
        public int StationType { get; set; }

        [Column("WORK_TYPE")]
        public int WorkType { get; set; }

        [Column("WORK_TYPE_INDEX")]
        public int WorkTypeIndex { get; set; }

        [Column("SECOND")]
        public int Second { get; set; }

        [Column("FORK")]
        public int Fork { get; set; }

        [Column("LENGTH")]
        public int Length { get; set; }

        [Column("RULE")]
        public int Rule { get; set; }

        [Column("LAST")]
        public int Last { get; set; }

        [Column("SPECIAL")]
        public string Special { get; set; }

        [Column("ID")]
        public long Id { get; set; }

    }
}
