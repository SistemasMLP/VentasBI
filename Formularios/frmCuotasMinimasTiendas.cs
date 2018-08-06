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
    public partial class frmCuotasMinimasTiendas : Form
    {
        CuotaMinima cm;

        public frmCuotasMinimasTiendas()
        {
            InitializeComponent();
        }

        private void btnCadena_Click(object sender, EventArgs e)
        {
            Cadena cadena = new Cadena();

            frmConsulta frm = new frmConsulta();
            string[] llaves;
            frm.dt = cadena.Listar();
            frm.keysCol = 0;
            frm.ShowDialog();
            llaves = frm.keyValues;

            txtCadena.Text = llaves[0];
            txtCadena_Leave(null, null);
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();

            frmConsulta frm = new frmConsulta();
            string[] llaves;
            frm.dt = articulo.Listar();
            frm.keysCol = 0;
            frm.ShowDialog();
            llaves = frm.keyValues;

            txtArticulo.Text = llaves[0];
            txtArticulo_Leave(null, null);
        }

        private void txtCadena_Leave(object sender, EventArgs e)
        {
            Cadena cad;
            if (txtCadena.Text != "")
            {
                cad = new Cadena();
                cad = cad.Listar(txtCadena.Text);
                if (cad != null)
                {
                    txtDescCadena.Text = cad.Descripcion;

                    ObtenerPiezas();
                }
            }
            else
                txtDescCadena.Text = "";
        }

        private void txtArticulo_Leave(object sender, EventArgs e)
        {
            Articulo art;
            if (txtArticulo.Text != "")
            {
                art = new Articulo();
                art = art.Listar(txtArticulo.Text);
                if (art != null)
                {
                    txtDescArticulo.Text = art.Descripcion;

                    ObtenerPiezas();
                }
            }
            else
                txtDescCadena.Text = "";
        }

        private void ObtenerPiezas()
        {
            if (txtCadena.Text.Trim() != "" && txtArticulo.Text != "")
            {

            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            cm = new CuotaMinima(Seguridad.usuario);
            LlenarDatos();
        }

        private void LlenarDatos()
        {
            txtCadena.Text = cm.cust_num;
            txtCadena_Leave(null, null);
            txtArticulo.Text = cm.item;
            txtArticulo_Leave(null, null);

            txtUsuCreacion.Text = cm.usuario_creacion;
            txtFechaCreacion.Text = cm.fecha_creacion.ToString();
            txtUsuModif.Text = cm.usuario_modifiacion;
            txtFechaModif.Text = cm.fecha_modificacion.ToString();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmConsulta frm = new frmConsulta();
            string[] llaves;
            frm.dt = cm.Listar();
            frm.keysCol = 1;
            frm.ShowDialog();
            llaves = frm.keyValues;

            txtCadena.Text = llaves[0];
            txtCadena_Leave(null, null);
            txtArticulo.Text = llaves[1];
            txtArticulo_Leave(null, null);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            cm.cust_num = txtCadena.Text;
            cm.item = txtArticulo.Text;
            cm.piezas = Convert.ToInt32(txtPiezas.Text);
            cm.Crear(cm);
            cm = cm.Listar(txtCadena.Text, txtArticulo.Text, Seguridad.usuario);
            LlenarDatos();
        }

        private void deleteStripButton1_Click(object sender, EventArgs e)
        {
            cm.cust_num = txtCadena.Text;
            cm.item = txtArticulo.Text;
            cm.Borrar(cm);
            newToolStripButton_Click(null, null);
        }
    }

}
