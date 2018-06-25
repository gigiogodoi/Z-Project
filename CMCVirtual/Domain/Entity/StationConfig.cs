using System.ComponentModel.DataAnnotations.Schema;

namespace CMCVirtual.Domain.Entity
{
    [Table("C_STATION_CONFIG_T")]
    internal class C_StationConfig_T
    {
        [Column("HOSTID")]
        public int HostId { get; set; }

        [Column("STATION_IDX")]
        public int StationIdx { get; set; }

        [Column("STATION_NUMBER")]
        public long StationNumber { get; set; }

        [Column("STATION_NAME")]
        public string StationName { get; set; }

        [Column("LINE_NAME")]
        public string LineName { get; set; }

        [Column("GROUP_NAME")]
        public string GroupName { get; set; }

        [Column("SECTION_NAME")]
        public string SectionName { get; set; }

        [Column("TASK_CODE")]
        public string TaskCode { get; set; }

        [Column("CYCLE_TIME")]
        public int CycleTime { get; set; }

        [Column("STATION_CLASS")]
        public int StationClass { get; set; }

        [Column("ID")]
        public long Id { get; set; }

    }
}
