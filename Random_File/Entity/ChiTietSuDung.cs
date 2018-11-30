namespace Random_File.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietSuDung")]
    public partial class ChiTietSuDung
    {
        [Key]
        [StringLength(10)]
        public string MaChiTiet { get; set; }

        [StringLength(10)]
        public string IDSIM { get; set; }

        public DateTime? TGBD { get; set; }

        public DateTime? TGKT { get; set; }

        public int? SoPhutSD { get; set; }

        public decimal? PhiCuocGoi { get; set; }

        public bool? Flag { get; set; }

        public virtual ThongTinSIM ThongTinSIM { get; set; }
    }
}
