using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebQuanLyTaiSan.Models;

namespace WebQuanLyTaiSan.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<MaintenanceLog> MaintenanceLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                // Bộ chuyển đổi Decimal sang Double để SQLite làm việc được với hàm Sum, Max, Min...
                var decimalConverter = new ValueConverter<decimal, double>(
                    v => (double)v,
                    v => (decimal)v);

                foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    var properties = entityType.GetProperties()
                        .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?));

                    foreach (var property in properties)
                    {
                        property.SetValueConverter(decimalConverter); 
                        property.SetColumnType("REAL");
                    }
                }
                DbSeeder.Seed(modelBuilder);
            }
        }

        // 1. Ghi đè bản Async 
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateAuditFields();
            return base.SaveChangesAsync(cancellationToken);
        }

        // 2. Ghi đè bản Sync
        public override int SaveChanges()
        {
            UpdateAuditFields();
            return base.SaveChanges();
        }

        // Hàm dùng chung để cập nhật CreatedAt/UpdatedAt
        private void UpdateAuditFields()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                var entity = (BaseEntity)entityEntry.Entity;
                entity.UpdatedAt = DateTimeOffset.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    entity.CreatedAt = DateTimeOffset.Now;
                    entity.IsDeleted = false; 
                }
            }
        }
    }
}