namespace Ferreteria
{
    partial class VentasForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelSaleID;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.TextBox textBoxSaleID;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Button buttonProcessSale;
        private System.Windows.Forms.Button buttonGenerateInvoice;

        private void InitializeComponent()
        {
            this.labelSaleID = new System.Windows.Forms.Label();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.textBoxSaleID = new System.Windows.Forms.TextBox();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.buttonProcessSale = new System.Windows.Forms.Button();
            this.buttonGenerateInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSaleID
            // 
            this.labelSaleID.AutoSize = true;
            this.labelSaleID.Location = new System.Drawing.Point(12, 15);
            this.labelSaleID.Name = "labelSaleID";
            this.labelSaleID.Size = new System.Drawing.Size(56, 13);
            this.labelSaleID.TabIndex = 0;
            this.labelSaleID.Text = "ID de venta";
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Location = new System.Drawing.Point(12, 41);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(87, 13);
            this.labelPaymentMethod.TabIndex = 1;
            this.labelPaymentMethod.Text = "Método de pago";
            // 
            // textBoxSaleID
            // 
            this.textBoxSaleID.Location = new System.Drawing.Point(105, 12);
            this.textBoxSaleID.Name = "textBoxSaleID";
            this.textBoxSaleID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSaleID.TabIndex = 2;
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Transferencia bancaria"});
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(105, 38);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPaymentMethod.TabIndex = 3;
            // 
            // buttonProcessSale
            // 
            this.buttonProcessSale.Location = new System.Drawing.Point(12, 65);
            this.buttonProcessSale.Name = "buttonProcessSale";
            this.buttonProcessSale.Size = new System.Drawing.Size(75, 23);
            this.buttonProcessSale.TabIndex = 4;
            this.buttonProcessSale.Text = "Procesar";
            this.buttonProcessSale.UseVisualStyleBackColor = true;
            this.buttonProcessSale.Click += new System.EventHandler(this.buttonProcessSale_Click);
            // 
            // buttonGenerateInvoice
            // 
            this.buttonGenerateInvoice.Location = new System.Drawing.Point(93, 65);
            this.buttonGenerateInvoice.Name = "buttonGenerateInvoice";
            this.buttonGenerateInvoice.Size = new System.Drawing.Size(112, 23);
            this.buttonGenerateInvoice.TabIndex = 5;
            this.buttonGenerateInvoice.Text = "Generar Factura";
            this.buttonGenerateInvoice.UseVisualStyleBackColor = true;
            this.buttonGenerateInvoice.Click += new System.EventHandler(this.buttonGenerateInvoice_Click);
            // 
            // VentasForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonGenerateInvoice);
            this.Controls.Add(this.buttonProcessSale);
            this.Controls.Add(this.comboBoxPaymentMethod);
            this.Controls.Add(this.textBoxSaleID);
            this.Controls.Add(this.labelPaymentMethod);
            this.Controls.Add(this.labelSaleID);
            this.Name = "VentasForm";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
}