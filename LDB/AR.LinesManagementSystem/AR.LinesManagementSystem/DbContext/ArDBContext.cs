using AR.LinesManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AR.LinesManagementSystem.Context
{
    public class ArDBContext : DbContext
    {
        public ArDBContext(DbContextOptions<ArDBContext> options) : base(options)
        {
            Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ContractTerm>().ToTable("ContractTerms");
        }

        public int CurrentUserId { get; set; }
        private void UpdateAuditEntities()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IBaseEntityWithAudit && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in modifiedEntries)
            {
                var entity = (IBaseEntityWithAudit)entry.Entity;
                DateTimeOffset now = DateTimeOffset.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = now;
                    entity.CreatedBy = CurrentUserId;
                }
                else
                {
                    base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                    base.Entry(entity).Property(x => x.CreatedAt).IsModified = false;
                }

                entity.UpdatedAt = now;
                entity.UpdatedBy = CurrentUserId;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            UpdateAuditEntities();
            return await base.SaveChangesAsync();
        }

        public DbSet<AntennaCategory> AntennaCategories { get; set; }
        public DbSet<AntennaType> AntennaTypes { get; set; }
        public DbSet<BudgetService> BudgetServices { get; set; }
        public DbSet<Circuit> Circuits { get; set; }
        public DbSet<CircuitType> CircuitTypes { get; set; }

        public DbSet<ConnectivityCategory> ConnectivityCategories { get; set; }
        public DbSet<ConnectivityProviderType> ConnectivityProviderTypes { get; set; }
        public DbSet<ConnectivityPurpose> ConnectivityPurposes { get; set; }
        public DbSet<ConnectivitySiteType> ConnectivitySiteTypes { get; set; }
        public DbSet<ConnectivityType> ConnectivityTypes { get; set; }


        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<DeliveryCategory> DeliveryCategories { get; set; }
        public DbSet<DeliveryLocation> DeliveryLocation { get; set; }
        public DbSet<DeliveryType> DeliveryTypes { get; set; }
        public DbSet<DiversityLevel> DiversityLevels { get; set; }

        public DbSet<ISPType> ISPTypes { get; set; }


        public DbSet<LineStatus> LineStatuses { get; set; }
        public DbSet<Network> Networks { get; set; }
        public DbSet<ProductLine> ProductLines { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Provider> Providers { get; set; }

        public DbSet<Reason> Reasons { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestAction> RequestActions { get; set; }
        public DbSet<RequestStatus> RequestStatuses { get; set; }
        public DbSet<Rig> Rigs { get; set; }
        public DbSet<RigType> RigTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Router> Routers { get; set; }
        public DbSet<SatelliteService> SatelliteServices { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceClass> ServiceClasses { get; set; }
        public DbSet<ServiceConnectionType> ServiceConnectionType { get; set; }

        public DbSet<ServiceType> ServiceTypes { get; set; }

        public DbSet<SubProductLine> SubProductLines { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}