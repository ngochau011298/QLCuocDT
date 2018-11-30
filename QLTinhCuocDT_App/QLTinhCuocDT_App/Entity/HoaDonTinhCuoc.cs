namespace QLTinhCuocDT_App.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonTinhCuoc")]
    public partial class HoaDonTinhCuoc
    {
        [Key]
        [StringLength(20)]
        public string MaHDTC { get; set; }

        [StringLength(10)]
        public string IDSIM { get; set; }

        public decimal? PhiThueBao { get; set; }

        public decimal? TongTien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLapHD { get; set; }

        public bool? ThanhToan { get; set; }

        public bool? Flag { get; set; }

        public virtual ThongTinSIM ThongTinSIM { get; set; }
    }
}
