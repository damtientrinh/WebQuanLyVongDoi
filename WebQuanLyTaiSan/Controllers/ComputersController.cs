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
            ViewData["CurrentSearch"] = searchString;
            ViewData["CurrentDept"] = departmentId;

            // Thêm AsNoTracking để tối ưu bộ nhớ
            var query = _context.Computers
                .AsNoTracking()
                .Include(c => c.Category)
                .Include(c => c.Department)
                .Include(c => c.Components)
                .Include(c => c.MaintenanceLogs)
                .Where(c => !c.IsDeleted)
                .AsQueryable();

            // 1. Lọc theo từ khóa
            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(c => c.AssetCode.Contains(searchString) || c.Name.Contains(searchString));
            }

            // 2. Lọc theo Phòng ban
            if (departmentId.HasValue)
            {
                query = query.Where(c => c.DepartmentId == departmentId);
            }

            ViewBag.DepartmentId = new SelectList(_context.Departments.AsNoTracking(), "Id", "Name", departmentId);

            // Thực thi truy vấn và gửi về View
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
        public async Task<IActionResult> Create([Bind("Id,AssetCode,Name,Status,PurchaseDate,PurchasePrice,WarrantyMonths,Supplier,Packaging,Accessories,CategoryId,DepartmentId")] Computer computer)
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
            if (id == null) return NotFound();

            var computer = await _context.Computers
                .Include(c => c.Components)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (computer == null) return NotFound();
            
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", computer.CategoryId);
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", computer.DepartmentId);
            return View(computer);
        }

        // POST: Computers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AssetCode,Name,Status,PurchaseDate,PurchasePrice,WarrantyMonths,Supplier,Packaging,Accessories,CategoryId,DepartmentId")] Computer computer)
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
            // 1. Lấy dữ liệu từ Database lên 
            var trashedComputersData = await _context.Computers
                .IgnoreQueryFilters()
                .Include(c => c.Category)
                .Include(c => c.Department)
                .Where(c => c.IsDeleted)
                .ToListAsync();

            // 2. Sắp xếp trên bộ nhớ (Client-side sorting)
            // Sau khi ToListAsync(), dữ liệu đã nằm trong RAM nên sắp xếp DateTimeOffset sẽ không bị lỗi
            var trashedComputers = trashedComputersData
                .OrderByDescending(c => c.DeletedAt)
                .ToList();

            return View(trashedComputers);
        }

        // POST: Computers/Restore/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Restore(int id)
        {
            var computer = await _context.Computers
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (computer != null)
            {
                computer.IsDeleted = false;
                computer.DeletedAt = null;
                computer.UpdatedAt = DateTime.Now;
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
            var computer = await _context.Computers
                .IgnoreQueryFilters()
                .Include(c => c.MaintenanceLogs)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (computer != null)
            {
                if (computer.Components != null && computer.Components.Any())
                {
                    foreach (var comp in computer.Components)
                    {
                        comp.ComputerId = null; // Gỡ khỏi máy
                        comp.Status = "Trong kho";
                        _context.Update(comp);
                    }
                }

                if (computer.MaintenanceLogs != null && computer.MaintenanceLogs.Any())
                {
                    _context.MaintenanceLogs.RemoveRange(computer.MaintenanceLogs);
                }

                _context.Computers.Remove(computer);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Đã xóa vĩnh viễn máy tính khỏi hệ thống!";
            }
            else
            {
                TempData["ErrorMessage"] = "Không tìm thấy dữ liệu để xóa!";
            }

            return RedirectToAction(nameof(Trash));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignToDepartment(int computerId, int deptId)
        {
            var computer = await _context.Computers.FindAsync(computerId);
            if (computer == null) return NotFound();

            // Cập nhật ID phòng ban và trạng thái
            computer.DepartmentId = deptId;
            computer.Status = "Đang dùng";
            computer.UpdatedAt = DateTimeOffset.Now;
            computer.UpdatedBy = User.Identity?.Name ?? "Admin";

            await _context.SaveChangesAsync();

            // Quay lại trang chi tiết của phòng ban đó
            return RedirectToAction("Details", "Departments", new { id = deptId });
        }

        private bool ComputerExists(int id)
        {
            return _context.Computers.Any(e => e.Id == id);
        }
    }
}
