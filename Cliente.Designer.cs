namespace Ventas
{
    partial class pantallaCliente
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
            txtNit = new TextBox();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtCliente = new TextBox();
            label2 = new Label();
            dgvClientes = new DataGridView();
            idCliente = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Nit = new DataGridViewTextBoxColumn();
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.NavajoWhite;
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(26, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(951, 75);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario Clientes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(317, 23);
            label1.Name = "label1";
            label1.Size = new Size(120, 38);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNit);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtTelefono);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtCorreo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtCliente);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(22, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 397);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle Clientes";
            // 
            // txtNit
            // 
            txtNit.Location = new Point(30, 273);
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(125, 27);
            txtNit.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 250);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 12;
            label6.Text = "Nit";
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Location = new Point(106, 362);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 362);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(106, 329);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 327);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(27, 220);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 197);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 6;
            label5.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(27, 167);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 144);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 4;
            label4.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(27, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 91);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre Completo";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(27, 61);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(125, 27);
            txtCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 38);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "idCliente";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { idCliente, NombreCompleto, Correo, Telefono, Nit });
            dgvClientes.Location = new Point(300, 100);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(677, 336);
            dgvClientes.TabIndex = 3;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // idCliente
            // 
            idCliente.HeaderText = "idCliente";
            idCliente.MinimumWidth = 6;
            idCliente.Name = "idCliente";
            idCliente.Width = 125;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "NombreCompleto";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Width = 125;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // Nit
            // 
            Nit.HeaderText = "Nit";
            Nit.MinimumWidth = 6;
            Nit.Name = "Nit";
            Nit.Width = 125;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(883, 453);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(94, 29);
            btnbuscar.TabIndex = 4;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(752, 455);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(125, 27);
            txtbuscar.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(623, 456);
            label7.Name = "label7";
            label7.Size = new Size(123, 23);
            label7.TabIndex = 6;
            label7.Text = "Buscar Cliente";
            // 
            // pantallaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1032, 534);
            Controls.Add(label7);
            Controls.Add(txtbuscar);
            Controls.Add(btnbuscar);
            Controls.Add(dgvClientes);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "pantallaCliente";
            Text = "Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtCliente;
        private Label label2;
        private Button button3;
        private Button button4;
        private TextBox txtNit;
        private Label label6;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn idCliente;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Nit;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private Label label7;
    }
}