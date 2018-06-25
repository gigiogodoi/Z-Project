using System.ComponentModel.DataAnnotations.Schema;

namespace CMCVirtual.Domain.Entity
{
    [Table("C_STATION_TYPE")]
    internal class C_StationType
    {
        [Column("STATION_NUMBER")]
        public long StationNumber { get; set; }

        [Column("STATION_TYPE")]
        public int StationType { get; set; }

        [Column("ID")]
        public long Id { get; set; }

    }
}
