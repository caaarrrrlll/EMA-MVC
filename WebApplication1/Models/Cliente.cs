using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace WebApplication1.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreCompleto { get; set; }
        [Required]
        [StringLength(50)]
        public string ApellidoCompleto { get; set; }
        [Required]
        [EmailAddress]
        public string Correo { get; set; }
        [Required]
        [Phone]
        public string Telefono { get; set; }
        [StringLength(200)]
        public string Direccion { get; set; }
        [Required]
        public string MetodoPago { get; set; }

    }
}
