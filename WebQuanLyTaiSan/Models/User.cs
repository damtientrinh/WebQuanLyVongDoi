using System.ComponentModel.DataAnnotations;

namespace WebQuanLyTaiSan.Models
{
    public class User : BaseEntity
    {
        // Bạn đã có Id ở BaseEntity rồi, không cần [Key] public int Id ở đây nữa

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "Mật khẩu từ 6 đến 255 ký tự")]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Quyền hạn")]
        public string Role { get; set; } = "Staff"; // Admin, Manager, Staff

        [Display(Name = "Trạng thái tài khoản")]
        public bool IsActive { get; set; } = true;
    }
}