namespace QUANLYLINHKIEN.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLLKDB : DbContext
    {
        public QLLKDB()
            : base("name=QLLKDB")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<CHITIETHD> CHITIETHDs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LINHKIEN> LINHKIENs { get; set; }
        public virtual DbSet<LOAILK> LOAILKs { get; set; }
        public virtual DbSet<NUOCSX> NUOCSXes { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<TONKHO> TONKHOs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.HASHVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.MACV)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHD>()
                .Property(e => e.MAHD)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHD>()
                .Property(e => e.MALK)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MACV)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAKH)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIETHD)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MAKH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.DIENTHOAI)
                .IsUnicode(false);

            modelBuilder.Entity<LINHKIEN>()
                .Property(e => e.MALK)
                .IsUnicode(false);

            modelBuilder.Entity<LINHKIEN>()
                .Property(e => e.MALOAI)
                .IsUnicode(false);

            modelBuilder.Entity<LINHKIEN>()
                .Property(e => e.MANUOC)
                .IsUnicode(false);

            modelBuilder.Entity<LINHKIEN>()
                .Property(e => e.NAMSX)
                .IsUnicode(false);

            modelBuilder.Entity<LINHKIEN>()
                .Property(e => e.MANCC)
                .IsUnicode(false);

            modelBuilder.Entity<LINHKIEN>()
                .HasMany(e => e.CHITIETHD)
                .WithRequired(e => e.LINHKIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAILK>()
                .Property(e => e.MALOAI)
                .IsUnicode(false);

            modelBuilder.Entity<NUOCSX>()
                .Property(e => e.MANUOC)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.MANCC)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.DIENTHOAI)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.DIENTHOAI)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MACV)
                .IsUnicode(false);

            modelBuilder.Entity<TONKHO>()
                .Property(e => e.MALK)
                .IsUnicode(false);
        }
    }
}
