using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Context;
using GestaoRecursos.Models;

namespace GestaoRecursos.Controllers
{
    public class ListasTecnicasController : Controller
    {
        private readonly GestaoContext _context;

        public ListasTecnicasController(GestaoContext context)
        {
            _context = context;
        }

        // GET: ListasTecnicas
        public async Task<IActionResult> Index()
        {
            var gestaoContext = _context.ListasTecnicas.Include(l => l.MateriaPrima).Include(l => l.Produto);
            return View(await gestaoContext.ToListAsync());
        }

        // GET: ListasTecnicas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaTecnica = await _context.ListasTecnicas
                .Include(l => l.MateriaPrima)
                .Include(l => l.Produto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listaTecnica == null)
            {
                return NotFound();
            }

            return View(listaTecnica);
        }

        // GET: ListasTecnicas/Create
        public IActionResult Create()
        {
            ViewData["MateriaPrimaId"] = new SelectList(_context.Produtos.Where(x => x.TipoProduto.Nome == "Materia prima").ToList(), "Id", "Nome");
            ViewData["ProdutoId"] = new SelectList(_context.Produtos.Where(x => x.TipoProduto.Nome == "Produto acabado").ToList(), "Id", "Nome");
            return View();
        }

        // POST: ListasTecnicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProdutoId,MateriaPrimaId,Quantidade,Ativo,DataCriacao,DataAlteracao")] ListaTecnica listaTecnica)
        {

            listaTecnica.DataCriacao = DateTime.Now;
            listaTecnica.DataAlteracao = DateTime.Now;
            listaTecnica.Ativo = true;

            var listasTecnicas = _context.ListasTecnicas.ToList();

            if(listasTecnicas.Any(x => x.ProdutoId == listaTecnica.ProdutoId && x.MateriaPrimaId == listaTecnica.MateriaPrimaId)){
                ModelState.AddModelError("MateriaPrimaId", "Este material já existe para este produto.");
            }
            

            if (ModelState.IsValid)
            {
                _context.Add(listaTecnica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MateriaPrimaId"] = new SelectList(_context.Produtos.Where(x => x.TipoProduto.Nome == "Materia prima").ToList(), "Id", "Nome");
            ViewData["ProdutoId"] = new SelectList(_context.Produtos.Where(x => x.TipoProduto.Nome == "Produto acabado").ToList(), "Id", "Nome");
            return View(listaTecnica);
        }

        // GET: ListasTecnicas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaTecnica = await _context.ListasTecnicas.FindAsync(id);
            if (listaTecnica == null)
            {
                return NotFound();
            }
            ViewData["MateriaPrimaId"] = new SelectList(_context.Produtos.Where(x => x.TipoProduto.Nome == "Materia prima").ToList(), "Id", "Nome");
            ViewData["ProdutoId"] = new SelectList(_context.Produtos.Where(x => x.TipoProduto.Nome == "Produto acabado").ToList(), "Id", "Nome");
            return View(listaTecnica);
        }

        // POST: ListasTecnicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProdutoId,MateriaPrimaId,Quantidade,Ativo,DataCriacao,DataAlteracao")] ListaTecnica listaTecnica)
        {
            if (id != listaTecnica.Id)
            {
                return NotFound();
            }

            listaTecnica.DataCriacao = DateTime.Now;
            listaTecnica.DataAlteracao = DateTime.Now;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listaTecnica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListaTecnicaExists(listaTecnica.Id))
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
            ViewData["MateriaPrimaId"] = new SelectList(_context.Produtos.Where(x => x.TipoProduto.Nome == "Materia prima").ToList(), "Id", "Nome", listaTecnica.MateriaPrimaId);
            ViewData["ProdutoId"] = new SelectList(_context.Produtos.Where(x => x.TipoProduto.Nome == "Produto acabado").ToList(), "Id", "Nome", listaTecnica.ProdutoId);
            return View(listaTecnica);
        }

        // GET: ListasTecnicas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaTecnica = await _context.ListasTecnicas
                .Include(l => l.MateriaPrima)
                .Include(l => l.Produto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listaTecnica == null)
            {
                return NotFound();
            }

            return View(listaTecnica);
        }

        // POST: ListasTecnicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listaTecnica = await _context.ListasTecnicas.FindAsync(id);
            if (listaTecnica != null)
            {
                _context.ListasTecnicas.Remove(listaTecnica);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListaTecnicaExists(int id)
        {
            return _context.ListasTecnicas.Any(e => e.Id == id);
        }
    }
}
