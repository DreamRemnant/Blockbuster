using Blockbuster.API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Blockbuster.API.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
