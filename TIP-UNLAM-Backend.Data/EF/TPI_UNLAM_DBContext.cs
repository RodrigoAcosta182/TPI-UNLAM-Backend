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

        public virtual DbSet<Juego> Juegos { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<PacientesXprofesional> PacientesXprofesionals { get; set; }
        public virtual DbSet<Paise> Paises { get; set; }
        public virtual DbSet<Profesionale> Profesionales { get; set; }
        public virtual DbSet<ProgresosXpacientesXjuego> ProgresosXpacientesXjuegos { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TT83BPI;Database=TPI_UNLAM_DB;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Juego>(entity =>
            {
                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ruta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pacientes_Paises");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pacientes_Provincias");
            });

            modelBuilder.Entity<PacientesXprofesional>(entity =>
            {
                entity.ToTable("PacientesXProfesional");

                entity.Property(e => e.FechaFinalizacionContacto).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioContacto).HasColumnType("datetime");

                entity.HasOne(d => d.Paciente)
                    .WithMany(p => p.PacientesXprofesionals)
                    .HasForeignKey(d => d.PacienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PacientesXProfesional_Pacientes");

                entity.HasOne(d => d.Profesional)
                    .WithMany(p => p.PacientesXprofesionals)
                    .HasForeignKey(d => d.ProfesionalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PacientesXProfesional_Profesionales");
            });

            modelBuilder.Entity<Paise>(entity =>
            {
                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profesionale>(entity =>
            {
                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Legajo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Profesionales)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Profesionales_Paises");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Profesionales)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Profesionales_Provincias");
            });

            modelBuilder.Entity<ProgresosXpacientesXjuego>(entity =>
            {
                entity.ToTable("ProgresosXPacientesXJuegos");

                entity.Property(e => e.FechaFinalizacionJuego).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioJuego).HasColumnType("datetime");

                entity.HasOne(d => d.Juego)
                    .WithMany(p => p.ProgresosXpacientesXjuegos)
                    .HasForeignKey(d => d.JuegoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgresosXPacientesXJuegos_Juegos");

                entity.HasOne(d => d.Paciente)
                    .WithMany(p => p.ProgresosXpacientesXjuegos)
                    .HasForeignKey(d => d.PacienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgresosXPacientesXJuegos_Pacientes");

                entity.HasOne(d => d.Profesional)
                    .WithMany(p => p.ProgresosXpacientesXjuegos)
                    .HasForeignKey(d => d.ProfesionalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgresosXPacientesXJuegos_Profesionales");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.PaisId)
                    .HasConstraintName("FK_Provincias_Paises");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
