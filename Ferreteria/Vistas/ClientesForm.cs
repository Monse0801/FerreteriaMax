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
    public partial class ClientesForm : Form
    {
        private ControladorCliente customerController;

        public ClientesForm()
        {
            InitializeComponent();
            customerController = new ControladorCliente();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var customers = customerController.GetCustomers();
            dataGridViewCustomers.DataSource = customers;
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            var customer = new Cliente
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Nationality = textBoxNationality.Text,
                IdCard = textBoxIdCard.Text,
                Email = textBoxEmail.Text,
                Phone = textBoxPhone.Text
            };
            customerController.AddCustomer(customer);
            LoadCustomers();
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            var customer = new Cliente
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Nationality = textBoxNationality.Text,
                IdCard = textBoxIdCard.Text,
                Email = textBoxEmail.Text,
                Phone = textBoxPhone.Text
            };
            customerController.EditCustomer(customer);
            LoadCustomers();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            var customerIdCard = textBoxIdCard.Text;
            customerController.DeleteCustomer(customerIdCard);
            LoadCustomers();
        }
    }
}
