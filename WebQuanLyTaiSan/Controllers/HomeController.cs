using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebQuanLyTaiSan.Data;
using WebQuanLyTaiSan.Models;

namespace WebQuanLyTaiSan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // 1. Thống kê nhanh cho các Card
            ViewBag.TotalComputers = await _context.Computers.CountAsync();
            ViewBag.TotalComponents = await _context.Components.CountAsync();

            ViewBag.BrokenComputers = await _context.Computers.CountAsync(c => c.Status == "Bảo trì" || c.Status == "Hỏng");

            // Đếm tổng số LƯỢT bảo trì (từ bảng MaintenanceLog)
            ViewBag.MaintenanceCount = await _context.MaintenanceLogs.CountAsync();

            ViewBag.TotalDepartments = await _context.Departments.CountAsync();

            ViewBag.TotalMaintenanceLogs = await _context.MaintenanceLogs.CountAsync();

            // 1. Đếm máy đang dùng (Màu xanh)
            ViewBag.ActiveCount = await _context.Computers.CountAsync(c => c.Status == "Đang dùng");

            // 2. Đếm máy đang bảo trì (Màu vàng)
            ViewBag.MaintenanceCount = await _context.Computers.CountAsync(c => c.Status == "Bảo trì");

            // 3. Đếm máy bị hỏng (Màu đỏ)
            ViewBag.BrokenOnlyCount = await _context.Computers.CountAsync(c => c.Status == "Hỏng");

            // 2. Lấy 5 máy tính mới nhất
            var recentComputers = await _context.Computers
                .Include(c => c.Department)
                .OrderByDescending(c => c.Id)
                .Take(5)
                .ToListAsync();

            return View(recentComputers);
        }

        // --- WEB API CHO AJAX ---
        // Hàm này trả về dữ liệu JSON để vẽ biểu đồ mà không cần load lại trang
        [HttpGet]
        public async Task<IActionResult> GetMaintenanceChartData()
        {
            var currentYear = DateTime.Now.Year;
            var maintenanceData = await _context.MaintenanceLogs
                .AsNoTracking()
                .Where(m => m.RepairDate.Year == currentYear)
                .GroupBy(m => m.RepairDate.Month)
                .Select(g => new { Month = g.Key, Total = g.Sum(m => m.Cost) })
                .ToListAsync();

            var monthlyCosts = new decimal[12];
            foreach (var item in maintenanceData)
            {
                monthlyCosts[item.Month - 1] = item.Total;
            }

            // Trả về dữ liệu kiểu JSON cho AJAX gọi
            return Json(new
            {
                costs = monthlyCosts,
                labels = new[] { "Tháng 1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "T10", "T11", "T12" }
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}