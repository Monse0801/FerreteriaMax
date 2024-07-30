using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria_MAX.Controlador;


namespace Ferreteria
{
    public partial class VentasForm : Form
    {
        private ControladorVenta salesController;

        public VentasForm()
        {
            InitializeComponent();
            salesController = new ControladorVenta();
        }

        private void buttonProcessSale_Click(object sender, EventArgs e)
        {
            var sale = new Venta
            {
                SaleID = int.Parse(textBoxSaleID.Text),
                Date = DateTime.Now,
                PaymentMethod = comboBoxPaymentMethod.SelectedItem.ToString(),
                Products = new List<Producto>
                {
                    // Aquí agregar productos a la venta
                }
            };
            salesController.ProcessSale(sale);
        }

        private void buttonGenerateInvoice_Click(object sender, EventArgs e)
        {
            var saleId = int.Parse(textBoxSaleID.Text);
            var sale = salesController.GetSales().Find(s => s.SaleID == saleId);
            if (sale != null)
            {
                salesController.GenerateInvoice(sale);
            }
        }
    }
}
