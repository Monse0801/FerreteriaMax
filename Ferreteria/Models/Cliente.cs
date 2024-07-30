using System;

namespace Ferreteria_MAX.Models
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public string ID { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public List<Sale> HistorialCompras { get; set; }
    }
}
