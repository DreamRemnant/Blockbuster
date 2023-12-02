
using Blockbuster.API.Models;
using Blockbuster.API.Models.Dtos;
using Blockbuster.API.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blockbuster.API.Controllers
{
    public class PeliculasController : MyController
    {
        private readonly ApplicationDbContext _context;
        public PeliculasController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Pelicula>>> Get()
        {
            return await _context.Peliculas
                .Include(g => g.Generos)
                .ToListAsync();
        }

        [HttpPost]
        public async Task Create(Pelicula pelicula)
        {
            await _context.Peliculas.AddAsync(pelicula);
            await _context.SaveChangesAsync();
        }
    }
}
