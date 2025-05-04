using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Empleado

    {
        [Key]
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string ApellidoCompleto { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime  datebirth { get; set; }
        public string Direccion { get; set; }
        public string PuestoID { get; set; }


    }
}
