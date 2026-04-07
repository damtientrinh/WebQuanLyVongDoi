using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebQuanLyTaiSan.Data;
using WebQuanLyTaiSan.Models;

namespace WebQuanLyTaiSan.Controllers
{
    public class ComputersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComputersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Computers
        public async Task<IActionResult> Index(string searchString, int? departmentId)
        {
            // Lưu lại giá trị để hiển thị lại trên Form lọc ở View
            ViewData["CurrentSearch"] = searchString;
            ViewData["CurrentDept"] = departmentId;

            var query = _context.Computers
                .Include(c => c.Category)
                .Include(c => c.Department)
                .Include(c => c.Components)
                .Include(c => c.MaintenanceLogs)
                .Where(c => !c.IsDeleted)
                .AsQueryable();

            // 1. Lọc theo từ khóa (Mã tài sản hoặc Tên máy)
            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(c => c.AssetCode.Contains(searchString) || c.Name.Contains(searchString));
            }

            // 2. Lọc theo Phòng ban
            if (departmentId.HasValue)
            {
                query = query.Where(c => c.DepartmentId == departmentId);
            }

            // Chuẩn bị danh sách phòng ban cho Dropdown lọc
            ViewBag.DepartmentId = new SelectList(_context.Departments, "Id", "Name", departmentId);

            return View(await query.ToListAsync());
        }

        // GET: Computers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computer = await _context.Computers
                .Include(c => c.Category)
                .Include(c => c.Department)
                .Include(c => c.Components)
                .Include(c => c.MaintenanceLogs)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computer == null)
            {
                return NotFound();
            }

            return View(computer);
        }

        // GET: Computers/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            return View();
        }

        // POST: Computers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AssetCode,Name,Status,PurchaseDate,CategoryId,DepartmentId")] Computer computer)
        {
            if (ModelState.IsValid)
            {
                bool exists = await _context.Computers.AnyAsync(c => c.AssetCode == computer.AssetCode);
                if (exists)
                {
                    ModelState.AddModelError("AssetCode", "Mã tài sản này đã tồn tại!");
                }
                else
                {
                    _context.Add(computer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", computer.CategoryId);
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", computer.DepartmentId);
            return View(computer);
        }

        // GET: Computers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computer = await _context.Computers.FindAsync(id);
            if (computer == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", computer.CategoryId);
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", computer.DepartmentId);
            return View(computer);
        }

        // POST: Computers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AssetCode,Name,Status,PurchaseDate,CategoryId,DepartmentId")] Computer computer)
        {
            if (id != computer.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(computer);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Cập nhật thông tin máy tính thành công!"; 
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComputerExists(computer.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", computer.CategoryId);
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", computer.DepartmentId);
            return View(computer);
        }

        // GET: Computers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computer = await _context.Computers
                .Include(c => c.Category)
                .Include(c => c.Department)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computer == null)
            {
                return NotFound();
            }

            return View(computer);
        }

        // POST: Computers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var computer = await _context.Computers
                .Include(c => c.Components) 
                .FirstOrDefaultAsync(m => m.Id == id);

            if (computer != null)
            {
                computer.IsDeleted = true;
                computer.DeletedAt = DateTime.Now;
                computer.UpdatedAt = DateTime.Now;
                computer.Status = "Đã thanh lý";

                // Giải phóng linh kiện trước khi xóa máy
                if (computer.Components != null)
                {
                    foreach (var component in computer.Components)
                    {
                        component.ComputerId = null;
                        component.Status = "Trong kho";
                    }
                }
                _context.Update(computer);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Đã xoá máy tính và đưa linh kiện về kho thành công!";
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Computers/Trash
        public async Task<IActionResult> Trash()
        {
            // 1. Lấy dữ liệu từ Database về
            var computers = await _context.Computers
                .Include(c => c.Category)
                .Include(c => c.Department)
                .Where(c => c.IsDeleted) 
                .ToListAsync(); // Đưa dữ liệu về RAM (List<Computer>)

            // 2. Sắp xếp bằng LINQ trên RAM 
            var trashedComputers = computers
                .OrderByDescending(c => c.DeletedAt)
                .ToList();

            return View(trashedComputers);
        }

        // POST: Computers/Restore/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Restore(int id)
        {
            var computer = await _context.Computers.FindAsync(id);
            if (computer != null)
            {
                computer.IsDeleted = false;
                computer.DeletedAt = null;
                computer.Status = "Trong kho"; 

                _context.Update(computer);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = $"Đã khôi phục máy tính {computer.AssetCode} thành công!";
            }
            return RedirectToAction(nameof(Trash));
        }

        // POST: Computers/DeletePermanent/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePermanent(int id)
        {
            var computer = await _context.Computers.FindAsync(id);
            if (computer != null)
            {
                _context.Computers.Remove(computer); // Đây mới là xóa thật khỏi DB
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Đã xóa vĩnh viễn máy tính khỏi hệ thống!";
            }
            return RedirectToAction(nameof(Trash));
        }

        private bool ComputerExists(int id)
        {
            return _context.Computers.Any(e => e.Id == id);
        }
    }
}
