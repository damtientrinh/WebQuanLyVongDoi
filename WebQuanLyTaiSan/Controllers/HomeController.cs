using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebQuanLyTaiSan.Data;
using WebQuanLyTaiSan.Models;

namespace WebQuanLyTaiSan.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // --- CÁC CARD THỐNG KÊ ---
            ViewBag.TotalComputers = await _context.Computers.CountAsync();
            ViewBag.TotalComponents = await _context.Components.CountAsync();
            ViewBag.TotalDepartments = await _context.Departments.CountAsync();

            // Thống kê trạng thái máy tính
            ViewBag.ActiveCount = await _context.Computers.CountAsync(c => c.Status == "Đang dùng");
            ViewBag.MaintenanceCount = await _context.Computers.CountAsync(c => c.Status == "Bảo trì");
            ViewBag.BrokenCount = await _context.Computers.CountAsync(c => c.Status == "Hỏng");

            // Tổng chi phí bảo trì tích lũy (Hiển thị con số ấn tượng trên Dashboard)
            ViewBag.TotalRepairCost = await _context.MaintenanceLogs.SumAsync(m => m.Cost);

            // --- DANH SÁCH GẦN ĐÂY ---
            var recentComputers = await _context.Computers
                .Include(c => c.Department)
                .OrderByDescending(c => c.Id)
                .Take(5)
                .ToListAsync();

            return View(recentComputers);
        }

        [HttpGet]
        public async Task<IActionResult> GetMaintenanceChartData()
        {
            var currentYear = DateTime.Now.Year;
            // Lấy dữ liệu và thực hiện tính toán trên bộ nhớ để đảm bảo tính ổn định
            var logs = await _context.MaintenanceLogs
                .Where(m => m.RepairDate.Year == currentYear)
                .Select(m => new { m.RepairDate.Month, m.Cost })
                .ToListAsync();

            var monthlyCosts = new decimal[12];
            foreach (var month in Enumerable.Range(1, 12))
            {
                monthlyCosts[month - 1] = logs.Where(l => l.Month == month).Sum(l => l.Cost);
            }

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