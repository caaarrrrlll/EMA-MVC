using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Empleado

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
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        public string Telefono { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime  datebirth { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(200)]
        public string PuestoID { get; set; }

        //AQUI IRIA APARTADO ADMINISTRADOR
    }
}
