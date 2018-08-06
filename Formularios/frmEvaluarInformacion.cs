using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO_Ventas;

namespace Ventas
{
    public partial class frmEvaluarInformacion : Form
    {
        public frmEvaluarInformacion()
        {
            InitializeComponent();
        }

        private void frmEvaluarInformacion_Load(object sender, EventArgs e)
        {
            txtAnio.Text = DateTime.Now.Year.ToString();
            txtVersion.Text = "V1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EstimadoVentas ev;
            if (txtAnio.Text != "" && txtVersion.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                ev = new EstimadoVentas();
                ev.ObtenerPorcentaje(Convert.ToInt32(txtAnio.Text), txtVersion.Text);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnObtenerInformacion_Click(object sender, EventArgs e)
        {
            DataTable dt;
            EstimadoVentas ev;
            if (txtAnio.Text != "" && txtVersion.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                ev = new EstimadoVentas();
                dt = ev.ListarPorcentajesCrecimiento(Convert.ToInt32(txtAnio.Text), txtVersion.Text);
                dgvPorcentaje.DataSource = dt;
                dgvPorcentaje.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                Cursor.Current = Cursors.Default;
            }
        }

        private void btnEvaluarTiendasNvas_Click(object sender, EventArgs e)
        {
            EstimadoVentas ev;
            if (txtAnio.Text != "" && txtVersion.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                ev = new EstimadoVentas();
                ev.EvaluarTiendasNuevas(Convert.ToInt32(txtAnio.Text), txtVersion.Text);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnAplicarPorcSellInTiendas_Click(object sender, EventArgs e)
        {
            EstimadoVentas ev;
            if (txtAnio.Text != "" && txtVersion.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                ev = new EstimadoVentas();
                ev.AplicarPorcentajeSellIn_a_Tiendas(Convert.ToInt32(txtAnio.Text), txtVersion.Text);
                Cursor.Current = Cursors.Default;
            }

        }

        private void btnEvaluarTiendasSinHist_Click(object sender, EventArgs e)
        {
            EstimadoVentas ev;
            if (txtAnio.Text != "" && txtVersion.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                ev = new EstimadoVentas();
                ev.EvaluarTiendasNuevasSinHist(Convert.ToInt32(txtAnio.Text), txtVersion.Text);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnEvaluarProductosNvos_Click(object sender, EventArgs e)
        {
            EstimadoVentas ev;
            if (txtAnio.Text != "" && txtVersion.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                ev = new EstimadoVentas();
                ev.EvaluarArtNuevos(Convert.ToInt32(txtAnio.Text), txtVersion.Text);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnObtenerInfoSellOut_Click(object sender, EventArgs e)
        {
            DataTable dt;
            EstimadoVentas ev;
            if (txtAnio.Text != "" && txtVersion.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                ev = new EstimadoVentas();
                dt = ev.ListarPorcentajesCrecimientoSellOut(Convert.ToInt32(txtAnio.Text), txtVersion.Text);
                dgvPorcTienda.DataSource = dt;
                dgvPorcTienda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                Cursor.Current = Cursors.Default;
            }
        }

    }
}
