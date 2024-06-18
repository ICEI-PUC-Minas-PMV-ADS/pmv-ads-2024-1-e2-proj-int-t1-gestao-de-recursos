using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Context;
using GestaoRecursos.Models;

namespace GestaoRecursos.Controllers
{
    public class LancamentosProducaoController : Controller
    {
        private readonly GestaoContext _context;

        public LancamentosProducaoController(GestaoContext context)
        {
            _context = context;
        }

        // GET: LancamentosProducao
        public async Task<IActionResult> Index()
        {

            var gestaoContext = _context.LancamentoProducao.Include(static l => l.ListaTecnica).ThenInclude(static l => l.Produto);
            return View(await gestaoContext.ToListAsync());
        }

        // GET: LancamentosProducao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lancamentoProducao = await _context.LancamentoProducao
                .Include(l => l.ListaTecnica)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lancamentoProducao == null)
            {
                return NotFound();
            }

            return View(lancamentoProducao);
        }

        // GET: LancamentosProducao/Create
        public IActionResult Create()
        {
            ViewData["ListaTecnicaId"] = new SelectList(
            _context.ListasTecnicas
            .Include(static x => x.Produto)
            .GroupBy(x => x.ProdutoId)
            .Select(x => x.First())
            .ToList(), "Id", "Produto.Nome");
            return View();
        }

        // POST: LancamentosProducao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ListaTecnicaId,Quantidade")] LancamentoProducao lancamentoProducao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lancamentoProducao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ListaTecnicaId"] = new SelectList(
            _context.ListasTecnicas
            .Include(static x => x.Produto)
            .GroupBy(x => x.ProdutoId)
            .Select(x => x.First())
            .ToList(), "Id", "Produto.Nome");
            return View(lancamentoProducao);
        }

        // GET: LancamentosProducao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lancamentoProducao = await _context.LancamentoProducao.FindAsync(id);
            if (lancamentoProducao == null)
            {
                return NotFound();
            }
            ViewData["ListaTecnicaId"] = new SelectList(
            _context.ListasTecnicas
            .Include(static x => x.Produto)
            .GroupBy(x => x.ProdutoId)
            .Select(x => x.First())
            .ToList(), "Id", "Produto.Nome");
            return View(lancamentoProducao);
        }

        // POST: LancamentosProducao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ListaTecnicaId,Quantidade")] LancamentoProducao lancamentoProducao)
        {
            if (id != lancamentoProducao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lancamentoProducao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LancamentoProducaoExists(lancamentoProducao.Id))
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
            ViewData["ListaTecnicaId"] = new SelectList(
             _context.ListasTecnicas
             .Include(static x => x.Produto)
             .GroupBy(x => x.ProdutoId)
             .Select(x => x.First())
             .ToList(), "Id", "Produto.Nome");
            return View(lancamentoProducao);
        }

        // GET: LancamentosProducao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lancamentoProducao = await _context.LancamentoProducao
                .Include(l => l.ListaTecnica)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lancamentoProducao == null)
            {
                return NotFound();
            }

            return View(lancamentoProducao);
        }

        // POST: LancamentosProducao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lancamentoProducao = await _context.LancamentoProducao.FindAsync(id);
            if (lancamentoProducao != null)
            {
                _context.LancamentoProducao.Remove(lancamentoProducao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LancamentoProducaoExists(int id)
        {
            return _context.LancamentoProducao.Any(e => e.Id == id);
        }
    }
}
