using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Extensions.Configuration;

namespace Dashboard.Models
{
    public partial class DashboardContext : DbContext
    {
        public DashboardContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdministrativeService>(entity =>
            {
                entity.HasKey(e => new { e.PIN, e.FiscalYear });
            });

            modelBuilder.Entity<AdministrativeServiceOther>(entity =>
            {
                entity.HasKey(e => new { e.PIN, e.FiscalYear });
            });

            modelBuilder.Entity<AllowanceAndAdjustmentsToRevenue>(entity =>
            {
                entity.HasKey(e => new { e.PIN, e.FiscalYear });
            });

            modelBuilder.Entity<AncillaryRevenue>(entity =>
            {
                entity.HasKey(e => new { e.PIN, e.FiscalYear });
            });

            modelBuilder.Entity<CapitalPropertyService>(entity =>
            {
                entity.HasKey(e => new { e.PIN, e.FiscalYear });
            });

            modelBuilder.Entity<Description>(entity =>
            {
                entity.HasKey(e => new { e.PIN, e.FiscalYear });
                entity.Property(e => e.FiscalEndDate).HasColumnType("date");
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.Property(e => e.PIN).ValueGeneratedNever();
                entity.Property(e => e.State).HasColumnType("nchar");
            });

            modelBuilder.Entity<NursingCareService>(entity =>
            {
                entity.HasKey(e => new { e.PIN, e.FiscalYear });
            });

            modelBuilder.Entity<OperationsSummary>(entity =>
            {
                entity.HasKey(e => new { e.PIN, e.FiscalYear });
            });

            modelBuilder.Entity<PatientCareService>(entity =>
            {
                entity.HasKey(e => new { e.PIN, e.FiscalYear });
            });

            modelBuilder.Entity<RoutineService>(entity =>
            {
                entity.HasKey(e => new { e.PIN, e.FiscalYear });

                entity.Property(e => e.DietaryBenefit)
                    .HasColumnType("numeric")
                    .ValueGeneratedOnAddOrUpdate();
                entity.Property(e => e.HousekeepingAndLaundryBenefit)
                    .HasColumnType("numeric")
                    .ValueGeneratedOnAddOrUpdate();
                entity.Property(e => e.PropertyBenefit)
                    .HasColumnType("numeric")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<RoutineServiceRevenue>(entity =>
            {
                entity.HasKey(e => new { e.PIN, e.FiscalYear });
                entity.Property(e => e.ComprehensiveCareOtherPatientDaysTotal).ValueGeneratedOnAddOrUpdate();
                entity.Property(e => e.ComprehensiveCareOtherRevenueTotal).ValueGeneratedOnAddOrUpdate();
                entity.Property(e => e.ComprehensiveCarePatientDaysTotal).ValueGeneratedOnAddOrUpdate();
                entity.Property(e => e.ComprehensiveCareRevenueTotal).ValueGeneratedOnAddOrUpdate();
                entity.Property(e => e.OtherCarePatientDaysTotal).ValueGeneratedOnAddOrUpdate();
                entity.Property(e => e.OtherCareRevenueTotal).ValueGeneratedOnAddOrUpdate();
                entity.Property(e => e.RevenueTotal).ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Statistics>(entity =>
            {
                entity.HasKey(e => new { e.PIN, e.FiscalYear });
            });

            modelBuilder.Entity<CountyAverage>(entity => entity.HasKey(e => new { e.CountyCode, e.FiscalYear }));
            modelBuilder.Entity<StateAverage>(entity => entity.HasKey(e => new { e.State, e.FiscalYear }));
            modelBuilder.Entity<Summary>(entity => entity.HasKey(e => new { e.PIN, e.FiscalYear }));
        }

        public virtual DbSet<AdministrativeService> AdministrativeServices { get; set; }
        public virtual DbSet<AdministrativeServiceOther> AdministrativeServiceOthers { get; set; }
        public virtual DbSet<AllowanceAndAdjustmentsToRevenue> AllowanceAndAdjustmentsToRevenues { get; set; }
        public virtual DbSet<AncillaryRevenue> AncillaryRevenues { get; set; }
        public virtual DbSet<CapitalPropertyService> CapitalPropertyServices { get; set; }
        public virtual DbSet<Description> Descriptions { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<NursingCareService> NursingCareServices { get; set; }
        public virtual DbSet<OperationsSummary> OperationsSummaries { get; set; }
        public virtual DbSet<PatientCareService> PatientCareServices { get; set; }
        public virtual DbSet<RoutineService> RoutineServices { get; set; }
        public virtual DbSet<RoutineServiceRevenue> RoutineServiceRevenues { get; set; }
        public virtual DbSet<Statistics> Statistics { get; set; }
        public virtual DbSet<CountyAverage> CountyAverages { get; set; }
        public virtual DbSet<StateAverage> StateAverages { get; set; }
        public virtual DbSet<Summary> Summaries { get; set; }
    }
}