namespace QLTinhCuocDT_App.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinSIM")]
    public partial class ThongTinSIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinSIM()
        {
            ChiTietSuDung = new HashSet<ChiTietSuDung>();
            HoaDonDangKy = new HashSet<HoaDonDangKy>();
            HoaDonTinhCuoc = new HashSet<HoaDonTinhCuoc>();
        }

        [Key]
        [StringLength(10)]
        public string IDSIM { get; set; }

        [StringLength(20)]
        public string MaKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDangKy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }

        public bool? Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSuDung> ChiTietSuDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonDangKy> HoaDonDangKy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonTinhCuoc> HoaDonTinhCuoc { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
