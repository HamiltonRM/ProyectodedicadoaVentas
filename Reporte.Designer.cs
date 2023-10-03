namespace Ventas
{
    partial class Reporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            dgvReporte = new DataGridView();
            CorrelativoCompra = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.BurlyWood;
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario Reportes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(256, 23);
            label1.Name = "label1";
            label1.Size = new Size(244, 38);
            label1.TabIndex = 0;
            label1.Text = "Reporte Compras";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(12, 420);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Columns.AddRange(new DataGridViewColumn[] { CorrelativoCompra, Fecha, Cantidad, Proveedor, Usuario, Producto });
            dgvReporte.Location = new Point(23, 97);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.RowTemplate.Height = 29;
            dgvReporte.Size = new Size(803, 301);
            dgvReporte.TabIndex = 3;
            dgvReporte.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CorrelativoCompra
            // 
            CorrelativoCompra.HeaderText = "CorrelativoCompra";
            CorrelativoCompra.MinimumWidth = 6;
            CorrelativoCompra.Name = "CorrelativoCompra";
            CorrelativoCompra.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.MinimumWidth = 6;
            Proveedor.Name = "Proveedor";
            Proveedor.Width = 125;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.Width = 125;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 125;
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(849, 457);
            Controls.Add(dgvReporte);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Reporte";
            Text = "Reporte";
            Load += Reporte_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
        private DataGridView dgvReporte;
        private DataGridViewTextBoxColumn CorrelativoCompra;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Producto;
    }
}