namespace Ventas
{
    partial class pantallaCompra
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
            txtProveedor = new TextBox();
            label7 = new Label();
            txtUsuario = new TextBox();
            label6 = new Label();
            txtCantidad = new TextBox();
            label5 = new Label();
            txtProducto = new TextBox();
            label4 = new Label();
            txtFecha = new TextBox();
            label3 = new Label();
            txtCorrelativo = new TextBox();
            label2 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            button4 = new Button();
            dgvCompras = new DataGridView();
            CorrelativoCompra = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SandyBrown;
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1056, 70);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario Compras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(337, 23);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 0;
            label1.Text = "Compras";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtProveedor);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtUsuario);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtProducto);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtFecha);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtCorrelativo);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 408);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle Compra";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(42, 374);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(156, 27);
            txtProveedor.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 351);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 10;
            label7.Text = "Proveedor";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(42, 310);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(156, 27);
            txtUsuario.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 287);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 8;
            label6.Text = "Usuario";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(42, 248);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(156, 27);
            txtCantidad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 225);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 6;
            label5.Text = "Cantidad";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(42, 185);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(156, 27);
            txtProducto.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 162);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Producto";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(42, 123);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(125, 27);
            txtFecha.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 100);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha";
            // 
            // txtCorrelativo
            // 
            txtCorrelativo.Location = new Point(42, 59);
            txtCorrelativo.Name = "txtCorrelativo";
            txtCorrelativo.Size = new Size(156, 27);
            txtCorrelativo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 36);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 0;
            label2.Text = "Correlativo Compra";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(287, 413);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(402, 413);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Location = new Point(502, 413);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Columns.AddRange(new DataGridViewColumn[] { CorrelativoCompra, Fecha, Cantidad, Proveedor, Usuario, Producto });
            dgvCompras.Location = new Point(256, 103);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersWidth = 51;
            dgvCompras.RowTemplate.Height = 29;
            dgvCompras.Size = new Size(812, 294);
            dgvCompras.TabIndex = 7;
            dgvCompras.CellContentClick += dgvCompras_CellContentClick;
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
            // btnbuscar
            // 
            btnbuscar.Location = new Point(974, 413);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(94, 29);
            btnbuscar.TabIndex = 8;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(843, 415);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(125, 27);
            txtbuscar.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(706, 415);
            label8.Name = "label8";
            label8.Size = new Size(131, 23);
            label8.TabIndex = 10;
            label8.Text = "Buscar Compra";
            // 
            // pantallaCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1082, 511);
            Controls.Add(label8);
            Controls.Add(txtbuscar);
            Controls.Add(btnbuscar);
            Controls.Add(dgvCompras);
            Controls.Add(button4);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            Name = "pantallaCompra";
            Text = "Compra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtCorrelativo;
        private TextBox txtUsuario;
        private Label label6;
        private TextBox txtCantidad;
        private Label label5;
        private TextBox txtProducto;
        private Label label4;
        private TextBox txtFecha;
        private Label label3;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button button4;
        private TextBox txtProveedor;
        private Label label7;
        private DataGridView dgvCompras;
        private DataGridViewTextBoxColumn CorrelativoCompra;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Producto;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private Label label8;
    }
}