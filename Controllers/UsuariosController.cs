using Context;
using GestaoRecursos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace GestaoRecursos.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsuariosController : Controller
    {
        private readonly GestaoContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<UsuariosController> _logger;

        public UsuariosController(GestaoContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ILogger<UsuariosController> logger)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var gestaoContext = _context.Usuarios.Include(u => u.PerfilUsuario);
            return View(await gestaoContext.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.PerfilUsuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["PerfilUsuarioId"] = usuario.PerfilUsuario?.NomePerfil ?? "Sem Perfil";
            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            ViewData["PerfilUsuarioId"] = new SelectList(_context.PerfilUsuarios, "Id", "NomePerfil");
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Id,Email,Senha,Ativo,DataCriacao,DataAlteracao,PerfilUsuarioId,IdentityUserId")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.DataCriacao = DateTime.Now;
                usuario.DataAlteracao = DateTime.Now;
                usuario.Ativo = true;


                var user = new IdentityUser { UserName = usuario.Email, Email = usuario.Email };
                var result = await _userManager.CreateAsync(user, usuario.Senha);
                if (result.Succeeded)
                {
                    usuario.IdentityUserId = user.Id;

                    var perfilUsuario = await _context.PerfilUsuarios.FindAsync(usuario.PerfilUsuarioId);
                    if (perfilUsuario != null)
                    {
                        var role = await _roleManager.FindByIdAsync(perfilUsuario.RoleId);
                        if (role != null)
                        {
                            await _userManager.AddToRoleAsync(user, role.Name);
                        }
                    }

                    usuario.Senha = string.Empty;
                    _context.Add(usuario);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    ViewData["PerfilUsuarioId"] = new SelectList(_context.PerfilUsuarios, "Id", "NomePerfil", usuario.PerfilUsuarioId);
                    return View(usuario);
                }
            }
            ViewData["PerfilUsuarioId"] = new SelectList(_context.PerfilUsuarios, "Id", "NomePerfil", usuario.PerfilUsuarioId);
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["PerfilUsuarioId"] = new SelectList(_context.PerfilUsuarios, "Id", "NomePerfil");
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nome,Id,Email,Ativo,DataCriacao,DataAlteracao,PerfilUsuarioId")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            ModelState.Remove("Senha");
            ModelState.Remove("IdentityUserId");

            if (ModelState.IsValid)
            {
                try
                {
                    var existingUser = await _context.Usuarios.FindAsync(id);
                    if (existingUser == null)
                    {
                        return NotFound();
                    }

                    existingUser.Nome = usuario.Nome;
                    existingUser.Email = usuario.Email;
                    existingUser.Ativo = usuario.Ativo;
                    existingUser.PerfilUsuarioId = usuario.PerfilUsuarioId;
                    existingUser.DataAlteracao = DateTime.Now;

                    var user = await _userManager.FindByIdAsync(existingUser.IdentityUserId);
                    if (user == null)
                    {
                        return NotFound();
                    }

                    user.UserName = usuario.Email;
                    user.Email = usuario.Email;

                    var identityResult = await _userManager.UpdateAsync(user);
                    if (!identityResult.Succeeded)
                    {
                        foreach (var error in identityResult.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                        return View(usuario);
                    }

                    //atualizar roles
                    var currentRole = await _userManager.GetRolesAsync(user);
                    var perfilUsuario = await _context.PerfilUsuarios.FindAsync(usuario.PerfilUsuarioId);
                    if (perfilUsuario!= null)
                    {
                        var newRole = await _roleManager.FindByIdAsync(perfilUsuario.RoleId);
                        if (newRole != null)
                        {
                            await _userManager.RemoveFromRolesAsync(user, currentRole);
                            await _userManager.AddToRoleAsync(user, newRole.Name);
                        }
                    }


                    _context.Update(existingUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
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
            ViewData["PerfilUsuarioId"] = new SelectList(_context.PerfilUsuarios, "Id", "NomePerfil", usuario.PerfilUsuarioId);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.PerfilUsuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            ViewData["PerfilUsuarioId"] = usuario.PerfilUsuario?.NomePerfil ?? "Sem perfil";
            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                var user = await _userManager.FindByIdAsync(usuario.IdentityUserId);
                if (user != null)
                {
                    var usuariosDoPerfil = _context.Usuarios.Where(u => u.PerfilUsuarioId == id);
                    foreach(var item in usuariosDoPerfil)
                    {
                        item.PerfilUsuarioId = null;
                    }

                    var identityResult = await _userManager.DeleteAsync(user);
                    if (!identityResult.Succeeded)
                    {
                        foreach (var error in identityResult.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                        return View(usuario);
                    }
                }
                _context.Usuarios.Remove(usuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
