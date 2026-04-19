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
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories
                .Where(c => !c.IsDeleted) // chỉ lấy danh mục chưa bj xoá
                .Include(c => c.Computers)
                .Include(c => c.Components)
                .AsNoTracking() // Giúp truy vấn nhanh hơn cho mục đích Read-only
                .ToListAsync();
            return View(categories);
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var category = await _context.Categories
                .Include(c => c.Computers)  // Nạp danh sách máy tính
                .Include(c => c.Components) // Nạp danh sách linh kiện
                .FirstOrDefaultAsync(m => m.Id == id);

            if (category == null) return NotFound();

            return View(category);  
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryCode,Name,Description,Group,Icon")] Category category)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra trùng tên (không phân biệt hoa thường)
                bool exists = await _context.Categories.AnyAsync(c => c.Name.ToLower() == category.Name.ToLower());
                if (exists)
                {
                    ModelState.AddModelError("Name", "Tên danh mục này đã tồn tại!");
                    return View(category);
                }

                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryCode,Name,Description,Group,Icon")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
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
            return View(category);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // 1. Tìm danh mục kèm theo các liên kết để kiểm tra ràng buộc
            var category = await _context.Categories
                .Include(c => c.Computers)
                .Include(c => c.Components)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category == null) return NotFound();
            

            if (!category.IsSafeToDelete)
            {
                TempData["ErrorMessage"] = "Không thể xóa danh mục này vì vẫn còn tài sản đang hoạt động thuộc danh mục!";
                return RedirectToAction(nameof(Delete), new { id = id });
            }

            // 3. THỰC HIỆN XÓA MỀM (Soft Delete)
            category.IsDeleted = true;
            _context.Update(category);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Đã xóa danh mục thành công!";
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
