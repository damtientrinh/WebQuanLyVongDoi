using System.ComponentModel.DataAnnotations;

namespace WebQuanLyTaiSan.Models
{
    public class MaintenanceLog : BaseEntity
    {
        [Required(ErrorMessage = "Vui lòng chọn ngày bảo trì")]
        [Display(Name = "Ngày bảo trì")]
        [DataType(DataType.Date)]
        public DateTime RepairDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Vui lòng nhập mô tả sửa chữa")]
        [Display(Name = "Nội dung sửa chữa")]
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "Chi phí không được là số âm")]
        [Display(Name = "Chi phí")]
        [DisplayFormat(DataFormatString = "{0:N0} đ")]
        public decimal Cost { get; set; }

        [Display(Name = "Đơn vị sửa chữa")]
        public string? ServiceProvider { get; set; } // Tên cửa hàng hoặc trung tâm bảo hành

        // Trạng thái bảo trì
        [Display(Name = "Trạng thái")]
        public string Status { get; set; } = "Hoàn thành"; // Hoàn thành, Đang sửa, Chờ linh kiện

        // Liên kết với máy tính (Foreign Key)
        [Required(ErrorMessage = "Vui lòng chọn máy tính bảo trì")]
        public int ComputerId { get; set; }
        public virtual Computer? Computer { get; set; }

        [Display(Name = "Hình ảnh/Hóa đơn")]
        public string? ImageUrl { get; set; }
    }
}