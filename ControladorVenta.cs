using System;

public class Class1
{
    public class SalesController
    {
        private List<Sale> sales = new List<Sale>();

        public void ProcessSale(Sale sale)
        {
            sales.Add(sale);
            Console.WriteLine("Venta procesada exitosamente.");
        }

        public void GenerateInvoice(Sale sale)
        {
            Console.WriteLine($"Factura para la venta {sale.SaleID}");
            // Lógica para generar factura
        }

        public List<Sale> GetSales()
        {
            return sales;
        }
    }
}
