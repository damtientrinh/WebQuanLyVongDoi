using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebQuanLyTaiSan.Models
{
    public enum CategoryGroup
    {
        [Display(Name = "Thiết bị chính")]
        Device = 0,    // Thiết bị chính (Máy tính, Laptop, Điện thoại)
        [Display(Name = "Linh kiện")]
        Component = 1, // Linh kiện (CPU, RAM, SSD)
        [Display(Name = "Ngoại vi")]
        Peripheral = 2 // Ngoại vi (Chuột, Phím, Màn hình) 
    }
    public class Category : BaseEntity
    {
        public Category()
        {
            Computers = new HashSet<Computer>();
            Components = new HashSet<Component>();
        }

        [Required(ErrorMessage = "Mã danh mục không được để trống")]
        [StringLength(20)]
        [Display(Name = "Mã danh mục")]
        public string CategoryCode { get; set; } = string.Empty; // Ví dụ: LAP, PC, SRV

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100)]
        [Display(Name = "Tên danh mục")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Mô tả")]
        [StringLength(500)]
        public string? Description { get; set; }

        [Display(Name = "Nhóm tài sản")]
        public CategoryGroup Group { get; set; }

        // Thêm Icon để giao diện đẹp hơn
        [Display(Name = "Biểu tượng")]
        public string? Icon { get; set; } // Ví dụ: fa-desktop, fa-laptop

        // Navigation properties
        public virtual ICollection<Computer> Computers { get; set; }
        public virtual ICollection<Component> Components { get; set; }

        // Helper properties (Read-only)
        public int ComputerCount => Computers?.Count ?? 0;
        public int ComponentCount => Components?.Count ?? 0;

        // Kiểm tra xem danh mục này có an toàn để xóa không
        public bool IsSafeToDelete => ComputerCount == 0 && ComponentCount == 0;
    }
}