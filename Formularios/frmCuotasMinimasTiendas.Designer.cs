namespace Ventas
{
    partial class frmCuotasMinimasTiendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuotasMinimasTiendas));
            this.txtDescCadena = new System.Windows.Forms.TextBox();
            this.btnCadena = new System.Windows.Forms.Button();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescArticulo = new System.Windows.Forms.TextBox();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPiezas = new System.Windows.Forms.Label();
            this.txtPiezas = new System.Windows.Forms.TextBox();
            this.SeguridadgroupBox = new System.Windows.Forms.GroupBox();
            this.txtFechaModif = new System.Windows.Forms.TextBox();
            this.txtUsuModif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.txtUsuCreacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsuCreacion = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.SeguridadgroupBox.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescCadena
            // 
            this.txtDescCadena.Location = new System.Drawing.Point(223, 41);
            this.txtDescCadena.Name = "txtDescCadena";
            this.txtDescCadena.ReadOnly = true;
            this.txtDescCadena.Size = new System.Drawing.Size(330, 20);
            this.txtDescCadena.TabIndex = 28;
            // 
            // btnCadena
            // 
            this.btnCadena.Location = new System.Drawing.Point(193, 39);
            this.btnCadena.Name = "btnCadena";
            this.btnCadena.Size = new System.Drawing.Size(23, 23);
            this.btnCadena.TabIndex = 27;
            this.btnCadena.UseVisualStyleBackColor = true;
            this.btnCadena.Click += new System.EventHandler(this.btnCadena_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(87, 41);
            this.txtCadena.MaxLength = 10;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(100, 20);
            this.txtCadena.TabIndex = 25;
            this.txtCadena.Leave += new System.EventHandler(this.txtCadena_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cadena";
            // 
            // txtDescArticulo
            // 
            this.txtDescArticulo.Location = new System.Drawing.Point(223, 70);
            this.txtDescArticulo.Name = "txtDescArticulo";
            this.txtDescArticulo.ReadOnly = true;
            this.txtDescArticulo.Size = new System.Drawing.Size(330, 20);
            this.txtDescArticulo.TabIndex = 32;
            // 
            // btnArticulo
            // 
            this.btnArticulo.Location = new System.Drawing.Point(193, 68);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(23, 23);
            this.btnArticulo.TabIndex = 31;
            this.btnArticulo.UseVisualStyleBackColor = true;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(87, 70);
            this.txtArticulo.MaxLength = 10;
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo.TabIndex = 29;
            this.txtArticulo.Leave += new System.EventHandler(this.txtArticulo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Artículo";
            // 
            // lblPiezas
            // 
            this.lblPiezas.AutoSize = true;
            this.lblPiezas.Location = new System.Drawing.Point(15, 106);
            this.lblPiezas.Name = "lblPiezas";
            this.lblPiezas.Size = new System.Drawing.Size(81, 13);
            this.lblPiezas.TabIndex = 33;
            this.lblPiezas.Text = "Piezas Mínimas";
            // 
            // txtPiezas
            // 
            this.txtPiezas.Location = new System.Drawing.Point(105, 103);
            this.txtPiezas.MaxLength = 10;
            this.txtPiezas.Name = "txtPiezas";
            this.txtPiezas.Size = new System.Drawing.Size(82, 20);
            this.txtPiezas.TabIndex = 34;
            this.txtPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SeguridadgroupBox
            // 
            this.SeguridadgroupBox.Controls.Add(this.txtFechaModif);
            this.SeguridadgroupBox.Controls.Add(this.txtUsuModif);
            this.SeguridadgroupBox.Controls.Add(this.label3);
            this.SeguridadgroupBox.Controls.Add(this.label4);
            this.SeguridadgroupBox.Controls.Add(this.txtFechaCreacion);
            this.SeguridadgroupBox.Controls.Add(this.txtUsuCreacion);
            this.SeguridadgroupBox.Controls.Add(this.label5);
            this.SeguridadgroupBox.Controls.Add(this.lblUsuCreacion);
            this.SeguridadgroupBox.Location = new System.Drawing.Point(18, 129);
            this.SeguridadgroupBox.Name = "SeguridadgroupBox";
            this.SeguridadgroupBox.Size = new System.Drawing.Size(593, 125);
            this.SeguridadgroupBox.TabIndex = 35;
            this.SeguridadgroupBox.TabStop = false;
            this.SeguridadgroupBox.Text = "Seguridad";
            // 
            // txtFechaModif
            // 
            this.txtFechaModif.Location = new System.Drawing.Point(337, 73);
            this.txtFechaModif.Name = "txtFechaModif";
            this.txtFechaModif.ReadOnly = true;
            this.txtFechaModif.Size = new System.Drawing.Size(218, 20);
            this.txtFechaModif.TabIndex = 5;
            // 
            // txtUsuModif
            // 
            this.txtUsuModif.Location = new System.Drawing.Point(113, 73);
            this.txtUsuModif.Name = "txtUsuModif";
            this.txtUsuModif.ReadOnly = true;
            this.txtUsuModif.Size = new System.Drawing.Size(121, 20);
            this.txtUsuModif.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha Modif.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario Modif.";
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(337, 41);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.ReadOnly = true;
            this.txtFechaCreacion.Size = new System.Drawing.Size(218, 20);
            this.txtFechaCreacion.TabIndex = 1;
            // 
            // txtUsuCreacion
            // 
            this.txtUsuCreacion.Location = new System.Drawing.Point(113, 41);
            this.txtUsuCreacion.Name = "txtUsuCreacion";
            this.txtUsuCreacion.ReadOnly = true;
            this.txtUsuCreacion.Size = new System.Drawing.Size(121, 20);
            this.txtUsuCreacion.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha Creación";
            // 
            // lblUsuCreacion
            // 
            this.lblUsuCreacion.AutoSize = true;
            this.lblUsuCreacion.Location = new System.Drawing.Point(16, 44);
            this.lblUsuCreacion.Name = "lblUsuCreacion";
            this.lblUsuCreacion.Size = new System.Drawing.Size(88, 13);
            this.lblUsuCreacion.TabIndex = 2;
            this.lblUsuCreacion.Text = "Usuario Creación";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.deleteStripButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(658, 25);
            this.toolStrip.TabIndex = 36;
            this.toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteStripButton1
            // 
            this.deleteStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("deleteStripButton1.Image")));
            this.deleteStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.deleteStripButton1.Name = "deleteStripButton1";
            this.deleteStripButton1.Size = new System.Drawing.Size(23, 22);
            this.deleteStripButton1.Text = "Open";
            this.deleteStripButton1.Click += new System.EventHandler(this.deleteStripButton1_Click);
            // 
            // frmCuotasMinimasTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 291);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.SeguridadgroupBox);
            this.Controls.Add(this.txtPiezas);
            this.Controls.Add(this.lblPiezas);
            this.Controls.Add(this.txtDescArticulo);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescCadena);
            this.Controls.Add(this.btnCadena);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.label2);
            this.Name = "frmCuotasMinimasTiendas";
            this.Text = "Cuotas Mínimas Tiendas";
            this.SeguridadgroupBox.ResumeLayout(false);
            this.SeguridadgroupBox.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescCadena;
        private System.Windows.Forms.Button btnCadena;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescArticulo;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPiezas;
        private System.Windows.Forms.TextBox txtPiezas;
        private System.Windows.Forms.GroupBox SeguridadgroupBox;
        private System.Windows.Forms.TextBox txtFechaModif;
        private System.Windows.Forms.TextBox txtUsuModif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.TextBox txtUsuCreacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUsuCreacion;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton deleteStripButton1;
    }
}