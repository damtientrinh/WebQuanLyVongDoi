namespace WebQuanLyTaiSan.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        // Metadata về thời gian
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset? UpdatedAt { get; set; }

        // Metadata về người thực hiện (Audit)
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        // Soft Delete (Nghiệp vụ thùng rác)
        public bool IsDeleted { get; set; } = false;
        public DateTimeOffset? DeletedAt { get; set; }
        public string? DeletedBy { get; set; } // Ai là người quăng vào thùng rác?
    }
}