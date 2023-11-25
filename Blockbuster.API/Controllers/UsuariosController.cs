using Blockbuster.API.Models;
using Blockbuster.API.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blockbuster.API.Controllers
{
    public class UsuariosController:MyController
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Usuario>> Get()
        {
            return _context.Usuarios.ToList();
        }
    }
}
