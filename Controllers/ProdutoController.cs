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

namespace GestaoRecursos.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        private readonly GestaoContext _context;

        public ProdutoController(GestaoContext context)
        {
            _context = context;
        }

        // GET: Produto
        public async Task<IActionResult> Index()
        {
            var gestaoContext = _context.Produtos.Include(p => p.TipoProduto);
            return View(await gestaoContext.ToListAsync());
        }

        // GET: Produto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.TipoProduto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produto/Create
        [Authorize(Roles = "Admin, Producao, Compra")]
        public IActionResult Create()
        {
            ViewData["TipoProdutoId"] = new SelectList(_context.TipoProdutos, "Id", "Nome");
            return View();
        }

        // POST: Produto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Producao, Compra")]
        public async Task<IActionResult> Create([Bind("Id,Nome,TipoProdutoId,Ativo,DataCriacao,DataAlteracao")] Produto produto)
        {
            produto.DataCriacao = DateTime.Now;
            produto.DataAlteracao = DateTime.Now;
            produto.Ativo = true;

            _context.Add(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            ViewData["TipoProdutoId"] = new SelectList(_context.TipoProdutos, "Id", "Nome", produto.TipoProdutoId);
            return View(produto);
        }

        // GET: Produto/Edit/5
        [Authorize(Roles = "Admin, Producao, Compra")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            ViewData["TipoProdutoId"] = new SelectList(_context.TipoProdutos, "Id", "Nome", produto.TipoProdutoId);
            return View(produto);
        }

        // POST: Produto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Producao, Compra")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,TipoProdutoId,Ativo,DataAlteracao")] Produto produto)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }
            
            produto.DataAlteracao = DateTime.Now;

            try
            {
                _context.Update(produto);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoExists(produto.Id))
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

        // GET: Produto/Delete/5
        [Authorize(Roles = "Admin, Producao, Compra")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.TipoProduto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Producao, Compra")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
