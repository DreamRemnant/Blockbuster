using System.ComponentModel.DataAnnotations;

namespace Blockbuster.API.Models.Entities
{
    public class Pelicula
    {
        [Key] 
        [Required]         
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public List<Genero>? Generos { get; set; }
    }
}
