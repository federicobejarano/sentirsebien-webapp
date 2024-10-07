using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SentirseBienWebApp.Models;
using MySpaApp.Data; // El namespace donde tengas tu DbContext

namespace Sentirse_Bien_WebApp.Pages.Login_Register
{
    public class Login_RegisterModel : PageModel
    {
     
    private readonly MySpaDbContext _context;

        // Constructor para inyectar el contexto de base de datos
        public Login_RegisterModel(MySpaDbContext context)
        {
            _context = context;
        }

        // Atributo que enlazará con los datos del formulario
        [BindProperty]
        public Usuario Usuario { get; set; }

        public string GreetingMessage { get; set; } // Propiedad para el saludo

        public IActionResult OnGet()
        {
            Usuario = new Usuario(); // Asegúrate de inicializar

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                return Page();
            }

            // Agregar el nuevo usuario a la base de datos
            _context.Usuarios.Add(Usuario);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                // Captura errores específicos de actualización en la base de datos
                Console.WriteLine($"DbUpdateException: {dbEx.Message}");
                foreach (var entry in dbEx.Entries)
                {
                    Console.WriteLine($"Entry: {entry.Entity}");
                }
                return Page();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
                return Page();
            }

            // Redireccionar o mostrar un mensaje de éxito
            return RedirectToPage("/Index");
        }
    }
}
