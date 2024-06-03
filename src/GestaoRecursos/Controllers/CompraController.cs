using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Context;
using Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace GestaoRecursos.Controllers
{
    [Authorize(Roles = "Admin, Compra")]
    public class CompraController : Controller
    {
        private readonly GestaoContext _context;

        public CompraController(GestaoContext context)
        {
            _context = context;
        }

        // GET: Compra
        public async Task<IActionResult> Index()
        {
            var gestaoContext = _context.Compra.Include(c => c.Produto).Include(c => c.Fornecedor);
            return View(await gestaoContext.ToListAsync());
        }

        // GET: Compra/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compra
                .Include(c => c.Produto)
                .Include(c => c.Fornecedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compra == null)
            {
                return NotFound();
            }

            return View(compra);
        }

        // GET: Compra/Create
        public IActionResult Create()
        {
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome");
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedores, "Id", "Nome").Prepend(new SelectListItem
            { 
                Text = "Selecione",
                Value = "",
                Disabled = true,
                Selected = true
            });

            return View();
        }

        // POST: Compra/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProdutoId,FornecedorId,Ativo,DataCriacao,DataAlteracao,Quantidade")] Compra compra)
        {
                compra.DataCriacao = DateTime.Now;
                compra.DataAlteracao = DateTime.Now;
                compra.Ativo = true;
                 _context.Add(compra);
                await _context.SaveChangesAsync();
               return RedirectToAction(nameof(Index));

            ViewData["FornecedorId"] = new SelectList(_context.Fornecedores, "Id", "Nome", compra.FornecedorId);
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome", compra.ProdutoId);

        }

        // GET: Compra/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compra.FindAsync(id);
            if (compra == null)
            {
                return NotFound();
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome", compra.ProdutoId);
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedores, "Id", "Nome", compra.FornecedorId);

            return View(compra);
        }

        // POST: Compra/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProdutoId,FornecedorId,Ativo,DataCriacao,DataAlteracao,Quantidade,Fornecedor")] Compra compra)
        {
            if (id != compra.Id)
            {
                return NotFound();
            }

            try
            {
                compra.DataAlteracao = DateTime.Now;
                _context.Update(compra);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompraExists(compra.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome", compra.ProdutoId);
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedores, "Id", "Nome", compra.FornecedorId);

            return RedirectToAction(nameof(Index));
        }

        // GET: Compra/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compra
                .Include(c => c.Produto)
                .Include(c => c.Fornecedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compra == null)
            {
                return NotFound();
            }

            ViewData["FornecedorId"] = compra.Fornecedor.Nome;
            return View(compra);
        }

        // POST: Compra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compra = await _context.Compra.FindAsync(id);
            if (compra != null)
            {
                _context.Compra.Remove(compra);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompraExists(int id)
        {
            return _context.Compra.Any(e => e.Id == id);
        }
    }
}
