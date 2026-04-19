using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQuanLyTaiSan.Models
{
    public enum PackagingStatus
    {
        [Display(Name = "Fullbox (Nguyên hộp)")]
        FullBox = 0,

        [Display(Name = "No Box (Máy trần)")]
        NoBox = 1
    }

    // Kế thừa BaseEntity để đồng bộ ID và Soft Delete
    public class Computer : BaseEntity
    {
        public Computer()
        {
            MaintenanceLogs = new HashSet<MaintenanceLog>();
            Components = new HashSet<Component>();
        }

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

        [Display(Name = "Giá mua máy (Barebone/Gốc)")]
        public decimal PurchasePrice { get; set; } // Giá lúc mua máy chưa tính linh kiện rời

        [Display(Name = "Thời hạn bảo hành (tháng)")]
        public int WarrantyMonths { get; set; }

        [Display(Name = "Nhà cung cấp")]
        public string? Supplier { get; set; }

        // Gắn với nhân viên cụ thể
        [Display(Name = "Người sử dụng")]
        public int? EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }

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
        [Display(Name = "Hạn bảo hành")]
        public DateTime WarrantyExpiration => PurchaseDate.AddMonths(WarrantyMonths);

        [NotMapped]
        [Display(Name = "Tình trạng bảo hành")]
        public string WarrantyStatus => DateTime.Now > WarrantyExpiration ? "Hết hạn" : "Còn hạn";

        [NotMapped]
        [Display(Name = "Tổng giá trị tài sản")]
        // Giá gốc + Tổng giá linh kiện lắp thêm
        public decimal CurrentTotalValue => PurchasePrice + TotalValue;

        // Cập nhật lại TCO bao gồm cả giá mua máy ban đầu
        [NotMapped]
        [Display(Name = "Tổng chi phí sở hữu (TCO)")]
        public decimal TotalOwnershipCost => CurrentTotalValue + (MaintenanceLogs?.Sum(m => m.Cost) ?? 0);

        public PackagingStatus Packaging { get; set; } = PackagingStatus.FullBox;
        public string? Accessories { get; set; }

        [NotMapped]
        [Display(Name = "Mức độ khấu hao (%)")]
        public int DepreciationPercentage
        {
            get
            {
                // Giả sử vòng đời máy tính là 5 năm (60 tháng)
                var monthsUsed = ((DateTime.Now.Year - PurchaseDate.Year) * 12) + DateTime.Now.Month - PurchaseDate.Month;
                if (monthsUsed <= 0) return 0;
                if (monthsUsed >= 60) return 100;
                return (monthsUsed * 100) / 60;
            }
        }


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