using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace WebApplication1.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string ApellidoCompleto { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        [ForeignKey("Direccion")]
        public string Direccion { get; set; }
        public string MetodoPago { get; set; }
        
    }
}
