using System.ComponentModel.DataAnnotations;

namespace WebQuanLyTaiSan.Models
{
    // Kế thừa BaseEntity để dùng chung Id, CreatedAt, IsDeleted
    public class Component : BaseEntity
    {
        [Required(ErrorMessage = "Vui lòng nhập tên linh kiện")]
        [Display(Name = "Tên linh kiện")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Số Serial không được để trống")]
        [Display(Name = "Số Serial")]
        [StringLength(50)]
        public string SerialNumber { get; set; } = string.Empty;

        [Display(Name = "Giá nhập")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá nhập không được âm")]
        public decimal Price { get; set; }

        [Display(Name = "Trạng thái")]
        public string Status { get; set; } = "Trong kho";

        // Khóa ngoại liên kết với Danh mục
        [Display(Name = "Danh mục")]
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        // Khóa ngoại liên kết với Máy tính (Nếu linh kiện đã lắp vào máy)
        [Display(Name = "Máy tính sử dụng")]
        public int? ComputerId { get; set; }
        public virtual Computer? Computer { get; set; }
    }
}