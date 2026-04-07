using System.ComponentModel.DataAnnotations;

namespace WebQuanLyTaiSan.Models
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100, ErrorMessage = "Tên danh mục không quá 100 ký tự")]
        [Display(Name = "Tên danh mục")]
        public string Name { get; set; } = string.Empty; // Khởi tạo giá trị mặc định để tránh Warning

        [Display(Name = "Mô tả")]
        [StringLength(500)]
        public string? Description { get; set; }

        // Tính tổng tài sản thuộc danh mục này
        [Display(Name = "Số lượng tài sản")]
        public int TotalAssets => (Computers?.Count ?? 0) + (Components?.Count ?? 0);

        public int CategoryType { get; set; }

        // Navigation properties
        public virtual ICollection<Computer>? Computers { get; set; }
        public virtual ICollection<Component>? Components { get; set; }
    }
}