using Microsoft.EntityFrameworkCore;
using MySpaApp.Data; // Aquí va el namespace de tu DbContext

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Configura la conexión a la base de datos (usando la cadena de conexión obtenida de Azure)
builder.Services.AddDbContext<MySpaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MySpaDatabase")));

// Agrega Razor Pages al contenedor de servicios
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

