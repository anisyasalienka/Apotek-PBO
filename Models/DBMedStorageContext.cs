using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Apotek_PBO.Models
{
    public partial class DBMedStorageContext : DbContext
    {
        public DBMedStorageContext()
        {
        }

        public DBMedStorageContext(DbContextOptions<DBMedStorageContext> options)
            : base(options)
        {
        }

        public virtual DbSet<InformasiObat> InformasiObats { get; set; }
        public virtual DbSet<JenisObat> JenisObats { get; set; }
        public virtual DbSet<KetersediaanObat> KetersediaanObats { get; set; }
        public virtual DbSet<LogIn> LogIns { get; set; }
        public virtual DbSet<ObatKeluar> ObatKeluars { get; set; }
        public virtual DbSet<ObatMasuk> ObatMasuks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=DBMedStorage;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InformasiObat>(entity =>
            {
                entity.HasKey(e => e.ObatId);

                entity.ToTable("InformasiObat");

                entity.Property(e => e.ObatId).HasColumnName("obatId");

                entity.Property(e => e.ObatHarga).HasColumnName("obatHarga");

                entity.Property(e => e.ObatJenis)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("obatJenis");

                entity.Property(e => e.ObatKegunaan)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("obatKegunaan");

                entity.Property(e => e.ObatKomposisi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("obatKomposisi");

                entity.Property(e => e.ObatNama)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("obatNama");

                entity.Property(e => e.ObatUkuran)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("obatUkuran");
            });

            modelBuilder.Entity<JenisObat>(entity =>
            {
                entity.ToTable("JenisObat");

                entity.Property(e => e.JenisObat1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jenisObat");
            });

            modelBuilder.Entity<KetersediaanObat>(entity =>
            {
                entity.HasKey(e => e.ReadyId);

                entity.ToTable("KetersediaanObat");

                entity.Property(e => e.ReadyId).HasColumnName("readyId");

                entity.Property(e => e.ReadyJumlah).HasColumnName("readyJumlah");

                entity.Property(e => e.ReadyNama)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("readyNama");

                entity.Property(e => e.ReadyUkuran)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("readyUkuran")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LogIn>(entity =>
            {
                entity.ToTable("LogIn");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObatKeluar>(entity =>
            {
                entity.HasKey(e => e.KeluarId);

                entity.ToTable("ObatKeluar");

                entity.Property(e => e.KeluarId).HasColumnName("keluarId");

                entity.Property(e => e.KeluarCustomer)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("keluarCustomer");

                entity.Property(e => e.KeluarJumlah).HasColumnName("keluarJumlah");

                entity.Property(e => e.KeluarNama)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("keluarNama");

                entity.Property(e => e.KeluarTanggal)
                    .HasColumnType("date")
                    .HasColumnName("keluarTanggal");

                entity.Property(e => e.KeluarUkuran)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("keluarUkuran");
            });

            modelBuilder.Entity<ObatMasuk>(entity =>
            {
                entity.HasKey(e => e.MasukId);

                entity.ToTable("ObatMasuk");

                entity.Property(e => e.MasukId).HasColumnName("masukId");

                entity.Property(e => e.MasukJumlah).HasColumnName("masukJumlah");

                entity.Property(e => e.MasukNama)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("masukNama");

                entity.Property(e => e.MasukPabrik)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("masukPabrik");

                entity.Property(e => e.MasukTanggal)
                    .HasColumnType("date")
                    .HasColumnName("masukTanggal");

                entity.Property(e => e.MasukUkuran)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("masukUkuran");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
