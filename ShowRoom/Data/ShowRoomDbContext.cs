using ShowRoom.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowRoom.Data
{
    public partial class ShowRoomDbContext : DbContext
    {
        public ShowRoomDbContext()
        {
        }

        public ShowRoomDbContext(DbContextOptions<ShowRoomDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carburant> Carburant { get; set; }
        public virtual DbSet<Marque> Marque { get; set; }
        public virtual DbSet<Models> Models { get; set; }
        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Transmission> Transmission { get; set; }
        public virtual DbSet<TypeVoiture> TypeVoiture { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Db_ShowRoom;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carburant>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Marque>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Models>(entity =>
            {
                entity.HasKey(e => e.ModelId);

                entity.Property(e => e.Annee).HasMaxLength(4);

                entity.Property(e => e.Cc).HasColumnName("CC");

                entity.Property(e => e.ConsAutoroute).HasColumnName("Cons_Autoroute");

                entity.Property(e => e.ConsRoute).HasColumnName("Cons_Route");

                entity.Property(e => e.ConsVille).HasColumnName("Cons_Ville");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PayFabrication)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Carburant)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.CarburantId)
                    .HasConstraintName("FK__Model__Carburant__31EC6D26");

                entity.HasOne(d => d.Marque)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.MarqueId)
                    .HasConstraintName("FK__Model__MarqueId__32E0915F");

                entity.HasOne(d => d.PayFabricationNavigation)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.PayFabrication)
                    .HasConstraintName("FK__Model__PayFabric__33D4B598");

                entity.HasOne(d => d.Transmission)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.TransmissionId)
                    .HasConstraintName("FK__Model__Transmiss__34C8D9D1");

                entity.HasOne(d => d.TypeVoiture)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.TypeVoitureId)
                    .HasConstraintName("FK__Model__TypeVoitu__37A5467C");
            });

            modelBuilder.Entity<Pays>(entity =>
            {
                entity.Property(e => e.PaysId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Nationality).HasMaxLength(100);
            });

            modelBuilder.Entity<Transmission>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TypeVoiture>(entity =>
            {
                entity.Property(e => e.Type).HasMaxLength(50);
            });
        }
    }
}
