namespace Blockbuster.API.Models.Entities
{
    public class Genero
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int PeliculaId { get; set; }
        public Pelicula? Pelicula { get; set; }
    }
}
