using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebQuanLyTaiSan.Data;
using WebQuanLyTaiSan.Models;
using Microsoft.AspNetCore.Http; // Để dùng IFormFile
using System.IO; // Để dùng Path và FileStream

namespace WebQuanLyTaiSan.Controllers
{
    public class MaintenanceLogsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaintenanceLogsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MaintenanceLogs
        public async Task<IActionResult> Index()
        {
            var logs = await _context.MaintenanceLogs
                .Where(m => !m.IsDeleted)
                .Include(m => m.Computer)
                .OrderByDescending(m => m.RepairDate)
                .AsNoTracking()
                .ToListAsync();
            return View(logs);
        }

        // GET: MaintenanceLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var maintenanceLog = await _context.MaintenanceLogs
                .Include(m => m.Computer) // Quan trọng nhất dòng này!
                .FirstOrDefaultAsync(m => m.Id == id);

            if (maintenanceLog == null) return NotFound();

            return View(maintenanceLog);
        }

        // GET: MaintenanceLogs/Create
        public IActionResult Create()
        {
            var model = new MaintenanceLog
            {
                RepairDate = DateTime.Now
            };
            // Lấy danh sách máy tính và "gộp" thông tin để hiển thị
            var computerList = _context.Computers
                .Select(c => new {
                    Id = c.Id,
                    // Tạo một chuỗi hiển thị gồm Mã - Tên
                    DisplayName = c.AssetCode + " - " + c.Name
                })
                .ToList();

            ViewData["ComputerId"] = new SelectList(computerList, "Id", "DisplayName");
            return View(model);
        }

        // POST: MaintenanceLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> Create([Bind("RepairDate,Description,Cost,ComputerId, Status, ServiceProvider")] MaintenanceLog log, IFormFile? imageFile) 
        {
            if (ModelState.IsValid)
            {
                if (imageFile != null && imageFile.Length > 0)
                {
                    // Tạo tên file duy nhất
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);

                    // Đường dẫn đến thư mục wwwroot/images/maintenance
                    string uploadDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "maintenance");

                    // Tạo thư mục nếu chưa tồn tại
                    if (!Directory.Exists(uploadDir)) Directory.CreateDirectory(uploadDir);

                    string filePath = Path.Combine(uploadDir, fileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(fileStream);
                    }

                    // Lưu tên file vào database
                    log.ImageUrl = fileName;
                }

                _context.Add(log);

                // Tự động cập nhật trạng thái máy tính sang "Bảo trì"
                var computer = await _context.Computers.FindAsync(log.ComputerId);
                if (computer != null)
                {
                    computer.Status = "Bảo trì";
                    TempData["Success"] = $"Đã tạo phiếu bảo trì và cập nhật trạng thái máy {computer.AssetCode} sang Bảo trì.";
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(log);
        }

        // GET: MaintenanceLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenanceLog = await _context.MaintenanceLogs.FindAsync(id);
            if (maintenanceLog == null)
            {
                return NotFound();
            }
            // Lấy danh sách máy tính và "gộp" thông tin để hiển thị
            var computerList = _context.Computers
                .Select(c => new {
                    Id = c.Id,
                    // Tạo một chuỗi hiển thị gồm Mã - Tên
                    DisplayName = c.AssetCode + " - " + c.Name
                })
                .ToList();

            ViewData["ComputerId"] = new SelectList(computerList, "Id", "DisplayName", maintenanceLog.ComputerId);
            return View(maintenanceLog);
        }

        // POST: MaintenanceLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RepairDate,Description,Cost,ComputerId, Status, ServiceProvider")] MaintenanceLog maintenanceLog, IFormFile? imageFile)
        {
            if (id != maintenanceLog.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    var existingLog = await _context.MaintenanceLogs.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);
                    if (existingLog == null) return NotFound();

                    if (imageFile != null && imageFile.Length > 0)
                    {
                        
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                        string uploadDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "maintenance");

                        if (!Directory.Exists(uploadDir)) Directory.CreateDirectory(uploadDir);
                        string filePath = Path.Combine(uploadDir, fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await imageFile.CopyToAsync(stream);
                        }

                        // 2. Xóa ảnh cũ nếu có (để dọn dẹp bộ nhớ)
                        if (!string.IsNullOrEmpty(maintenanceLog.ImageUrl))
                        {
                            string oldPath = Path.Combine(uploadDir, existingLog.ImageUrl);
                            if (System.IO.File.Exists(oldPath)) System.IO.File.Delete(oldPath);
                        }

                        maintenanceLog.ImageUrl = fileName;
                    }
                    else
                    {
                        maintenanceLog.ImageUrl = existingLog.ImageUrl;
                    }

                    _context.Update(maintenanceLog);
                    await _context.SaveChangesAsync();

                    TempData["Success"] = "Cập nhật nhật ký bảo trì thành công.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaintenanceLogExists(maintenanceLog.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            var computerList = _context.Computers
                .Select(c => new {
                     Id = c.Id,
                     DisplayName = c.AssetCode + " - " + c.Name
                }).ToList();
            ViewData["ComputerId"] = new SelectList(computerList, "Id", "DisplayName", maintenanceLog.ComputerId);
            return View(maintenanceLog);
        }

        // GET: MaintenanceLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenanceLog = await _context.MaintenanceLogs
                .Include(m => m.Computer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maintenanceLog == null)
            {
                return NotFound();
            }

            return View(maintenanceLog);
        }

        // POST: MaintenanceLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var log = await _context.MaintenanceLogs.FindAsync(id);
            if (log != null)
            {
                log.IsDeleted = true;
                log.DeletedAt = DateTimeOffset.Now;
                log.DeletedBy = User.Identity?.Name ?? "Admin";

                // Sau khi bảo trì xong (hoặc hủy phiếu), trả trạng thái máy về bình thường
                var computer = await _context.Computers.FindAsync(log.ComputerId);
                if (computer != null && computer.Status == "Bảo trì")
                {
                    computer.Status = "Đang sử dụng";
                }

                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Trash()
        {
            var deletedLogs = await _context.MaintenanceLogs
                .IgnoreQueryFilters()
                .Where(m => m.IsDeleted)
                .Include(m => m.Computer)
                .ToListAsync();
            return View(deletedLogs);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Restore(int id)
        {
            var log = await _context.MaintenanceLogs
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (log == null) return NotFound();

            log.IsDeleted = false;
            log.DeletedAt = null;

            var computer = await _context.Computers.FindAsync(log.ComputerId);
            if (computer != null) computer.Status = "Bảo trì";

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Trash));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePermanently(int id)
        {
            var log = await _context.MaintenanceLogs
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (log == null) return NotFound();

            // 1. Xóa file ảnh vật lý nếu có
            if (!string.IsNullOrEmpty(log.ImageUrl))
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "maintenance", log.ImageUrl);
                if (System.IO.File.Exists(filePath)) System.IO.File.Delete(filePath);
            }

            // 2. Xóa khỏi Database
            _context.MaintenanceLogs.Remove(log);
            await _context.SaveChangesAsync();

            TempData["Success"] = "Đã xóa vĩnh viễn bản ghi và tệp tin đính kèm.";
            return RedirectToAction(nameof(Trash));
        }

        private bool MaintenanceLogExists(int id)
        {
            return _context.MaintenanceLogs.Any(e => e.Id == id);
        }
    }
}
