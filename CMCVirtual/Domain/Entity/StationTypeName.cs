using System.ComponentModel.DataAnnotations.Schema;

namespace CMCVirtual.Domain.Entity
{
    [Table("C_STATION_TYPE_NAME")]
    internal class C_StationTypeName
    {
        [Column("STATION_TYPE")]
        public int StationType { get; set; }

        [Column("STATION_TYPE_NAME")]
        public int StationTypeName { get; set; }

        [Column("ID")]
        public long Id { get; set; }

    }
}
