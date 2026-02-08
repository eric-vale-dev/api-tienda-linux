using Microsoft.EntityFrameworkCore;
using TienditaAPI.Models;

namespace TienditaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Esta propiedad es la que se convertiria en la tabla de productos en la base de datos
        public DbSet<Producto> Productos {get; set;}
    }
}