using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebQuanLyTaiSan.Models
{
    public class User : BaseEntity
    {
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        [Display(Name = "Tên đăng nhập")]
        [StringLength(50)]
        public string Username { get; set; } = string.Empty; 

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string PasswordHash { get; set; } = string.Empty; // Lưu mật khẩu đã mã hóa

        [Display(Name = "Quyền hạn")]
        public string Role { get; set; } = "Staff"; // Admin, Manager, Staff

        [Display(Name = "Trạng thái")]
        public bool IsActive { get; set; } = true;

        // Liên kết tới nhân viên
        [Display(Name = "Nhân viên")]
        public int? EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee? Employee { get; set; }
    }
}