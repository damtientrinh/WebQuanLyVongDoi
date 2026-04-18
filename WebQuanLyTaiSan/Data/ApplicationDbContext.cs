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
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MaintenanceLog> MaintenanceLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- CẤU HÌNH SQLITE  ---
            if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                var decimalConverter = new ValueConverter<decimal, double>(v => (double)v, v => (decimal)v);

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
            }

            // --- GLOBAL QUERY FILTER (Tự động ẩn dữ liệu đã xóa) ---
            // Giúp không cần viết .Where(x => !x.IsDeleted) trong Controller nữa
            modelBuilder.Entity<Computer>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Component>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Employee>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Department>().HasQueryFilter(d => !d.IsDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(c => !c.IsDeleted);

            // --- CẤU HÌNH QUAN HỆ ---
            // Khi xóa một Phòng ban, không cho phép xóa nếu vẫn còn Nhân viên bên trong (Bảo vệ dữ liệu)
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seeder
            DbSeeder.Seed(modelBuilder);
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