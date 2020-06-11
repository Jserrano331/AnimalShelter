using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace AnimalShelter.Models
{
    public partial class animalshelterContext : DbContext
    {
        private readonly IConfiguration _config;
        public animalshelterContext()
        {
        }

        public animalshelterContext(DbContextOptions<animalshelterContext> options, IConfiguration config)
            : base(options)
        {
            _config = config;
        }

        public virtual DbSet<Animal> Animal { get; set; }
        public virtual DbSet<Applicant> Applicant { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Species> Species { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Connection string stored as secret and accessed with Configuration API
                optionsBuilder.UseMySQL(_config.GetConnectionString("MySQLConnections"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>(entity =>
            {
                entity.ToTable("animal");

                entity.HasIndex(e => e.SpeciesId)
                    .HasName("fk_animal_species_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.Breed)
                    .IsRequired()
                    .HasColumnName("breed")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IntakeDate)
                    .HasColumnName("intake_date")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Neutered)
                    .HasColumnName("neutered")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasColumnName("size")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.Animal)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_animal_species");
            });

            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.ToTable("applicant");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasColumnName("zipcode")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("application");

                entity.HasIndex(e => e.AnimalId)
                    .HasName("fk_application_animal_idx");

                entity.HasIndex(e => e.ApplicantId)
                    .HasName("fk_application_applicant_idx");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("fk_application_employee_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adopted)
                    .HasColumnName("adopted")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.AnimalId).HasColumnName("animal_id");

                entity.Property(e => e.ApplicantId).HasColumnName("applicant_id");

                entity.Property(e => e.DateApplied)
                    .HasColumnName("date_applied")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.AnimalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_application_animal");

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.ApplicantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_application_applicant");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_application_employee");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DateHired)
                    .HasColumnName("date_hired")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeType)
                    .IsRequired()
                    .HasColumnName("employee_type")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasColumnName("zipcode")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Species>(entity =>
            {
                entity.ToTable("species");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Species1)
                    .IsRequired()
                    .HasColumnName("species")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
