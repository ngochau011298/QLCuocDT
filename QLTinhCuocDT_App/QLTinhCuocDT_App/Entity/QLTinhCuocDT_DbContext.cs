namespace QLTinhCuocDT_App.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLTinhCuocDT_DbContext : DbContext
    {
        public QLTinhCuocDT_DbContext()
            : base("name=QLTinhCuocDT_DbContext")
        {
        }

        public virtual DbSet<ChiTietSuDung> ChiTietSuDung { get; set; }
        public virtual DbSet<GiaCuoc> GiaCuoc { get; set; }
        public virtual DbSet<HoaDonDangKy> HoaDonDangKy { get; set; }
        public virtual DbSet<HoaDonTinhCuoc> HoaDonTinhCuoc { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<ThongTinSIM> ThongTinSIM { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietSuDung>()
                .Property(e => e.MaChiTiet)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietSuDung>()
                .Property(e => e.IDSIM)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietSuDung>()
                .Property(e => e.PhiCuocGoi)
                .HasPrecision(19, 3);

            modelBuilder.Entity<GiaCuoc>()
                .Property(e => e.MaGiaCuoc)
                .IsUnicode(false);

            modelBuilder.Entity<GiaCuoc>()
                .Property(e => e.TGBD)
                .HasPrecision(0);

            modelBuilder.Entity<GiaCuoc>()
                .Property(e => e.TGKT)
                .HasPrecision(0);

            modelBuilder.Entity<GiaCuoc>()
                .Property(e => e.Gia)
                .HasPrecision(19, 3);

            modelBuilder.Entity<HoaDonDangKy>()
                .Property(e => e.MaHDDK)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonDangKy>()
                .Property(e => e.IDSIM)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonDangKy>()
                .Property(e => e.ChiPhiDangKy)
                .HasPrecision(19, 3);

            modelBuilder.Entity<HoaDonTinhCuoc>()
                .Property(e => e.MaHDTC)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonTinhCuoc>()
                .Property(e => e.IDSIM)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonTinhCuoc>()
                .Property(e => e.PhiThueBao)
                .HasPrecision(19, 3);

            modelBuilder.Entity<HoaDonTinhCuoc>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 3);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinSIM>()
                .Property(e => e.IDSIM)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinSIM>()
                .Property(e => e.MaKH)
                .IsUnicode(false);
        }
    }
}
