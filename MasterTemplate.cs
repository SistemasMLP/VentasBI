using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using MLP.CASA.Interface;
using System.IO;
using Ventas.Base;

namespace Ventas
{
    public partial class frmPrincipal : Form
    {
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public InfUsuario_SIA SessionUser
        {
            get;
            set;
        }
        public Image FotoUsuario
        {
            get;
            set;
        }

        public frmPrincipal()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            InitializeComponent();
            
        }

        public frmPrincipal(InfUsuario_SIA sessionUser)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            
            InitializeComponent();
            SessionUser = sessionUser;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; //WS_EX_COMPOSITED
                return cp;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        { 
            InitialConfigs();
        }

        private void SetPanelBar()
        {
            this.Width = ScreenWidth;
            this.Height = ScreenHeight;
            this.Location = new Point(0, 0);
            this.tpnlHeader.Width = ScreenWidth + 1;
            this.trnPnlMenu.Height = ScreenHeight;
            pxbClose.Location = new Point(ScreenWidth - 28, pxbClose.Location.Y);
            pxbxMin.Location = new Point(pxbClose.Location.X - (pxbxMin.Width + 2), pxbxMin.Location.Y);
        }

        private void InitialConfigs()
        {
            this.pnlWorkSpace.Parent = this;
            ScreenWidth = Screen.PrimaryScreen.WorkingArea.Size.Width;
            ScreenHeight = Screen.PrimaryScreen.WorkingArea.Size.Height;
            SetPanelBar();
            CreateMenu();

            InfUsuario_SIA infUsr = SessionUser; 
            InfSeguridad_SIA[] infSeguridad = infUsr.Seguridad;

            MemoryStream msImage = new MemoryStream(infUsr.Foto);
            Image ImgBK = Image.FromStream(msImage);

            FotoUsuario = Image.FromStream(msImage); 
            this.lblUsuario.Text = infUsr.Nombre;
            this.lblDepartamento.Text = infUsr.Departamento;
            
      

        }
        private void CreateMenu()
        { 
            TreeNode tNode;
            tNode = tvMenu.Nodes.Add("-1", "Inicio");

            InfUsuario_SIA infUsr = SessionUser;

            int intIndice = 1;

            InfSeguridad_SIA[] infSeguridad = infUsr.Seguridad; 
            foreach (InfSeguridad_SIA SegPadre in infSeguridad)
            {
                if (SegPadre.Activo)
                {
                    tNode = tvMenu.Nodes.Add(SegPadre.ModuloID.ToString(), SegPadre.Nombre_Modulo, SegPadre.Enlace);
 
                    foreach (InfSeguridad_SIA SegHijo in SegPadre.SeguridadHijo)
                    {
                        if (SegHijo.Activo)
                        {
                            tvMenu.Nodes[intIndice].Nodes.Add(SegHijo.ModuloID.ToString(), SegHijo.Nombre_Modulo, SegHijo.Enlace);
                        }

                    }
                    
                }
                intIndice++;
            }
            tvMenu.ExpandAll(); 
        }
        private void pxbFoto_Paint_1(object sender, PaintEventArgs e)
        {
            try
            {
                GraphicsPath patha;
                GraphicsPath Elips;


                patha = new GraphicsPath();
                Elips = new GraphicsPath();
                Elips.StartFigure();
                patha.StartFigure();
                // add a set of points that define the shape
                //patha.AddLines(new Point[] { new Point(0, 0), new Point(50, 0), new Point(50, 50) });
                patha.AddEllipse(1, 1, pxbFoto.Width - 3, pxbFoto.Height - 5);
                Elips.AddEllipse(1, 1, pxbFoto.Width - 3, pxbFoto.Height - 5);
                //patha.AddEllipse(10, 10, 80, 80);
                // close the shape
                // patha.CloseAllFigures();
                // set the clop region of the forms graphic object to be the new shape
                e.Graphics.Clip = new Region(patha);
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.Clear(Color.White);
                ImageAttributes Attributes = new ImageAttributes();

                Attributes.SetWrapMode(System.Drawing.Drawing2D.WrapMode.Tile);

                Rectangle rec = new Rectangle(0, 0, (pxbFoto.Width), (pxbFoto.Height));
                //Image imgA = Image.FromFile("C:\\Users\\orodriguez\\Pictures\\Photoorodriguez.PNG");
                //Image img = Image.FromFile("C:\\Users\\orodriguez\\Pictures\\AlbertEinstein.jpg");
                //Image img = Image.FromFile("C:\\Users\\orodriguez\\Pictures\\Photoorodriguez.PNG");
                // draw the image cliped to the custom shape
                //e.Graphics.DrawImage(Image.FromFile("C:\\Users\\orodriguez\\Pictures\\AlbertEinstein.jpg"), pictureBox1.ClientRectangle, 10, 10, (pictureBox1.Width * 2) , (pictureBox1.Height * 2) , GraphicsUnit.Pixel, Attributes);
                e.Graphics.DrawImage(FotoUsuario, pxbFoto.ClientRectangle, 0, 0, (FotoUsuario.Width), (FotoUsuario.Height), GraphicsUnit.Pixel, Attributes);

                //e.Graphics.DrawImage(imgA, pxbFoto.ClientRectangle, 0, 0, (img.Width-20), (img.Height-20), GraphicsUnit.Pixel, Attributes);

                e.Graphics.DrawPath(new Pen(Color.White, 5), Elips);
                e.Graphics.TranslateTransform(25, 25);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pxbClose_MouseHover(object sender, EventArgs e)
        {
           Color color = System.Drawing.ColorTranslator.FromHtml("#3473AA");
            this.pxbClose.BackColor = color;
        }

        private void pxbClose_MouseLeave(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#488FD3");
            this.pxbClose.BackColor = color;
        }

        private void pxbxMin_MouseHover(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#3473AA");
            this.pxbxMin.BackColor = color;
        }

        private void pxbxMin_MouseLeave(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#488FD3");
            this.pxbxMin.BackColor = color;
        }

        private void pxbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                MasterTemplateBase.Instance.CloseAllForms(ref this.pnlWorkSpace);
                MasterTemplateBase.Instance.BuildForm(ref this.pnlWorkSpace, ((System.Windows.Forms.TreeView)(sender)).SelectedNode.ImageKey, false, ((System.Windows.Forms.TreeView)(sender)).SelectedNode.Text, SessionUser);
              
                SetPanelWork();
                Application.DoEvents();
                //lblNameForm.Text = ((System.Windows.Forms.TreeView)(sender)).SelectedNode.Text;
                if (this.pnlWorkSpace.Controls.Count == 0)
                {
                    this.trpnlHeaderWS.Visible = false;
                    this.pnlWorkSpace.Visible = false;
                }
                else
                {
                    this.trpnlHeaderWS.Visible = true;
                    this.pnlWorkSpace.Visible = true;
                }
                MasterTemplateBase.Instance.ShowFormForms(ref this.pnlWorkSpace, ((System.Windows.Forms.TreeView)(sender)).SelectedNode.ImageKey);
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                this.trpnlHeaderWS.Visible = false;
                this.pnlWorkSpace.Visible = false;

            }
        }
        private void SetPanelWork()
        {
            pnlWorkSpace.Location = new Point(((ScreenWidth / 2) - (pnlWorkSpace.Size.Width / 2)) + (trnPnlMenu.Width / 2), 40);
            trpnlHeaderWS.Location = new Point(((ScreenWidth / 2) - (pnlWorkSpace.Size.Width / 2)) + (trnPnlMenu.Width / 2) - 2, tpnlHeader.Height + 6);
            this.trpnlHeaderWS.Width = this.pnlWorkSpace.Width; 
            this.pxbCloseWs.Location = new Point((this.trpnlHeaderWS.Width - this.pxbCloseWs.Width), 3); 
            Application.DoEvents();
        }

        private void trlblCerrarWS_Click(object sender, EventArgs e)
        {
            try
            {
                MasterTemplateBase.Instance.CloseAllForms(ref this.pnlWorkSpace);
                this.trpnlHeaderWS.Visible = false; 
                this.pnlWorkSpace.Visible = false; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tvMenu_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pxbCloseWs_Click(object sender, EventArgs e)
        {
            try
            {
                MasterTemplateBase.Instance.CloseAllForms(ref this.pnlWorkSpace);
                //tvMenu.SelectedNode = 0;
                tvMenu.SelectedNode = tvMenu.Nodes[0].FirstNode;
                this.trpnlHeaderWS.Visible = false;
                this.pnlWorkSpace.Visible = false;
            }
            catch (Exception ex)
            {
            }
        }

        
    }
}
