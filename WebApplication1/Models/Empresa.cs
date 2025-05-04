using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
       

    }
}
