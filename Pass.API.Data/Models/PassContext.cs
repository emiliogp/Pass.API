using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pass.API.Data.Models
{
    public partial class PassContext : DbContext
    {
        public PassContext()
        {
        }

        public PassContext(DbContextOptions<PassContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Building> Building { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Visit> Visit { get; set; }
        public virtual DbSet<VisitHistory> VisitHistory { get; set; }
        public virtual DbSet<Visitor> Visitor { get; set; }
        public virtual DbSet<VisitStatus> VisitStatus { get; set; }
        public virtual DbSet<VisitVisitor> VisitVisitor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>(entity =>
            {
                entity.HasKey(e => e.BuildinKey);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeKey);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Job)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Visit>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.BuildingNavigation)
                    .WithMany(p => p.Visit)
                    .HasForeignKey(d => d.Building)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Visit_Building");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VisitCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Visit_Employee1");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Visit)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Visit_VisitStatus");

                entity.HasOne(d => d.VisitedPersonNavigation)
                    .WithMany(p => p.VisitVisitedPersonNavigation)
                    .HasForeignKey(d => d.VisitedPerson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Visit_Employee");
            });

            modelBuilder.Entity<VisitHistory>(entity =>
            {
                entity.HasKey(e => e.VisitHistoryKey);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.VisitNavigation)
                    .WithMany(p => p.VisitHistory)
                    .HasForeignKey(d => d.Visit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitHistory_Visit");
            });

            modelBuilder.Entity<Visitor>(entity =>
            {
                entity.HasKey(e => e.VisitorKey);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VisitStatus>(entity =>
            {
                entity.HasKey(e => e.StatusKey);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VisitVisitor>(entity =>
            {
                entity.HasKey(e => new { e.Visit, e.Visitor });

                entity.ToTable("Visit_Visitor");

                entity.HasOne(d => d.VisitNavigation)
                    .WithMany(p => p.VisitVisitor)
                    .HasForeignKey(d => d.Visit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Visit_Visitor_Visit");

                entity.HasOne(d => d.VisitorNavigation)
                    .WithMany(p => p.VisitVisitor)
                    .HasForeignKey(d => d.Visitor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Visit_Visitor_Visitor");
            });
        }
    }
}
