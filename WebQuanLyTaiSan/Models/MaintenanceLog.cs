using System.ComponentModel.DataAnnotations;

namespace WebQuanLyTaiSan.Models
{
    // Kế thừa BaseEntity để có ID, CreatedAt và Soft Delete (IsDeleted)
    public class MaintenanceLog : BaseEntity
    {
        [Required(ErrorMessage = "Vui lòng chọn ngày bảo trì")]
        [Display(Name = "Ngày bảo trì")]
        [DataType(DataType.Date)]
        public DateTime RepairDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Vui lòng nhập mô tả sửa chữa")]
        [Display(Name = "Chi tiết sửa chữa")]
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "Chi phí không được là số âm")]
        [Display(Name = "Chi phí")]
        [DisplayFormat(DataFormatString = "{0:N0} đ")]
        public decimal Cost { get; set; }

        // Liên kết với máy tính (Foreign Key)
        [Required(ErrorMessage = "Vui lòng chọn máy tính bảo trì")]
        [Display(Name = "Mã máy tính")]
        public int ComputerId { get; set; }
        public virtual Computer? Computer { get; set; }

        [Display(Name = "Hình ảnh")]
        public string? ImageUrl { get; set; }
    }
}