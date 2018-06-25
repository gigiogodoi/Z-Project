using System.ComponentModel.DataAnnotations.Schema;

namespace CMCVirtual.Domain.Entity
{
    [Table("C_WORK_TYPE_NAME")]
    internal class C_WorkTypeName
    {
        [Column("LINE_NAME")]
        public string LineName { get; set; }

        [Column("WORK_TYPE")]
        public int WorkType { get; set; }

        [Column("WORK_TYPE_NAME")]
        public string WorkTypeName { get; set; }

        [Column("LENGTH")]
        public int Length { get; set; }

        [Column("CODE")]
        public string Code { get; set; }

        [Column("PARAM")]
        public string Param { get; set; }

        [Column("CODE_BIG5")]
        public string CodeBig5 { get; set; }

        [Column("ID")]
        public long Id { get; set; }

    }
}
