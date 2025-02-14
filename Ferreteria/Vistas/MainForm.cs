﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            InventarioForm inventarioForm = new InventarioForm();
            inventarioForm.Show();
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            VentasForm ventasForm = new VentasForm();
            ventasForm.Show();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.Show();
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            ReportesForm reportesForm = new ReportesForm();
            reportesForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
