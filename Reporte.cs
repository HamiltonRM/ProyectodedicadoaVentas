using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.Modelos;

namespace Ventas
{
    public partial class Reporte : Form
    {
        private List<Compra> mCompras;
        private Compra CompraNueva;

        private CompraConsulta mCompraConsultas;

        public Reporte()
        {
            InitializeComponent();
            mCompras = new List<Compra>();
            mCompraConsultas = new CompraConsulta();
            CompraNueva = new Compra();
            cargarCompras();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }
        private void cargarCompras(String filtro = "")
        {
            dgvReporte.Rows.Clear();
            dgvReporte.Refresh();
            mCompras.Clear();
            mCompras = mCompraConsultas.getCompra(filtro);
            for (int i = 0; i < mCompras.Count; i++)
            {
                dgvReporte.RowTemplate.Height = 50;
                dgvReporte.Rows.Add(
                    mCompras[i].CorrelativoCompra,
                    mCompras[i].Fecha,
                    mCompras[i].Cantidad,
                    mCompras[i].Proveedor,
                    mCompras[i].Usuario,
                    mCompras[i].Producto);

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
