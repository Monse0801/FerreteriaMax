using System;

namespace Ferreteria_MAX.Models
{

    public class Venta
    {
        public int VentaID { get; set; }
        public List<Product> Products { get; set; }
        public DateTime Fecha { get; set; }
        public string MetodoPago { get; set; }
    }
}

