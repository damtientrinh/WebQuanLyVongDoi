using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQuanLyTaiSan.Models
{
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

        [Display(Name = "Thông số kỹ thuật")]
        public string? Specifications { get; set; } // Ví dụ: 8GB DDR4, SSD 256GB

        [Display(Name = "Giá nhập")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá nhập không được âm")]
        public decimal Price { get; set; }

        [Display(Name = "Ngày mua")]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        [Display(Name = "Bảo hành (tháng)")]
        public int WarrantyMonths { get; set; }

        [Display(Name = "Trạng thái")]
        public string Status { get; set; } = "Trong kho";

        // Khóa ngoại
        [Display(Name = "Danh mục")]
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        [Display(Name = "Máy tính sử dụng")]
        public int? ComputerId { get; set; }
        public virtual Computer? Computer { get; set; }

        // Logic tính toán nhanh
        [NotMapped]
        public bool IsInstalled => ComputerId.HasValue;

        [NotMapped]
        public DateTime WarrantyExpiration => PurchaseDate.AddMonths(WarrantyMonths);
    }
}