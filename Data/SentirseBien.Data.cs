using Microsoft.EntityFrameworkCore; // Necesario para utilizar DbContext
using SentirseBienWebApp.Models; // Namespace donde tienes tus modelos de datos

namespace MySpaApp.Data
{
    public class MySpaDbContext : DbContext
    {
        // Constructor que acepta opciones de configuración
        public MySpaDbContext(DbContextOptions<MySpaDbContext> options)
            : base(options)
        {

        }
        // Propiedades DbSet para tus entidades
        public DbSet<ContactMessage> ContactMessages { get; set; }

        // Puedes añadir más DbSet para otras entidades que quieras manejar
    }
}
