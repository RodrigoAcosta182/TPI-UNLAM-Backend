using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TIP_UNLAM_Backend.Data.EF
{
    public partial class TPI_UNLAM_DBContext : DbContext
    {
        public TPI_UNLAM_DBContext()
        {
        }

        public TPI_UNLAM_DBContext(DbContextOptions<TPI_UNLAM_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioXusuario> UsuarioXusuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TT83BPI;Database=TPI_UNLAM_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuarioXusuario>(entity =>
            {
                entity.ToTable("UsuarioXusuario");

                entity.Property(e => e.FechaVinculacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioId1).HasColumnName("usuarioId_1");

                entity.Property(e => e.UsuarioId2).HasColumnName("usuarioId_2");

                entity.HasOne(d => d.UsuarioId1Navigation)
                    .WithMany(p => p.UsuarioXusuarioUsuarioId1Navigations)
                    .HasForeignKey(d => d.UsuarioId1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_1_Usuarios1");

                entity.HasOne(d => d.UsuarioId2Navigation)
                    .WithMany(p => p.UsuarioXusuarioUsuarioId2Navigations)
                    .HasForeignKey(d => d.UsuarioId2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_1_Usuarios2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
