using System.ComponentModel.DataAnnotations;

namespace WebQuanLyTaiSan.Models
{
    public class Employee : BaseEntity
    {
        [Required(ErrorMessage = "Tên nhân viên không được để trống")]
        [Display(Name = "Họ và tên")]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mã nhân viên không được để trống")]
        [Display(Name = "Mã nhân viên")]
        [StringLength(20)]
        public string EmployeeCode { get; set; } = string.Empty; // Ví dụ: NV001

        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        [Display(Name = "Email công việc")]
        public string? Email { get; set; }

        [Display(Name = "Phòng ban")]
        public int DepartmentId { get; set; }

        [Display(Name = "Số điện thoại")]
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Trạng thái")]
        public bool IsActive { get; set; } = true; // True: Đang làm việc, False: Đã nghỉ
        public virtual Department? Department { get; set; }

        // Một nhân viên có thể sở hữu nhiều thiết bị
        public virtual ICollection<Computer> Computers { get; set; }

        public Employee()
        {
            Computers = new HashSet<Computer>();
        }
    }
}