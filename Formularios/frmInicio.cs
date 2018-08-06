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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            cboDB.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Seguridad.AutExitosa = false;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool desarrollo = false;
            if (cboDB.SelectedIndex == 1)
                desarrollo = true;

            if (txtUsuario.Text.Trim() != "" && txtPwd.Text.Trim() != "")
            {
                Usuario usr = new Usuario(desarrollo);
                usr = usr.Listar(txtUsuario.Text, desarrollo);
                if (usr.password != txtPwd.Text && usr.estatus != "A")
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Seguridad.AutExitosa = false;
                }
                else
                {
                    Seguridad.AutExitosa = true;
                    Seguridad.usuario = usr.usuario;
                    Seguridad.nombre = usr.nombre;
                    Seguridad.ape_pat = usr.ape_pat;
                    Seguridad.ape_mat = usr.ape_mat;
                    Seguridad.desarrollo = desarrollo;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Falta especificar usuario y contraseña", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Seguridad.AutExitosa = false;
            }
        }
    }
}
