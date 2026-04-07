using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQuanLyTaiSan.Models
{
    // Kế thừa BaseEntity để đồng bộ ID và Soft Delete
    public class Computer : BaseEntity
    {
        [Required(ErrorMessage = "Mã tài sản không được để trống")]
        [Display(Name = "Mã máy tính")]
        [StringLength(20, ErrorMessage = "Mã tài sản không quá 20 ký tự")]
        public string AssetCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tên máy không được để trống")]
        [Display(Name = "Tên máy")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Trạng thái")]
        public string Status { get; set; } = "Sẵn sàng";

        [Display(Name = "Ngày nhập")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        // --- Logic tính toán (Không lưu vào DB) ---

        [NotMapped]
        [Display(Name = "Cấu hình chi tiết")]
        public string AutoConfiguration => (Components != null && Components.Any())
            ? string.Join(", ", Components.Select(c => c.Name))
            : "Chưa lắp linh kiện";

        [NotMapped]
        [Display(Name = "Giá trị linh kiện")]
        public decimal TotalValue => Components?.Sum(c => c.Price) ?? 0;

        [NotMapped]
        [Display(Name = "Tổng chi phí (TCO)")]
        public decimal TotalOwnershipCost => TotalValue + (MaintenanceLogs?.Sum(m => m.Cost) ?? 0);

        // --- Mối quan hệ Navigation ---

        public virtual ICollection<MaintenanceLog>? MaintenanceLogs { get; set; }
        public virtual ICollection<Component>? Components { get; set; }

        [Display(Name = "Danh mục")]
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        [Display(Name = "Phòng ban")]
        public int? DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
    }
}