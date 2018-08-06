namespace Ventas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.trnPnlMenu = new System.Windows.Forms.Panel();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.pxbFoto = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tpnlHeader = new MLP.Utilities.TransparentPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pxbxMin = new System.Windows.Forms.PictureBox();
            this.pxbClose = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.trpnlHeaderWS = new MLP.Utilities.TransparentPanel();
            this.pxbCloseWs = new System.Windows.Forms.PictureBox();
            this.lblNameForm = new MLP.Utilities.TransparentLabel();
            this.pnlWorkSpace = new System.Windows.Forms.Panel();
            this.trnPnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbFoto)).BeginInit();
            this.tpnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbClose)).BeginInit();
            this.trpnlHeaderWS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbCloseWs)).BeginInit();
            this.SuspendLayout();
            // 
            // trnPnlMenu
            // 
            this.trnPnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.trnPnlMenu.Controls.Add(this.lblDepartamento);
            this.trnPnlMenu.Controls.Add(this.lblUsuario);
            this.trnPnlMenu.Controls.Add(this.tvMenu);
            this.trnPnlMenu.Controls.Add(this.pxbFoto);
            this.trnPnlMenu.Controls.Add(this.shapeContainer1);
            this.trnPnlMenu.Location = new System.Drawing.Point(0, 31);
            this.trnPnlMenu.Name = "trnPnlMenu";
            this.trnPnlMenu.Size = new System.Drawing.Size(200, 519);
            this.trnPnlMenu.TabIndex = 0;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartamento.Location = new System.Drawing.Point(3, 159);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(192, 20);
            this.lblDepartamento.TabIndex = 6;
            this.lblDepartamento.Text = "Gerente IT";
            this.lblDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(3, 139);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(192, 20);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Oscar Rodríguez";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMenu.ForeColor = System.Drawing.Color.White;
            this.tvMenu.ImageKey = "3dTouch.png";
            this.tvMenu.LineColor = System.Drawing.Color.White;
            this.tvMenu.Location = new System.Drawing.Point(5, 220);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.ShowPlusMinus = false;
            this.tvMenu.ShowRootLines = false;
            this.tvMenu.Size = new System.Drawing.Size(188, 308);
            this.tvMenu.TabIndex = 4;
            this.tvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMenu_AfterSelect);
            // 
            // pxbFoto
            // 
            this.pxbFoto.Location = new System.Drawing.Point(44, 16);
            this.pxbFoto.Name = "pxbFoto";
            this.pxbFoto.Size = new System.Drawing.Size(115, 120);
            this.pxbFoto.TabIndex = 3;
            this.pxbFoto.TabStop = false;
            this.pxbFoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pxbFoto_Paint_1);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(200, 519);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 23;
            this.lineShape1.X2 = 171;
            this.lineShape1.Y1 = 193;
            this.lineShape1.Y2 = 193;
            // 
            // tpnlHeader
            // 
            this.tpnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(210)))));
            this.tpnlHeader.Controls.Add(this.pictureBox1);
            this.tpnlHeader.Controls.Add(this.label1);
            this.tpnlHeader.Controls.Add(this.pxbxMin);
            this.tpnlHeader.Controls.Add(this.pxbClose);
            this.tpnlHeader.Location = new System.Drawing.Point(0, 0);
            this.tpnlHeader.Name = "tpnlHeader";
            this.tpnlHeader.Opacity = 100;
            this.tpnlHeader.Size = new System.Drawing.Size(947, 32);
            this.tpnlHeader.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ventas.Properties.Resources.Time_Filled50;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema de Ventas V1";
            // 
            // pxbxMin
            // 
            this.pxbxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(211)))));
            this.pxbxMin.BackgroundImage = global::Ventas.Properties.Resources.Minus_Math__241;
            this.pxbxMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pxbxMin.Location = new System.Drawing.Point(891, 1);
            this.pxbxMin.Name = "pxbxMin";
            this.pxbxMin.Size = new System.Drawing.Size(28, 29);
            this.pxbxMin.TabIndex = 1;
            this.pxbxMin.TabStop = false;
            this.pxbxMin.Click += new System.EventHandler(this.pxbxMin_Click);
            this.pxbxMin.MouseLeave += new System.EventHandler(this.pxbxMin_MouseLeave);
            this.pxbxMin.MouseHover += new System.EventHandler(this.pxbxMin_MouseHover);
            // 
            // pxbClose
            // 
            this.pxbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(211)))));
            this.pxbClose.BackgroundImage = global::Ventas.Properties.Resources.Multiply_Filled_24;
            this.pxbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pxbClose.Location = new System.Drawing.Point(918, 1);
            this.pxbClose.Name = "pxbClose";
            this.pxbClose.Size = new System.Drawing.Size(28, 29);
            this.pxbClose.TabIndex = 0;
            this.pxbClose.TabStop = false;
            this.pxbClose.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pxbClose.MouseLeave += new System.EventHandler(this.pxbClose_MouseLeave);
            this.pxbClose.MouseHover += new System.EventHandler(this.pxbClose_MouseHover);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "3dTouch.png");
            this.imageList1.Images.SetKeyName(1, "Form.png");
            this.imageList1.Images.SetKeyName(2, "3dTouchColor.png");
            this.imageList1.Images.SetKeyName(3, "Form_Color.png");
            this.imageList1.Images.SetKeyName(4, "MenuA.png");
            this.imageList1.Images.SetKeyName(5, "Settings.png");
            // 
            // trpnlHeaderWS
            // 
            this.trpnlHeaderWS.BackColor = System.Drawing.Color.Transparent;
            this.trpnlHeaderWS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trpnlHeaderWS.Controls.Add(this.pnlWorkSpace);
            this.trpnlHeaderWS.Controls.Add(this.pxbCloseWs);
            this.trpnlHeaderWS.Controls.Add(this.lblNameForm);
            this.trpnlHeaderWS.Location = new System.Drawing.Point(207, 47);
            this.trpnlHeaderWS.Name = "trpnlHeaderWS";
            this.trpnlHeaderWS.Opacity = 100;
            this.trpnlHeaderWS.Size = new System.Drawing.Size(639, 31);
            this.trpnlHeaderWS.TabIndex = 1002;
            // 
            // pxbCloseWs
            // 
            this.pxbCloseWs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(210)))));
            this.pxbCloseWs.BackgroundImage = global::Ventas.Properties.Resources.Close_Window_24;
            this.pxbCloseWs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pxbCloseWs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxbCloseWs.Location = new System.Drawing.Point(595, 0);
            this.pxbCloseWs.Name = "pxbCloseWs";
            this.pxbCloseWs.Size = new System.Drawing.Size(28, 29);
            this.pxbCloseWs.TabIndex = 1000;
            this.pxbCloseWs.TabStop = false;
            this.pxbCloseWs.Click += new System.EventHandler(this.pxbCloseWs_Click);
            // 
            // lblNameForm
            // 
            this.lblNameForm.AutoSize = true;
            this.lblNameForm.BackColor = System.Drawing.Color.Transparent;
            this.lblNameForm.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameForm.ForeColor = System.Drawing.Color.White;
            this.lblNameForm.Location = new System.Drawing.Point(4, 8);
            this.lblNameForm.Name = "lblNameForm";
            this.lblNameForm.Size = new System.Drawing.Size(171, 20);
            this.lblNameForm.TabIndex = 5;
            this.lblNameForm.Text = "Nombre del Formulario";
            this.lblNameForm.Visible = false;
            // 
            // pnlWorkSpace
            // 
            this.pnlWorkSpace.BackColor = System.Drawing.Color.Black;
            this.pnlWorkSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWorkSpace.Location = new System.Drawing.Point(8, 31);
            this.pnlWorkSpace.Name = "pnlWorkSpace";
            this.pnlWorkSpace.Size = new System.Drawing.Size(783, 449);
            this.pnlWorkSpace.TabIndex = 1003;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.BackgroundImage = global::Ventas.Properties.Resources.iPadBackgroundTexture_grey;
            this.ClientSize = new System.Drawing.Size(1077, 550);
            this.Controls.Add(this.trpnlHeaderWS);
            this.Controls.Add(this.tpnlHeader);
            this.Controls.Add(this.trnPnlMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.trnPnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pxbFoto)).EndInit();
            this.tpnlHeader.ResumeLayout(false);
            this.tpnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbClose)).EndInit();
            this.trpnlHeaderWS.ResumeLayout(false);
            this.trpnlHeaderWS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbCloseWs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       // private MLP.Utilities.TransparentPanel trnPnlMenu;
        private System.Windows.Forms.Panel trnPnlMenu;
        private System.Windows.Forms.PictureBox pxbFoto;
        private System.Windows.Forms.PictureBox pxbClose;
        private System.Windows.Forms.PictureBox pxbxMin;
        private MLP.Utilities.TransparentPanel tpnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ImageList imageList1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private MLP.Utilities.TransparentPanel trpnlHeaderWS;
        private System.Windows.Forms.PictureBox pxbCloseWs;
        private MLP.Utilities.TransparentLabel lblNameForm;
        private System.Windows.Forms.Panel pnlWorkSpace;
    }
}

