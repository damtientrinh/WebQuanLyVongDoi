using Microsoft.EntityFrameworkCore;
using WebQuanLyTaiSan.Models;

namespace WebQuanLyTaiSan.Data
{
    public static class DbSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // --- 1. SEED PHÒNG BAN (20 PHÒNG) ---
            var departments = new List<Department>();
            string[] deptNames = { "Khoa CNTT", "Phòng Đào tạo", "Phòng Hành chính", "Phòng Kế hoạch", "Trung tâm Thí nghiệm", "Khoa Điện", "Khoa Cơ khí", "Phòng Tài vụ", "Thư viện", "Phòng Bảo vệ" };
            for (int i = 1; i <= 20; i++)
            {
                departments.Add(new Department
                {
                    Id = i,
                    Name = i <= 10 ? deptNames[i - 1] : $"Phòng chức năng {i}",
                    Location = $"Tầng {(i % 5) + 1} - Nhà {(char)('A' + (i % 4))}",
                    CreatedAt = DateTimeOffset.Now
                });
            }
            modelBuilder.Entity<Department>().HasData(departments);

            // --- 2. SEED DANH MỤC (20 LOẠI) ---
            var categories = new List<Category>();
            string[] catNames = { "Máy tính để bàn", "Linh kiện rời", "Thiết bị mạng", "Laptop", "Máy in", "Máy chiếu", "Server", "Thiết bị lưu trữ" };
            for (int i = 1; i <= 20; i++)
            {
                categories.Add(new Category
                {
                    Id = i,
                    Name = i <= 8 ? catNames[i - 1] : $"Thiết bị loại {i}",
                    Description = $"Mô tả cho danh mục {i}",
                    CreatedAt = DateTimeOffset.Now
                });
            }
            modelBuilder.Entity<Category>().HasData(categories);

            // --- 3. SEED MÁY TÍNH (20 MÁY) ---
            var computers = new List<Computer>();
            string[] brands = { "Dell Optiplex", "HP ProDesk", "Lenovo ThinkCentre", "MacBook Air", "Asus ExpertCenter" };
            string[] statuses = { "Đang dùng", "Bảo trì", "Trong kho", "Hỏng" };
            for (int i = 1; i <= 20; i++)
            {
                computers.Add(new Computer
                {
                    Id = i,
                    AssetCode = $"EPU-PC-{i:D3}",
                    Name = $"{brands[i % 5]} Gen {i}",
                    Status = statuses[i % 4],
                    PurchaseDate = DateTime.Now.AddDays(-i * 10),
                    DepartmentId = (i % 20) + 1,
                    CategoryId = (i % 5 == 0) ? 4 : 1, // Xen kẽ Laptop và PC
                    CreatedAt = DateTimeOffset.Now
                });
            }
            modelBuilder.Entity<Computer>().HasData(computers);

            // --- 4. SEED LINH KIỆN (20 LINH KIỆN) ---
            var components = new List<Component>();
            string[] compNames = { "RAM Kington 8GB", "SSD Samsung 256GB", "CPU Intel i5", "VGA GTX 1650", "Nguồn Cooler Master" };
            for (int i = 1; i <= 20; i++)
            {
                components.Add(new Component
                {
                    Id = i,
                    Name = compNames[i % 5],
                    SerialNumber = $"SN-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}",
                    Price = 500000 + (i * 100000),
                    Status = i % 3 == 0 ? "Trong kho" : "Đang sử dụng",
                    ComputerId = i % 3 == 0 ? null : (i % 20) + 1,
                    CategoryId = 2,
                    CreatedAt = DateTimeOffset.Now
                });
            }
            modelBuilder.Entity<Component>().HasData(components);

            // --- 5. SEED NHẬT KÝ BẢO TRÌ (20 NHẬT KÝ) ---
            var logs = new List<MaintenanceLog>();
            for (int i = 1; i <= 20; i++)
            {
                logs.Add(new MaintenanceLog
                {
                    Id = i,
                    ComputerId = (i % 20) + 1,
                    RepairDate = DateTime.Now.AddDays(-i),
                    Description = $"Bảo trì định kỳ lần thứ {i}",
                    Cost = 100000 + (i * 50000),
                    CreatedAt = DateTimeOffset.Now
                });
            }
            modelBuilder.Entity<MaintenanceLog>().HasData(logs);
        }
    }
}