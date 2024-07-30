using System;

namespace Ferreteria_MAX.Controlador
{
    public class ReportsController
    {
        public void ReporteVentas(List<Venta> ventas, string periodo)
        {
            Console.WriteLine($"Generando reporte de ventas para el período: {periodo}");
           
        }

        public void ReporteInventario(List<Product> products)
        {
            Console.WriteLine("Generando reporte de inventario:");
            
        }

        public void GenerarReporteClientes(List<Client> clients)
        {
            Console.WriteLine("Generando reporte de mejores vendedores y clientes:");
          
        }

        public void ExportaraCSV(string fileName)
        {
            Console.WriteLine($"Exportando reporte a {fileName}.csv");
            
        }
    }
}
