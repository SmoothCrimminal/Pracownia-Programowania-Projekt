using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace P.P.Database.Models
{
    public partial class ProjektPPContext : DbContext
    {
        public ProjektPPContext()
        {
        }

        public ProjektPPContext(DbContextOptions<ProjektPPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TradeNote> TradeNotes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ProjektPP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NazwaBranzy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nazwaBranzy");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adres)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("adres");

                entity.Property(e => e.IdBranży).HasColumnName("idBranży");

                entity.Property(e => e.IdUżytkownika).HasColumnName("idUżytkownika");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Miasto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("miasto");

                entity.Property(e => e.NazwaFirmy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nazwaFirmy");

                entity.Property(e => e.Nip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nip");

                entity.HasOne(d => d.IdBranżyNavigation)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.IdBranży)
                    .HasConstraintName("FK__Companies__idBra__44FF419A");

                entity.HasOne(d => d.IdUżytkownikaNavigation)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.IdUżytkownika)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Companies__idUży__45F365D3");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirmaPowiazana).HasColumnName("firmaPowiazana");

                entity.Property(e => e.IdUżytkownika).HasColumnName("idUżytkownika");

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("imie");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Mail)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nazwisko");

                entity.Property(e => e.Stanowisko)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("stanowisko");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("telefon");

                entity.HasOne(d => d.FirmaPowiazanaNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.FirmaPowiazana)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Contact__firmaPo__48CFD27E");

                entity.HasOne(d => d.IdUżytkownikaNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.IdUżytkownika)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Contact__idUżytk__49C3F6B7");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NazwaRoli)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nazwaRoli");
            });

            modelBuilder.Entity<TradeNote>(entity =>
            {
                entity.ToTable("TradeNote");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirmaPowiazana).HasColumnName("firmaPowiazana");

                entity.Property(e => e.IdUżytkownika).HasColumnName("idUżytkownika");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Tresc)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("tresc");

                entity.HasOne(d => d.FirmaPowiazanaNavigation)
                    .WithMany(p => p.TradeNotes)
                    .HasForeignKey(d => d.FirmaPowiazana)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TradeNote__firma__4CA06362");

                entity.HasOne(d => d.IdUżytkownikaNavigation)
                    .WithMany(p => p.TradeNotes)
                    .HasForeignKey(d => d.IdUżytkownika)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TradeNote__idUży__4D94879B");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("dateOfBirth");

                entity.Property(e => e.IdRoli).HasColumnName("id_roli");

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("imie");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Login)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("_login");

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nazwisko");

                entity.Property(e => e.PasswordMd5)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("passwordMd5");

                entity.HasOne(d => d.IdRoliNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdRoli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__id_roli__4222D4EF");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
