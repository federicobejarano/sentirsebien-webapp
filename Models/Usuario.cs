namespace SentirseBienWebApp.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool EsCliente { get; set; }

        // Relación 1:1 con Cliente o Personal (dependiendo de EsCliente)
        public Cliente Cliente { get; set; }
        public Personal Personal { get; set; }
    }
}
