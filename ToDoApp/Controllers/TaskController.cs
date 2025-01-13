using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Models.Data;
using ToDoTask = ToDoApp.Models.Task;

namespace ToDoApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string search, string sortOrder, DateTime? startDate, DateTime? endDate)
        {
            var tasks = _context.Tasks.AsQueryable();

            // Передача значений в ViewData для отображения в форме
            ViewData["Search"] = search;
            ViewData["StartDate"] = startDate?.ToString("yyyy-MM-dd"); // Формат для input type="date"
            ViewData["EndDate"] = endDate?.ToString("yyyy-MM-dd");

            // Фильтрация по названию
            if (!string.IsNullOrEmpty(search))
            {
                tasks = tasks.Where(t => t.Title.Contains(search));
            }

            // Фильтрация по диапазону дат
            if (startDate.HasValue)
            {
                tasks = tasks.Where(t => t.CreatedAt >= startDate.Value);
            }
            if (endDate.HasValue)
            {
                tasks = tasks.Where(t => t.CreatedAt <= endDate.Value);
            }

            // Сортировка
            tasks = sortOrder switch
            {
                "date" => tasks.OrderBy(t => t.CreatedAt),
                "status" => tasks.OrderBy(t => t.IsCompleted),
                _ => tasks
            };

            return View(await tasks.ToListAsync());
        }
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ToDoTask task)
        {
            if (ModelState.IsValid)
            {
                task.CreatedAt = DateTime.Now;
                _context.Add(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null) return NotFound();
            return View(task);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ToDoTask task)
        {
            if (id != task.ID) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null) return NotFound();

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
