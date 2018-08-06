namespace Ventas
{
    partial class frmEvaluarInformacion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Porcentaje = new System.Windows.Forms.TabPage();
            this.btnObtenerInformacion = new System.Windows.Forms.Button();
            this.dgvPorcentaje = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnObtenerInfoSellOut = new System.Windows.Forms.Button();
            this.btnEvaluarProductosNvos = new System.Windows.Forms.Button();
            this.btnEvaluarTiendasSinHist = new System.Windows.Forms.Button();
            this.btnEvaluarTiendasNvas = new System.Windows.Forms.Button();
            this.dgvPorcTienda = new System.Windows.Forms.DataGridView();
            this.btnAplicarPorcSellInTiendas = new System.Windows.Forms.Button();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Porcentaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorcentaje)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorcTienda)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Porcentaje);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // Porcentaje
            // 
            this.Porcentaje.Controls.Add(this.btnObtenerInformacion);
            this.Porcentaje.Controls.Add(this.dgvPorcentaje);
            this.Porcentaje.Controls.Add(this.button1);
            this.Porcentaje.Location = new System.Drawing.Point(4, 22);
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Padding = new System.Windows.Forms.Padding(3);
            this.Porcentaje.Size = new System.Drawing.Size(747, 300);
            this.Porcentaje.TabIndex = 0;
            this.Porcentaje.Text = "Porcentaje Crecimiento SellIn";
            this.Porcentaje.UseVisualStyleBackColor = true;
            // 
            // btnObtenerInformacion
            // 
            this.btnObtenerInformacion.Location = new System.Drawing.Point(174, 6);
            this.btnObtenerInformacion.Name = "btnObtenerInformacion";
            this.btnObtenerInformacion.Size = new System.Drawing.Size(145, 23);
            this.btnObtenerInformacion.TabIndex = 2;
            this.btnObtenerInformacion.Text = "Obtener Información";
            this.btnObtenerInformacion.UseVisualStyleBackColor = true;
            this.btnObtenerInformacion.Click += new System.EventHandler(this.btnObtenerInformacion_Click);
            // 
            // dgvPorcentaje
            // 
            this.dgvPorcentaje.AllowUserToAddRows = false;
            this.dgvPorcentaje.AllowUserToDeleteRows = false;
            this.dgvPorcentaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorcentaje.Location = new System.Drawing.Point(6, 35);
            this.dgvPorcentaje.Name = "dgvPorcentaje";
            this.dgvPorcentaje.ReadOnly = true;
            this.dgvPorcentaje.Size = new System.Drawing.Size(723, 259);
            this.dgvPorcentaje.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular %";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnObtenerInfoSellOut);
            this.tabPage2.Controls.Add(this.btnEvaluarProductosNvos);
            this.tabPage2.Controls.Add(this.btnEvaluarTiendasSinHist);
            this.tabPage2.Controls.Add(this.btnEvaluarTiendasNvas);
            this.tabPage2.Controls.Add(this.dgvPorcTienda);
            this.tabPage2.Controls.Add(this.btnAplicarPorcSellInTiendas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(747, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Objetivos de venta en Tiendas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnObtenerInfoSellOut
            // 
            this.btnObtenerInfoSellOut.Location = new System.Drawing.Point(6, 35);
            this.btnObtenerInfoSellOut.Name = "btnObtenerInfoSellOut";
            this.btnObtenerInfoSellOut.Size = new System.Drawing.Size(145, 23);
            this.btnObtenerInfoSellOut.TabIndex = 6;
            this.btnObtenerInfoSellOut.Text = "Obtener Información";
            this.btnObtenerInfoSellOut.UseVisualStyleBackColor = true;
            this.btnObtenerInfoSellOut.Click += new System.EventHandler(this.btnObtenerInfoSellOut_Click);
            // 
            // btnEvaluarProductosNvos
            // 
            this.btnEvaluarProductosNvos.Location = new System.Drawing.Point(558, 6);
            this.btnEvaluarProductosNvos.Name = "btnEvaluarProductosNvos";
            this.btnEvaluarProductosNvos.Size = new System.Drawing.Size(178, 23);
            this.btnEvaluarProductosNvos.TabIndex = 5;
            this.btnEvaluarProductosNvos.Text = "Evaluar Productos Nuevos";
            this.btnEvaluarProductosNvos.UseVisualStyleBackColor = true;
            this.btnEvaluarProductosNvos.Visible = false;
            this.btnEvaluarProductosNvos.Click += new System.EventHandler(this.btnEvaluarProductosNvos_Click);
            // 
            // btnEvaluarTiendasSinHist
            // 
            this.btnEvaluarTiendasSinHist.Location = new System.Drawing.Point(374, 6);
            this.btnEvaluarTiendasSinHist.Name = "btnEvaluarTiendasSinHist";
            this.btnEvaluarTiendasSinHist.Size = new System.Drawing.Size(178, 23);
            this.btnEvaluarTiendasSinHist.TabIndex = 4;
            this.btnEvaluarTiendasSinHist.Text = "Evaluar Tiendas Nuevas sin Hist";
            this.btnEvaluarTiendasSinHist.UseVisualStyleBackColor = true;
            this.btnEvaluarTiendasSinHist.Click += new System.EventHandler(this.btnEvaluarTiendasSinHist_Click);
            // 
            // btnEvaluarTiendasNvas
            // 
            this.btnEvaluarTiendasNvas.Location = new System.Drawing.Point(190, 6);
            this.btnEvaluarTiendasNvas.Name = "btnEvaluarTiendasNvas";
            this.btnEvaluarTiendasNvas.Size = new System.Drawing.Size(178, 23);
            this.btnEvaluarTiendasNvas.TabIndex = 3;
            this.btnEvaluarTiendasNvas.Text = "Evaluar Tiendas Nuevas con Hist";
            this.btnEvaluarTiendasNvas.UseVisualStyleBackColor = true;
            this.btnEvaluarTiendasNvas.Click += new System.EventHandler(this.btnEvaluarTiendasNvas_Click);
            // 
            // dgvPorcTienda
            // 
            this.dgvPorcTienda.AllowUserToAddRows = false;
            this.dgvPorcTienda.AllowUserToDeleteRows = false;
            this.dgvPorcTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorcTienda.Location = new System.Drawing.Point(6, 60);
            this.dgvPorcTienda.Name = "dgvPorcTienda";
            this.dgvPorcTienda.ReadOnly = true;
            this.dgvPorcTienda.Size = new System.Drawing.Size(730, 234);
            this.dgvPorcTienda.TabIndex = 2;
            // 
            // btnAplicarPorcSellInTiendas
            // 
            this.btnAplicarPorcSellInTiendas.Location = new System.Drawing.Point(6, 6);
            this.btnAplicarPorcSellInTiendas.Name = "btnAplicarPorcSellInTiendas";
            this.btnAplicarPorcSellInTiendas.Size = new System.Drawing.Size(178, 23);
            this.btnAplicarPorcSellInTiendas.TabIndex = 0;
            this.btnAplicarPorcSellInTiendas.Text = "Aplicar % de SellIn a Tiendas";
            this.btnAplicarPorcSellInTiendas.UseVisualStyleBackColor = true;
            this.btnAplicarPorcSellInTiendas.Click += new System.EventHandler(this.btnAplicarPorcSellInTiendas_Click);
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(187, 12);
            this.txtVersion.MaxLength = 3;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(39, 20);
            this.txtVersion.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Versión:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(48, 12);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(60, 20);
            this.txtAnio.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Año:";
            // 
            // frmEvaluarInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 376);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEvaluarInformacion";
            this.Text = "Evaluar Información";
            this.Load += new System.EventHandler(this.frmEvaluarInformacion_Load);
            this.tabControl1.ResumeLayout(false);
            this.Porcentaje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorcentaje)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorcTienda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Porcentaje;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPorcentaje;
        private System.Windows.Forms.Button btnObtenerInformacion;
        private System.Windows.Forms.Button btnAplicarPorcSellInTiendas;
        private System.Windows.Forms.DataGridView dgvPorcTienda;
        private System.Windows.Forms.Button btnEvaluarTiendasNvas;
        private System.Windows.Forms.Button btnEvaluarTiendasSinHist;
        private System.Windows.Forms.Button btnEvaluarProductosNvos;
        private System.Windows.Forms.Button btnObtenerInfoSellOut;
    }
}