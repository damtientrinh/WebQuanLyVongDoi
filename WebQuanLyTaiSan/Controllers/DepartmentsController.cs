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
    public class DepartmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Departments
        public async Task<IActionResult> Index()
        {
            var departments = _context.Departments
                .Where(d => !d.IsDeleted)
                .Include(d => d.Computers)
                .AsNoTracking(); // Tốc độ xử lý sẽ nhanh hơn đáng kể
            return View(await departments.ToListAsync());
        }

        // GET: Departments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var department = await _context.Departments
                .Include(d => d.Computers) // Nạp danh sách máy tính
                    .ThenInclude(c => c.Components) // Nạp danh sách link kiện của máy đó
                .FirstOrDefaultAsync(m => m.Id == id);

            if (department == null) return NotFound();

            var availableComputers = await _context.Computers
                .Where(c => c.DepartmentId == null || c.Status == "Trong kho")
                .Select(c => new {
                    Id = c.Id,
                    DisplayName = c.AssetCode + " - " + c.Name
                }).ToListAsync();

            ViewBag.AvailableComputers = new SelectList(availableComputers, "Id", "DisplayName");

            return View(department);
        }

        // GET: Departments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Departments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Location, ManagerName, DeptCode")] Department department)
        {
            if (ModelState.IsValid)
            {
                bool exists = await _context.Departments.AnyAsync(d =>
                    d.Name.ToLower() == department.Name.ToLower() ||
                    d.DeptCode.ToLower() == department.DeptCode.ToLower()
                );

                if (exists)
                {
                    ModelState.AddModelError("Name", "Phòng ban này đã tồn tại!");
                    return View(department);
                }
                _context.Add(department);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        // GET: Departments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var department = await _context.Departments.FindAsync(id);

            if (department == null || department.IsDeleted) return NotFound(); // Không cho sửa đồ đã vào thùng rác
            return View(department);
        }

        // POST: Departments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Location, ManagerName, DeptCode")] Department department)
        {
            if (id != department.Id) return NotFound();
            

            if (ModelState.IsValid)
            {
                try
                {
                    var existingDept = await _context.Departments.FindAsync(id);
                    if (existingDept == null) return NotFound();

                    // Chỉ cập nhật các trường thay đổi từ Form
                    existingDept.Name = department.Name;
                    existingDept.Location = department.Location;
                    existingDept.ManagerName = department.ManagerName;
                    existingDept.DeptCode = department.DeptCode;

                    // Cập nhật metadata từ BaseEntity
                    existingDept.UpdatedAt = DateTimeOffset.Now;
                    existingDept.UpdatedBy = User.Identity?.Name ?? "Admin";

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if  (!DepartmentExists(department.Id)) return NotFound();
                    
                    else throw;
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        // GET: Departments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var department = await _context.Departments
                .Include(d => d.Employees)
                .Include(d => d.Computers)
                    .ThenInclude(c => c.Components)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (department == null) return NotFound();

            return View(department);
        }

        // POST: Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var department = await _context.Departments
                .Include(d => d.Computers)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (department != null)
            {
                // Gỡ tất cả máy tính khỏi phòng này trước khi xóa phòng
                foreach (var computer in department.Computers)
                {
                    computer.DepartmentId = null;
                    computer.Status = "Trong kho";
                }
                department.IsDeleted = true;
                department.DeletedAt = DateTimeOffset.Now;
                department.DeletedBy = User.Identity?.Name ?? "Admin";

                _context.Departments.Update(department);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Trash()
        {
            var deletedDepartment = await _context.Departments
                .IgnoreQueryFilters()
                .Where(d => d.IsDeleted == true)
                .AsNoTracking()
                .ToListAsync();
            return View(deletedDepartment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Restore(int id)
        {
            var department = await _context.Departments
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(d => d.Id == id);

            if (department == null) return NotFound();

            department.IsDeleted = false;
            department.DeletedAt = null;
            department.UpdatedAt = DateTimeOffset.Now;
            department.UpdatedBy = User.Identity?.Name ?? "Admin";

            _context.Update(department);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Trash));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HardDelete(int id)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Trash));
        }

        private bool DepartmentExists(int id)
        {
            return _context.Departments.Any(e => e.Id == id);
        }
    }
}
