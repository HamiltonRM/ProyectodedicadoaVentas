namespace Ventas
{
    partial class pantallaVenta
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
            groupBox2 = new GroupBox();
            txtCantidad = new TextBox();
            txtProducto = new TextBox();
            txtCliente = new TextBox();
            txtCorrelativo = new TextBox();
            label7 = new Label();
            txtVendedor = new TextBox();
            label6 = new Label();
            txtMonto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvVentas = new DataGridView();
            CorrelativoVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Usuario_IdUsuario = new DataGridViewTextBoxColumn();
            Producto_Codigo = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.OutlineButton;
            groupBox1.BackColor = Color.DarkSalmon;
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(22, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1034, 74);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario Ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(327, 23);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 0;
            label1.Text = "Ventas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(txtProducto);
            groupBox2.Controls.Add(txtCliente);
            groupBox2.Controls.Add(txtCorrelativo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtVendedor);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtMonto);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 401);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle Ventas";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(10, 205);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 14;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(15, 152);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 27);
            txtProducto.TabIndex = 13;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(19, 101);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(125, 27);
            txtCliente.TabIndex = 12;
            // 
            // txtCorrelativo
            // 
            txtCorrelativo.Location = new Point(15, 46);
            txtCorrelativo.Name = "txtCorrelativo";
            txtCorrelativo.Size = new Size(125, 27);
            txtCorrelativo.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 182);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 10;
            label7.Text = "Cantidad";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(6, 311);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(125, 27);
            txtVendedor.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 288);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 8;
            label6.Text = "Vendedor";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(6, 258);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 7;
            txtMonto.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 235);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 6;
            label5.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 76);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 23);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 0;
            label2.Text = "Correlativo Venta";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(601, 437);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(246, 438);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(390, 438);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(501, 437);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { CorrelativoVenta, Cantidad, Monto, Usuario_IdUsuario, Producto_Codigo, Cliente });
            dgvVentas.Location = new Point(237, 96);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 29;
            dgvVentas.Size = new Size(801, 323);
            dgvVentas.TabIndex = 14;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            // 
            // CorrelativoVenta
            // 
            CorrelativoVenta.HeaderText = "CorrelativoVenta";
            CorrelativoVenta.MinimumWidth = 6;
            CorrelativoVenta.Name = "CorrelativoVenta";
            CorrelativoVenta.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.Width = 125;
            // 
            // Usuario_IdUsuario
            // 
            Usuario_IdUsuario.HeaderText = "Usuario_IdUsuario";
            Usuario_IdUsuario.MinimumWidth = 6;
            Usuario_IdUsuario.Name = "Usuario_IdUsuario";
            Usuario_IdUsuario.Width = 125;
            // 
            // Producto_Codigo
            // 
            Producto_Codigo.HeaderText = "Producto_Codigo";
            Producto_Codigo.MinimumWidth = 6;
            Producto_Codigo.Name = "Producto_Codigo";
            Producto_Codigo.Width = 125;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(948, 438);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(67, 32);
            btnbuscar.TabIndex = 15;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(817, 439);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(125, 27);
            txtbuscar.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(749, 440);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 17;
            label8.Text = "Buscar";
            // 
            // pantallaVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1076, 509);
            Controls.Add(label8);
            Controls.Add(txtbuscar);
            Controls.Add(btnbuscar);
            Controls.Add(dgvVentas);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "pantallaVenta";
            Text = "Venta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtMonto;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private TextBox txtVendedor;
        private Label label6;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button1;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox textBox6;
        private Label label7;
        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn CorrelativoVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Usuario_IdUsuario;
        private DataGridViewTextBoxColumn Producto_Codigo;
        private DataGridViewTextBoxColumn Cliente;
        private TextBox txtCantidad;
        private TextBox txtProducto;
        private TextBox txtCliente;
        private TextBox txtCorrelativo;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private Label label8;
    }
}