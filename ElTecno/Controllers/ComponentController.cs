using ElTecno.Data;
using ElTecno.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElTecno.Controllers
{
    public class ComponentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComponentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Components.ToListAsync());
        }

        public IActionResult Form(int? id)
        {
            if (id == null)
                return View(new Component());

            var component = _context.Components.Find(id);
            if (component == null)
                return NotFound();

            return View(component);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(Component component)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (component.Id == 0)
                        _context.Add(component);
                    else
                        _context.Update(component);

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error al guardar: " + ex.Message);
                }
            }
            return View("Form", component);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var component = await _context.Components.FindAsync(id);
            if (component == null)
                return Json(new { success = false, message = "Componente no encontrado" });

            _context.Components.Remove(component);
            await _context.SaveChangesAsync();

            return Json(new { success = true, message = "Componente eliminado" });
        }
    }
}
