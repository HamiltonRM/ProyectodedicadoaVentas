namespace Ventas
{
    partial class pantallaMantenedor
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
            Button button4;
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtCodigo = new TextBox();
            groupBox3 = new GroupBox();
            btnbuscar = new Button();
            txtBuscar = new TextBox();
            label5 = new Label();
            dgvMantenedor = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenedor).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(10, 343);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 10;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 192, 192);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 58);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mantenedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 26);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 0;
            label2.Text = "Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(txtDescripcion);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtCodigo);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(2, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(277, 372);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles-Productos";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(177, 337);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(177, 297);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(177, 262);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(46, 199);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 164);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 4;
            label4.Text = "Descripcion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(46, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 95);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(46, 55);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnbuscar);
            groupBox3.Controls.Add(txtBuscar);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(314, 87);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(529, 40);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar Producto";
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(376, 11);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(109, 29);
            btnbuscar.TabIndex = 2;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(208, 8);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(152, 27);
            txtBuscar.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 11);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 0;
            label5.Text = "Codigo";
            // 
            // dgvMantenedor
            // 
            dgvMantenedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenedor.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Descripcion });
            dgvMantenedor.Location = new Point(344, 161);
            dgvMantenedor.Name = "dgvMantenedor";
            dgvMantenedor.RowHeadersWidth = 51;
            dgvMantenedor.RowTemplate.Height = 29;
            dgvMantenedor.Size = new Size(429, 257);
            dgvMantenedor.TabIndex = 4;
            dgvMantenedor.CellContentClick += dgvMantenedor_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 125;
            // 
            // pantallaMantenedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(855, 444);
            Controls.Add(dgvMantenedor);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "pantallaMantenedor";
            Text = "Mantenedor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtDescripcion;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtCodigo;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private GroupBox groupBox3;
        private TextBox txtBuscar;
        private Label label5;
        private DataGridView dgvMantenedor;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private Button btnbuscar;
    }
}