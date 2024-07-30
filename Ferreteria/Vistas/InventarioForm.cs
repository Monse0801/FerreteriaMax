using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Ferreteria
{
    public partial class InventarioForm : Form
    {
        private ControladorInventario inventoryController;

        public InventarioForm()
        {
            InitializeComponent();
            inventoryController = new ControladorInventario();
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = inventoryController.GetProducts();
            dataGridViewProducts.DataSource = products;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var product = new Producto
            {
                Name = textBoxName.Text,
                Quantity = int.Parse(textBoxQuantity.Text),
                Price = decimal.Parse(textBoxPrice.Text)
            };
            inventoryController.AddProduct(product);
            LoadProducts();
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            var product = new Producto
            {
                Name = textBoxName.Text,
                Quantity = int.Parse(textBoxQuantity.Text),
                Price = decimal.Parse(textBoxPrice.Text)
            };
            inventoryController.EditProduct(product);
            LoadProducts();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            var productName = textBoxName.Text;
            inventoryController.DeleteProduct(productName);
            LoadProducts();
        }
    }
}
