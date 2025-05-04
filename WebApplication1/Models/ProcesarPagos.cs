namespace WebApplication1.Models
{
    public class PagoExternoService
    {
        public bool ProcesarPago(Pagos pago)
        {
            // Aquí puedes integrar con un proveedor de pagos externo
            if (string.IsNullOrEmpty(pago.EntidadExterna) || pago.Monto <= 0)
            {
                throw new ArgumentException("Datos de pago inválidos.");
            }

            // Simulación de procesamiento de pago
            Console.WriteLine($"Procesando pago de {pago.Monto} a {pago.EntidadExterna} usando {pago.MetodoPago}.");
            return true; // Retorna true si el pago fue exitoso
        }
    }

}
