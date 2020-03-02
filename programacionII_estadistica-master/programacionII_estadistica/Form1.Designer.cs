namespace programacionII_estadistica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblserie = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.btnMediaAritmetica = new System.Windows.Forms.Button();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.btnCalcularEstandar = new System.Windows.Forms.Button();
            this.btnCalcularTpica = new System.Windows.Forms.Button();
            this.grdEstadistica = new System.Windows.Forms.DataGridView();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xixfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2ixfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotalf1 = new System.Windows.Forms.Label();
            this.lbltotalxixfi = new System.Windows.Forms.Label();
            this.lbltotalx2ixfi = new System.Windows.Forms.Label();
            this.lbltotales = new System.Windows.Forms.Label();
            this.lblmedia = new System.Windows.Forms.Label();
            this.lblestandar = new System.Windows.Forms.Label();
            this.lbltipica = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.lblMediaR = new System.Windows.Forms.Label();
            this.btnModa = new System.Windows.Forms.Button();
            this.lblModa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(17, 22);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(42, 13);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "SERIE:";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(65, 19);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(184, 20);
            this.txtserie.TabIndex = 1;
            // 
            // btnMediaAritmetica
            // 
            this.btnMediaAritmetica.Location = new System.Drawing.Point(255, 12);
            this.btnMediaAritmetica.Name = "btnMediaAritmetica";
            this.btnMediaAritmetica.Size = new System.Drawing.Size(79, 32);
            this.btnMediaAritmetica.TabIndex = 2;
            this.btnMediaAritmetica.Text = "Calcular X";
            this.btnMediaAritmetica.UseVisualStyleBackColor = true;
            this.btnMediaAritmetica.Click += new System.EventHandler(this.btnMediaAritmetica_Click);
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(23, 47);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(14, 13);
            this.lblrespuesta.TabIndex = 3;
            this.lblrespuesta.Text = "X";
            // 
            // btnCalcularEstandar
            // 
            this.btnCalcularEstandar.Location = new System.Drawing.Point(340, 12);
            this.btnCalcularEstandar.Name = "btnCalcularEstandar";
            this.btnCalcularEstandar.Size = new System.Drawing.Size(105, 32);
            this.btnCalcularEstandar.TabIndex = 4;
            this.btnCalcularEstandar.Text = "Calcular Estandar";
            this.btnCalcularEstandar.UseVisualStyleBackColor = true;
            this.btnCalcularEstandar.Click += new System.EventHandler(this.btnCalcularEstandar_Click);
            // 
            // btnCalcularTpica
            // 
            this.btnCalcularTpica.Location = new System.Drawing.Point(451, 12);
            this.btnCalcularTpica.Name = "btnCalcularTpica";
            this.btnCalcularTpica.Size = new System.Drawing.Size(86, 32);
            this.btnCalcularTpica.TabIndex = 5;
            this.btnCalcularTpica.Text = "Calcular Tipica";
            this.btnCalcularTpica.UseVisualStyleBackColor = true;
            this.btnCalcularTpica.Click += new System.EventHandler(this.btnCalcularTpica_Click);
            // 
            // grdEstadistica
            // 
            this.grdEstadistica.AllowUserToDeleteRows = false;
            this.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstadistica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x1,
            this.f1,
            this.fi,
            this.xixfi,
            this.x2ixfi});
            this.grdEstadistica.Location = new System.Drawing.Point(20, 94);
            this.grdEstadistica.Margin = new System.Windows.Forms.Padding(1);
            this.grdEstadistica.Name = "grdEstadistica";
            this.grdEstadistica.RowHeadersWidth = 102;
            this.grdEstadistica.RowTemplate.Height = 40;
            this.grdEstadistica.Size = new System.Drawing.Size(510, 278);
            this.grdEstadistica.TabIndex = 6;
            this.grdEstadistica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEstadistica_CellContentClick);
            this.grdEstadistica.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grdEstadistica_KeyUp);
            // 
            // x1
            // 
            this.x1.HeaderText = "X1";
            this.x1.MinimumWidth = 12;
            this.x1.Name = "x1";
            this.x1.Width = 60;
            // 
            // f1
            // 
            this.f1.HeaderText = "F1";
            this.f1.MinimumWidth = 12;
            this.f1.Name = "f1";
            this.f1.Width = 60;
            // 
            // fi
            // 
            this.fi.HeaderText = "Fi";
            this.fi.MinimumWidth = 12;
            this.fi.Name = "fi";
            this.fi.Width = 60;
            // 
            // xixfi
            // 
            this.xixfi.HeaderText = "Xi * Fi";
            this.xixfi.MinimumWidth = 12;
            this.xixfi.Name = "xixfi";
            // 
            // x2ixfi
            // 
            this.x2ixfi.HeaderText = "X2i * Fi";
            this.x2ixfi.MinimumWidth = 12;
            this.x2ixfi.Name = "x2ixfi";
            // 
            // lbltotalf1
            // 
            this.lbltotalf1.AutoSize = true;
            this.lbltotalf1.Location = new System.Drawing.Point(196, 383);
            this.lbltotalf1.Name = "lbltotalf1";
            this.lbltotalf1.Size = new System.Drawing.Size(46, 13);
            this.lbltotalf1.TabIndex = 7;
            this.lbltotalf1.Text = "Total F1";
            // 
            // lbltotalxixfi
            // 
            this.lbltotalxixfi.AutoSize = true;
            this.lbltotalxixfi.Location = new System.Drawing.Point(303, 383);
            this.lbltotalxixfi.Name = "lbltotalxixfi";
            this.lbltotalxixfi.Size = new System.Drawing.Size(58, 13);
            this.lbltotalxixfi.TabIndex = 8;
            this.lbltotalxixfi.Text = "Total x1*f1";
            // 
            // lbltotalx2ixfi
            // 
            this.lbltotalx2ixfi.AutoSize = true;
            this.lbltotalx2ixfi.Location = new System.Drawing.Point(410, 383);
            this.lbltotalx2ixfi.Name = "lbltotalx2ixfi";
            this.lbltotalx2ixfi.Size = new System.Drawing.Size(64, 13);
            this.lbltotalx2ixfi.TabIndex = 9;
            this.lbltotalx2ixfi.Text = "Total x21*f1";
            // 
            // lbltotales
            // 
            this.lbltotales.AutoSize = true;
            this.lbltotales.Location = new System.Drawing.Point(23, 383);
            this.lbltotales.Name = "lbltotales";
            this.lbltotales.Size = new System.Drawing.Size(59, 13);
            this.lbltotales.TabIndex = 10;
            this.lbltotales.Text = "TOTALES:";
            // 
            // lblmedia
            // 
            this.lblmedia.AutoSize = true;
            this.lblmedia.Location = new System.Drawing.Point(23, 421);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(14, 13);
            this.lblmedia.TabIndex = 11;
            this.lblmedia.Text = "X";
            // 
            // lblestandar
            // 
            this.lblestandar.AutoSize = true;
            this.lblestandar.Location = new System.Drawing.Point(161, 421);
            this.lblestandar.Name = "lblestandar";
            this.lblestandar.Size = new System.Drawing.Size(49, 13);
            this.lblestandar.TabIndex = 12;
            this.lblestandar.Text = "Estandar";
            // 
            // lbltipica
            // 
            this.lbltipica.AutoSize = true;
            this.lbltipica.Location = new System.Drawing.Point(312, 421);
            this.lbltipica.Name = "lbltipica";
            this.lbltipica.Size = new System.Drawing.Size(36, 13);
            this.lbltipica.TabIndex = 13;
            this.lbltipica.Text = "Tipica";
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(557, 94);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(99, 31);
            this.btnMedia.TabIndex = 14;
            this.btnMedia.Text = "Media Aritmética.";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lblMediaR
            // 
            this.lblMediaR.AutoSize = true;
            this.lblMediaR.Location = new System.Drawing.Point(601, 139);
            this.lblMediaR.Name = "lblMediaR";
            this.lblMediaR.Size = new System.Drawing.Size(13, 13);
            this.lblMediaR.TabIndex = 15;
            this.lblMediaR.Text = "?";
            // 
            // btnModa
            // 
            this.btnModa.Location = new System.Drawing.Point(557, 195);
            this.btnModa.Name = "btnModa";
            this.btnModa.Size = new System.Drawing.Size(99, 31);
            this.btnModa.TabIndex = 16;
            this.btnModa.Text = "Moda";
            this.btnModa.UseVisualStyleBackColor = true;
            this.btnModa.Click += new System.EventHandler(this.btnModa_Click);
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Location = new System.Drawing.Point(601, 245);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(13, 13);
            this.lblModa.TabIndex = 17;
            this.lblModa.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 469);
            this.Controls.Add(this.lblModa);
            this.Controls.Add(this.btnModa);
            this.Controls.Add(this.lblMediaR);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.lbltipica);
            this.Controls.Add(this.lblestandar);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.lbltotales);
            this.Controls.Add(this.lbltotalx2ixfi);
            this.Controls.Add(this.lbltotalxixfi);
            this.Controls.Add(this.lbltotalf1);
            this.Controls.Add(this.grdEstadistica);
            this.Controls.Add(this.btnCalcularTpica);
            this.Controls.Add(this.btnCalcularEstandar);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.btnMediaAritmetica);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblserie);
            this.Name = "Form1";
            this.Text = "Calculos basicos Estadistica";
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Button btnMediaAritmetica;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Button btnCalcularEstandar;
        private System.Windows.Forms.Button btnCalcularTpica;
        private System.Windows.Forms.DataGridView grdEstadistica;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn f1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xixfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2ixfi;
        private System.Windows.Forms.Label lbltotalf1;
        private System.Windows.Forms.Label lbltotalxixfi;
        private System.Windows.Forms.Label lbltotalx2ixfi;
        private System.Windows.Forms.Label lbltotales;
        private System.Windows.Forms.Label lblmedia;
        private System.Windows.Forms.Label lblestandar;
        private System.Windows.Forms.Label lbltipica;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label lblMediaR;
        private System.Windows.Forms.Button btnModa;
        private System.Windows.Forms.Label lblModa;
    }
}

