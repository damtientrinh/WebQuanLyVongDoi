using System.ComponentModel.DataAnnotations;

namespace WebQuanLyTaiSan.Models
{
    public class User : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Role { get; set; } = "User"; // Mặc định là User, có thể là Admin
    }
}