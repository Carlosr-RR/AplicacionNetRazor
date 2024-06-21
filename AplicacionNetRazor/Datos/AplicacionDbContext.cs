using AplicacionNetRazor.Modelo;
using Microsoft.EntityFrameworkCore;

namespace AplicacionNetRazor.Datos
{
    public class AplicacionDbContext : DbContext
    {
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options) : base(options)
        {

        }

        // Poner aca los modelos
        public DbSet<Curso> Curso { get; set; }

    }
}
