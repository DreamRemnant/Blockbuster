
using Blockbuster.API.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Blockbuster.API.Controllers
{
    public class PeliculasController : MyController
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hola desde API");
        }

        [HttpGet("peliculas2")]
        public ActionResult<string> Get2()
        {
            return Ok("Hola desde API de nuevo");
        }

        [HttpGet("{nombre}")]
        public ActionResult<string> Get(string nombre)
        {
            return Ok($"Hola desde API {nombre}");
        }

        [HttpGet("{nombre}/{edad:int}")]
        public ActionResult<string> Get(string nombre, int edad)
        {
            return Ok($"Hola desde API {nombre} {edad}");
        }
        
        [HttpPost]
        public ActionResult<string> Post([FromBody] LoginDto login)
        {
            if(login.Usuario == "Fulanito" && login.Password == "nulo")
            {
                return Ok();
            }

            return Unauthorized();
        }
    }
}
