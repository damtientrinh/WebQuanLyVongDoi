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
    public class ComponentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComponentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Components
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var components = _context.Components
                .Where(c => !c.IsDeleted)
                .Include(c => c.Category)
                .Include(c => c.Computer)
                .AsNoTracking(); // Thêm cái này để tăng tốc độ load trang danh sách

            if (!string.IsNullOrEmpty(searchString))
            {
                components = components.Where(c => c.Name.Contains(searchString)
                            || c.SerialNumber.Contains(searchString));
            }

            return View(await components.ToListAsync());
        }

        // GET: Components/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var component = await _context.Components
                .Include(c => c.Category)
                .Include(c => c.Computer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (component == null)
            {
                return NotFound();
            }

            return View(component);
        }

        // GET: Components/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories.Where(c => !c.IsDeleted), "Id", "Name");

            // 1. Lấy danh sách máy tính chưa xóa
            var computers = _context.Computers
                .Where(c => !c.IsDeleted)
                .Select(c => new {
                    Id = c.Id,
                    DisplayText = c.AssetCode + " - " + c.Name // Tạo trường hiển thị gộp
                })
                .ToList();

            // 2. Gán vào SelectList: "Id" là giá trị lưu, "DisplayText" là cái người dùng thấy
            ViewData["ComputerId"] = new SelectList(computers, "Id", "DisplayText");

            return View();
        }

        // POST: Components/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SerialNumber,Price,CategoryId,ComputerId")] Component component)
        {
            if (ModelState.IsValid)
            {
                bool serialExists = await _context.Components.AnyAsync(c => c.SerialNumber == component.SerialNumber && !c.IsDeleted);
                if (serialExists)
                {
                    ModelState.AddModelError("SerialNumber", "Số Serial này đã tồn tại!");
                }
                else
                {
                    component.Status = component.ComputerId.HasValue ? "Đang sử dụng" : "Trong kho";
                    component.CreatedAt = DateTime.Now;
                    _context.Add(component);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }

            ViewData["CategoryId"] = new SelectList(_context.Categories.Where(c => !c.IsDeleted), "Id", "Name", component.CategoryId);

            var computers = _context.Computers
                .Where(c => !c.IsDeleted)
                .Select(c => new {
                    Id = c.Id,
                    DisplayText = c.AssetCode + " - " + c.Name
                }).ToList();

            ViewData["ComputerId"] = new SelectList(computers, "Id", "DisplayText", component.ComputerId);

            return View(component);
        }

        // GET: Components/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var component = await _context.Components.FindAsync(id);
            if (component == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", component.CategoryId);
            ViewData["ComputerId"] = new SelectList(_context.Computers, "Id", "AssetCode", component.ComputerId);
            return View(component);
        }

        // POST: Components/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,SerialNumber,Price,CategoryId,ComputerId")] Component component)
        {
            if (id != component.Id) return NotFound();


            if (ModelState.IsValid)
            {
                // Kiểm tra trùng Serial với máy KHÁC
                bool serialExists = await _context.Components.AnyAsync(c => c.SerialNumber == component.SerialNumber && c.Id != id && !c.IsDeleted);
                if (serialExists)
                {
                    ModelState.AddModelError("SerialNumber", "Số Serial này đã thuộc về linh kiện khác!");
                }
                else
                {
                    try
                    {
                        // Cập nhật trạng thái dựa trên việc có lắp vào máy hay không
                        component.Status = component.ComputerId.HasValue ? "Đang sử dụng" : "Trong kho";
                        component.UpdatedAt = DateTime.Now;

                        _context.Update(component);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ComponentExists(component.Id)) return NotFound();
                        else throw;
                    }
                }
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories
                                    .Where(c => !c.IsDeleted), "Id", "Name", component.CategoryId);
            ViewData["ComputerId"] = new SelectList(_context.Computers
                                    .Where(c => !c.IsDeleted), "Id", "AssetCode", component.ComputerId);
            return View(component);
        }

        // GET: Components/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var component = await _context.Components
                .Include(c => c.Category)
                .Include(c => c.Computer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (component == null)
            {
                return NotFound();
            }

            return View(component);
        }

        // POST: Components/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var component = await _context.Components.FindAsync(id);
            if (component != null)
            {
                component.IsDeleted = true; // Đánh dấu xóa
                component.UpdatedAt = DateTime.Now; // Lưu vết thời gian
                _context.Update(component);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Đã xóa linh kiện thành công!";
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Trash()
        {
            var components = await _context.Components
                .Include(c => c.Category)
                .Include(c => c.Computer)
                .Where(c => c.IsDeleted)
                .ToListAsync();

            return View(components.OrderByDescending(x => x.DeletedAt).ToList());
        }

        private bool ComponentExists(int id)
        {
            return _context.Components.Any(e => e.Id == id);
        }
    }
}