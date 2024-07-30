namespace Ferreteria
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonInventario;
        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonReportes;

        private void InitializeComponent()
        {
            this.buttonInventario = new System.Windows.Forms.Button();
            this.buttonVentas = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();

            // 
            // buttonInventario
            // 
            this.buttonInventario.Location = new System.Drawing.Point(12, 12);
            this.buttonInventario.Name = "buttonInventario";
            this.buttonInventario.Size = new System.Drawing.Size(75, 23);
            this.buttonInventario.TabIndex = 0;
            this.buttonInventario.Text = "Inventario";
            this.buttonInventario.UseVisualStyleBackColor = true;
            this.buttonInventario.Click += new System.EventHandler(this.buttonInventario_Click);

            // 
            // buttonVentas
            // 
            this.buttonVentas.Location = new System.Drawing.Point(12, 41);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(75, 23);
            this.buttonVentas.TabIndex = 1;
            this.buttonVentas.Text = "Ventas";
            this.buttonVentas.UseVisualStyleBackColor = true;
            this.buttonVentas.Click += new System.EventHandler(this.buttonVentas_Click);

            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(12, 70);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(75, 23);
            this.buttonClientes.TabIndex = 2;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);

            // 
            // buttonReportes
            // 
            this.buttonReportes.Location = new System.Drawing.Point(12, 99);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(75, 23);
            this.buttonReportes.TabIndex = 3;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonInventario);
            this.Controls.Add(this.buttonVentas);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonReportes);
            this.Name = "MainForm";
            this.Text = "Sistema de Ventas";
        }
    }

}

