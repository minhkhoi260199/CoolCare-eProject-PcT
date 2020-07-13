using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HealthInsuranceMgmt.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminLogin> AdminLogin { get; set; }
        public virtual DbSet<CompanyDetails> CompanyDetails { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Hospitals> Hospitals { get; set; }
        public virtual DbSet<Policies> Policies { get; set; }
        public virtual DbSet<PoliciesOnEmployees> PoliciesOnEmployees { get; set; }
        public virtual DbSet<PolicyApprovalDetails> PolicyApprovalDetails { get; set; }
        public virtual DbSet<PolicyRequestDetails> PolicyRequestDetails { get; set; }
        public virtual DbSet<PolicyTotalDescription> PolicyTotalDescription { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-D7242R2\\SQLEXPRESS;Database=HealthInsuranceMgmt;user id=sa;password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminLogin>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK_Employee");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("money");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hospitals>(entity =>
            {
                entity.HasKey(e => e.HospitalId)
                    .HasName("PK_Hospital");

                entity.Property(e => e.HospitalName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Policies>(entity =>
            {
                entity.HasKey(e => e.PolicyId);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Emi).HasColumnType("money");

                entity.Property(e => e.PolicyDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoliciesOnEmployees>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Emi).HasColumnType("money");

                entity.Property(e => e.PendDate)
                    .HasColumnName("PEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PolicyAmount).HasColumnType("money");

                entity.Property(e => e.PolicyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PstartDate)
                    .HasColumnName("PStartDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PolicyApprovalDetails>(entity =>
            {
                entity.HasKey(e => e.PolicyId);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PolicyRequestDetails>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Emi).HasColumnType("money");

                entity.Property(e => e.PolicyAmount).HasColumnType("money");

                entity.Property(e => e.PolicyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PolicyTotalDescription>(entity =>
            {
                entity.HasKey(e => e.PolicyId);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Emi).HasColumnType("money");

                entity.Property(e => e.PolicyAmount).HasColumnType("money");

                entity.Property(e => e.PolicyDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
