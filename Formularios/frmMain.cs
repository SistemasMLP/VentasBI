using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ventas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRol frmRol = new frmRol();
            frmRol.MdiParent = this;
            frmRol.Show();
        }

        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPuesto frmPuesto = new frmPuesto();
            frmPuesto.MdiParent = this;
            frmPuesto.Show();
        }

        private void estructuraComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructura frmEst = new frmEstructura();
            frmEst.MdiParent = this;
            frmEst.Show();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersona frmPers = new frmPersona();
            frmPers.MdiParent = this;
            frmPers.Show();
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRuta frmR = new frmRuta();
            frmR.MdiParent = this;
            frmR.Show();
        }

        private void cargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarInfo frmC = new frmCargarInfo();
            frmC.MdiParent = this;
            frmC.Show();
        }

        private void cálculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculoComision frmCalc = new frmCalculoComision();
            frmCalc.MdiParent = this;
            frmCalc.Show();
        }

        private void cargarVersiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarEstimado frmCEstimado = new frmCargarEstimado();
            frmCEstimado.MdiParent = this;
            frmCEstimado.Show();
        }

        private void evaluarInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvaluarInformacion frmEvalInfo = new frmEvaluarInformacion();
            frmEvalInfo.MdiParent = this;
            frmEvalInfo.Show();
        }

        private void cuotasMínimasTiendasNuevasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuotasMinimasTiendas frmCM = new frmCuotasMinimasTiendas();
            frmCM.MdiParent = this;
            frmCM.Show();
        }

        private void generarReporteBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptBase frmRP = new frmRptBase();
            frmRP.MdiParent = this;
            frmRP.Show();
        }

        private void PuestoPersonatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPuestoPersona frmPP = new frmPuestoPersona();
            frmPP.MdiParent = this;
            frmPP.Show();
        }

        private void generarEstimadoBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstimadoBase frmEB = new frmEstimadoBase();
            frmEB.MdiParent = this;
            frmEB.Show();
        }

        private void cargaDeVersiónEstimadoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarEstimado frmCE = new frmCargarEstimado();
            frmCE.MdiParent = this;
            frmCE.Show();
        }

        private void determinarDeCrecimientoEnComisiónSellOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCriterioCrecimiento frmcrecsell = new frmCriterioCrecimiento();
            frmcrecsell.MdiParent = this;
            frmcrecsell.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //string menuInicial;
            //bool permiso = false;
            //menuInicial = "catálogosToolStripMenuItem";
            //menuStrip1.Items[menuInicial].Visible = false;
        }

        private void sKUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogoSKU frmCS = new frmCatalogoSKU();
            frmCS.MdiParent = this;
            frmCS.Show();
        }

        private void importeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImpBono frmimp = new frmImpBono();
            frmimp.MdiParent = this;
            frmimp.Show();
        }

        private void sKUItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSku_item frmskuitem = new frmSku_item();
            frmskuitem.MdiParent = this;
            frmskuitem.Show();
        }

    }
}
