using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Context;
using GestaoRecursos.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Humanizer;
using Microsoft.AspNetCore.Components.Forms;

namespace GestaoRecursos.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PerfilUsuariosController : Controller
    {
        private readonly GestaoContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public PerfilUsuariosController(GestaoContext context, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }

        // GET: PerfilUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.PerfilUsuarios.ToListAsync());
        }

        // GET: PerfilUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfilUsuario = await _context.PerfilUsuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (perfilUsuario == null)
            {
                return NotFound();
            }
            return View(perfilUsuario);
        }

        // GET: PerfilUsuarios/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_roleManager.Roles, "Id", "Name").Prepend(new SelectListItem
            {
                Text = "Selecione",
                Value = "",
                Disabled = true,
                Selected = true
            }); 
            return View();
        }

        // POST: PerfilUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NomePerfil,Id,RoleId,Ativo,DataCriacao,DataAlteracao")] PerfilUsuario perfilUsuario)
        {
            if (ModelState.IsValid)
            {
                perfilUsuario.Ativo = true;
                perfilUsuario.DataCriacao = DateTime.Now;
                perfilUsuario.DataAlteracao = DateTime.Now;

                _context.Add(perfilUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_roleManager.Roles, "Id", "Name", perfilUsuario.RoleId);
            return View(perfilUsuario);
        }

        // GET: PerfilUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfilUsuario = await _context.PerfilUsuarios.FindAsync(id);
            if (perfilUsuario == null)
            {
                return NotFound();
            }

            ViewData["RoleId"] = new SelectList(_roleManager.Roles, "Id", "Name", perfilUsuario.RoleId);
            return View(perfilUsuario);
        }

        // POST: PerfilUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NomePerfil,Id,RoleId,Ativo,DataCriacao,DataAlteracao")] PerfilUsuario perfilUsuario)
        {
            if (id != perfilUsuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    perfilUsuario.DataAlteracao = DateTime.Now;

                    _context.Update(perfilUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerfilUsuarioExists(perfilUsuario.Id))
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
            ViewData["RoleId"] = new SelectList(_roleManager.Roles, "Id", "Name", perfilUsuario.RoleId);
            return View(perfilUsuario);
        }

        // GET: PerfilUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfilUsuario = await _context.PerfilUsuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (perfilUsuario == null)
            {
                return NotFound();
            }

            return View(perfilUsuario);
        }

        // POST: PerfilUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var perfilUsuario = await _context.PerfilUsuarios.FindAsync(id);
            if (perfilUsuario != null)
            {
                _context.PerfilUsuarios.Remove(perfilUsuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerfilUsuarioExists(int id)
        {
            return _context.PerfilUsuarios.Any(e => e.Id == id);
        }
    }
}
