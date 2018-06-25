using System.ComponentModel.DataAnnotations.Schema;

namespace CMCVirtual.Domain.Entity
{
    [Table("C_HOST_NAME_T")]
    internal class C_HostName_T
    {
        [Column("HOST_NAME")]
        public string HostName { get; set; }

        [Column("HOSTID")]
        public int HostId { get; set; }

        [Column("STATUS")]
        public int Status { get; set; }

        [Column("MD")]
        public int Md { get; set; }

        [Column("HOST_IP")]
        public string HostIp { get; set; }

        [Column("HOST_PORT")]
        public string HostPort { get; set; }
    }
}
