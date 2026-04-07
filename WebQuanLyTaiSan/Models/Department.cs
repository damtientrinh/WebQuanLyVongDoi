using System.ComponentModel.DataAnnotations;

namespace WebQuanLyTaiSan.Models
{
    // Kế thừa BaseEntity để dùng chung Id, CreatedAt, IsDeleted
    public class Department : BaseEntity
    {
        [Required(ErrorMessage = "Tên phòng ban không được để trống")]
        [Display(Name = "Tên phòng ban")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Vị trí/Tầng")]
        [StringLength(200)]
        public string? Location { get; set; }

        [Display(Name = "Giá trị tài sản tại phòng")]
        [DisplayFormat(DataFormatString = "{0:N0} VNĐ")]
        // Sử dụng giá trị từ hàm Sum đã thiết lập ở Computer
        public decimal TotalDepartmentValue => Computers?.Sum(c => c.TotalValue) ?? 0;

        public virtual ICollection<Computer> Computers { get; set; }

        public Department()
        {
            Computers = new HashSet<Computer>(); // Dùng HashSet tối ưu hơn List cho ICollection
        }
    }
}