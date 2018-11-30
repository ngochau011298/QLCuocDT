namespace Random_File.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaCuoc")]
    public partial class GiaCuoc
    {
        [Key]
        [StringLength(20)]
        public string MaGiaCuoc { get; set; }

        public TimeSpan? TGBD { get; set; }

        public TimeSpan? TGKT { get; set; }

        public decimal? Gia { get; set; }

        public bool? Flag { get; set; }
    }
}
