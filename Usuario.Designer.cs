namespace Ventas
{
    partial class PantallaUsuarios
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            txtRol = new TextBox();
            btnGuardar = new Button();
            label6 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            btnBuscar = new Button();
            txtbuscar = new TextBox();
            button1 = new Button();
            dgvUsuarios = new DataGridView();
            Folio = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Usuarios = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Puesto = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 33);
            label1.Name = "label1";
            label1.Size = new Size(175, 19);
            label1.TabIndex = 0;
            label1.Text = "Control de Usuarios";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PeachPuff;
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(846, 70);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario-Usuarios";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(txtRol);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtCorreo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(26, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(292, 419);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles Usuarios";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(172, 368);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(176, 330);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(63, 300);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(125, 27);
            txtRol.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(72, 330);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 277);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 8;
            label6.Text = "Rol";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(63, 247);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(207, 27);
            txtPassword.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 224);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 6;
            label5.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(63, 178);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(207, 27);
            txtCorreo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 155);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 4;
            label4.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(63, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 27);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 93);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre Completo";
            // 
            // txtId
            // 
            txtId.Location = new Point(63, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(137, 27);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 23);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 0;
            label2.Text = "No. Documento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 26);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 4;
            label7.Text = "No. Documento";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(txtbuscar);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(324, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(530, 47);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar Usuario";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(436, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(236, 20);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(190, 27);
            txtbuscar.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(-2, 419);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Folio, Nombre, Usuarios, Password, Puesto });
            dgvUsuarios.Location = new Point(324, 135);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 29;
            dgvUsuarios.Size = new Size(524, 348);
            dgvUsuarios.TabIndex = 6;
            dgvUsuarios.CellContentClick += dgvUsuarios_CelContentClick;
            // 
            // Folio
            // 
            Folio.HeaderText = "Folio";
            Folio.MinimumWidth = 6;
            Folio.Name = "Folio";
            Folio.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Usuarios
            // 
            Usuarios.HeaderText = "Usuarios";
            Usuarios.MinimumWidth = 6;
            Usuarios.Name = "Usuarios";
            Usuarios.Width = 125;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 125;
            // 
            // Puesto
            // 
            Puesto.HeaderText = "Puesto";
            Puesto.MinimumWidth = 6;
            Puesto.Name = "Puesto";
            Puesto.Width = 125;
            // 
            // PantallaUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(919, 520);
            Controls.Add(dgvUsuarios);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PantallaUsuarios";
            Text = "Usuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private Label label6;
        private Label label7;
        private GroupBox groupBox3;
        private TextBox txtbuscar;
        private Button button1;
        private DataGridView dgvUsuarios;
        private Button btnGuardar;
        private TextBox txtRol;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn Folio;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Usuarios;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Puesto;
    }
}