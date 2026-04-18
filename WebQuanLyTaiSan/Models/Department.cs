using System.ComponentModel.DataAnnotations;

namespace WebQuanLyTaiSan.Models
{
    public class Department : BaseEntity
    {
        [Required(ErrorMessage = "Mã phòng ban không được để trống")]
        [Display(Name = "Mã phòng ban")]
        [StringLength(20)]
        public string DeptCode { get; set; } = string.Empty; // Ví dụ: IT, HR, ACC

        [Required(ErrorMessage = "Tên phòng ban không được để trống")]
        [Display(Name = "Tên phòng ban")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Vị trí/Tầng")]
        [StringLength(200)]
        public string? Location { get; set; }

        [Display(Name = "Trưởng phòng")]
        public string? ManagerName { get; set; }

        // --- Navigation Properties ---

        // Danh sách nhân viên thuộc phòng
        public virtual ICollection<Employee> Employees { get; set; }

        // Danh sách máy tính thuộc phòng
        public virtual ICollection<Computer> Computers { get; set; }

        // --- Logic tính toán ---

        [Display(Name = "Tổng nhân sự")]
        public int EmployeeCount => Employees?.Count ?? 0;

        [Display(Name = "Giá trị tài sản tại phòng")]
        [DisplayFormat(DataFormatString = "{0:N0} VNĐ")]
        // Sử dụng thuộc tính CurrentTotalValue (đã tính cả giá máy + linh kiện)
        public decimal TotalDepartmentValue => Computers?.Sum(c => c.CurrentTotalValue) ?? 0;

        public Department()
        {
            Computers = new HashSet<Computer>();
            Employees = new HashSet<Employee>();
        }
    }
}