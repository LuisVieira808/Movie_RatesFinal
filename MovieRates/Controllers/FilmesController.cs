using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieRates.Data;
using MovieRates.Models;


namespace MovieRates.Controllers
{

    public class FilmesController : Controller
    {
        /// <summary>
        /// Este atributo representa a base de dados do projeto
        /// </summary>
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _caminho;
        /// <summary>
        /// objeto para gerir os dados dos Utilizadores registados
        /// </summary>
        private readonly UserManager<IdentityUser> _userManager;


        public FilmesController(ApplicationDbContext context, IWebHostEnvironment caminho, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _caminho = caminho;
            _userManager = userManager;
        }

        // GET: Filmes
        public async Task<IActionResult> Index()
        {


            return View(await _context.Filmes.ToListAsync());
        }

        // GET: Filmes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filme = await _context.Filmes
                .Where(f => f.IdFilmes == id)
                .Include(f => f.ListaDeFilmes)
                .ThenInclude(r => r.Utilizador)
                .OrderByDescending(f => f.Data)
                .FirstOrDefaultAsync();
            if (filme == null)
            {
                return NotFound();
            }

            return View(filme);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateComentario(int IdFilmes, string comentario, int rating) {

            var utilizador = _context.Utilizadores.Where(u => u.UserNameId == _userManager.GetUserId(User)).FirstOrDefault();


            var comment = new Reviews {
                FilmesFK = IdFilmes,
                Comentario = comentario.Replace("\r\n", "<br />"),
                Pontuacao = rating,
                Data = DateTime.Now,
                Utilizador = utilizador
            };

                _context.Reviews.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details),new { id = IdFilmes});
        }


        // GET: Filmes/Create
        public IActionResult Create()
        {
            return View();
        }
        
        // POST: Filmes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFilmes,Titulo,Data,Capa,Realizador,Elenco,Descricao,Categoria,Link,Duracao,Pontuacao")] Filmes filmes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filmes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(filmes);
        }

        // GET: Filmes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmes = await _context.Filmes.FindAsync(id);
            if (filmes == null)
            {
                return NotFound();
            }
            return View(filmes);
        }

        // POST: Filmes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFilmes,Titulo,Data,Capa,Realizador,Elenco,Descricao,Categoria,Link,Duracao,Pontuacao")] Filmes filmes)
        {
            if (id != filmes.IdFilmes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filmes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmesExists(filmes.IdFilmes))
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
            return View(filmes);
        }

        // GET: Filmes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmes = await _context.Filmes
                .FirstOrDefaultAsync(m => m.IdFilmes == id);
            if (filmes == null)
            {
                return NotFound();
            }

            return View(filmes);
        }

        // POST: Filmes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var filmes = await _context.Filmes.FindAsync(id);
            _context.Filmes.Remove(filmes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmesExists(int id)
        {
            return _context.Filmes.Any(e => e.IdFilmes == id);
        }
    }
}
