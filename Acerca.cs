using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Acerca : Form
    {
        public Acerca()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Diseñadora ventana = new Diseñadora();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Analista ventana = new Analista();
            ventana.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Datos ventana = new Datos();
            ventana.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Programadora ventana = new Programadora();
            ventana.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sistema ventana = new Sistema();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
