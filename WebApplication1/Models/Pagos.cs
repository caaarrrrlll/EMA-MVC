using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Pagos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public int VentaId { get; set; }

        [Required]
        [StringLength(50)]
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }

        // Nueva propiedad para identificar la entidad externa
        [Required]
        [StringLength(100)]
        public string EntidadExterna { get; set; }

        // Nueva propiedad para el método de pago
        [Required]
        [StringLength(50)]
        public string MetodoPago { get; set; }

        // Nueva propiedad para detalles de la cuenta bancaria
        [StringLength(100)]
        public string DetallesCuenta { get; set; }

        // Navigation properties
        public virtual Venta Venta { get; set; }
        public virtual OrdenTrabajo OrdenTrabajo { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Equipo Equipo { get; set; }
    }

}
