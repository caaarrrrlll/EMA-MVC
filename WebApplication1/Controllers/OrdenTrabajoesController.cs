using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OrdenTrabajoesController : Controller
    {
        private readonly ServerEMA _context;

        public OrdenTrabajoesController(ServerEMA context)
        {
            _context = context;
        }

        // GET: OrdenTrabajoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrdenTrabajo.ToListAsync());
        }

        // GET: OrdenTrabajoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenTrabajo = await _context.OrdenTrabajo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordenTrabajo == null)
            {
                return NotFound();
            }

            return View(ordenTrabajo);
        }

        // GET: OrdenTrabajoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrdenTrabajoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreEquipo,CodigoEquipo,TipoMantenimiento,FechaIngreso,FechaEntrega,DescripcionProblema,Observaciones,Estado")] OrdenTrabajo ordenTrabajo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordenTrabajo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordenTrabajo);
        }

        // GET: OrdenTrabajoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenTrabajo = await _context.OrdenTrabajo.FindAsync(id);
            if (ordenTrabajo == null)
            {
                return NotFound();
            }
            return View(ordenTrabajo);
        }

        // POST: OrdenTrabajoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreEquipo,CodigoEquipo,TipoMantenimiento,FechaIngreso,FechaEntrega,DescripcionProblema,Observaciones,Estado")] OrdenTrabajo ordenTrabajo)
        {
            if (id != ordenTrabajo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordenTrabajo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdenTrabajoExists(ordenTrabajo.Id))
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
            return View(ordenTrabajo);
        }

        // GET: OrdenTrabajoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenTrabajo = await _context.OrdenTrabajo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordenTrabajo == null)
            {
                return NotFound();
            }

            return View(ordenTrabajo);
        }

        // POST: OrdenTrabajoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordenTrabajo = await _context.OrdenTrabajo.FindAsync(id);
            if (ordenTrabajo != null)
            {
                _context.OrdenTrabajo.Remove(ordenTrabajo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdenTrabajoExists(int id)
        {
            return _context.OrdenTrabajo.Any(e => e.Id == id);
        }
    }
}
