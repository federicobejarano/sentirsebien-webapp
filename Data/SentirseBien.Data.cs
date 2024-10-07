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
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Personal> Personales { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<PersonalRol> PersonalRoles { get; set; }
        public DbSet<Administrativo> Administrativos { get; set; }
        public DbSet<Terapeuta> Terapeutas { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de claves foráneas, únicas, y relaciones

            // Relación 1:1 entre Usuario y Cliente/Personal
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Cliente)
                .WithOne(c => c.Usuario)
                .HasForeignKey<Cliente>(c => c.IDUsuario);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Personal)
                .WithOne(p => p.Usuario)
                .HasForeignKey<Personal>(p => p.IDUsuario);

            // Relación N:1 entre Personal y Rol (a través de PersonalRol)
            modelBuilder.Entity<PersonalRol>()
                .HasKey(pr => new { pr.IDPersonal, pr.IDRol }); // Clave compuesta

            modelBuilder.Entity<PersonalRol>()
                .HasOne(pr => pr.Personal)
                .WithMany(p => p.Roles)
                .HasForeignKey(pr => pr.IDPersonal);

            modelBuilder.Entity<PersonalRol>()
                .HasOne(pr => pr.Rol)
                .WithMany(r => r.PersonalRoles)
                .HasForeignKey(pr => pr.IDRol);

            // Relación 1:1 entre Personal y Administrativo/Terapeuta
            modelBuilder.Entity<Administrativo>()
                .HasOne(a => a.Personal)
                .WithOne(p => p.Administrativo)
                .HasForeignKey<Administrativo>(a => a.IDPersonal);

            modelBuilder.Entity<Terapeuta>()
                .HasOne(t => t.Personal)
                .WithOne(p => p.Terapeuta)
                .HasForeignKey<Terapeuta>(t => t.IDPersonal);

            // Relación N:1 entre Terapeuta y Especialidad
            modelBuilder.Entity<Terapeuta>()
                .HasOne(t => t.Especialidad)
                .WithMany(e => e.Terapeutas)
                .HasForeignKey(t => t.IDEspecialidad);

            // Más configuraciones, si es necesario
        }


    }
}
