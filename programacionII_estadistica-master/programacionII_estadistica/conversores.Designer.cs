namespace programacionII_estadistica
{
    partial class conversores
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
            this.components = new System.ComponentModel.Container();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.lbltipo = new System.Windows.Forms.Label();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.cbode = new System.Windows.Forms.ComboBox();
            this.lblde = new System.Windows.Forms.Label();
            this.cboa = new System.Windows.Forms.ComboBox();
            this.lbla = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(55, 187);
            this.btnconvertir.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(136, 36);
            this.btnconvertir.TabIndex = 0;
            this.btnconvertir.Text = "CONVERTIR";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(56, 22);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(35, 13);
            this.lbltipo.TabIndex = 1;
            this.lbltipo.Text = "TIPO:";
            // 
            // cbotipo
            // 
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "Monedas",
            "Longitud",
            "Peso",
            "Almacenamiento",
            "Volumen"});
            this.cbotipo.Location = new System.Drawing.Point(92, 22);
            this.cbotipo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(117, 21);
            this.cbotipo.TabIndex = 2;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            // 
            // cbode
            // 
            this.cbode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbode.FormattingEnabled = true;
            this.cbode.Location = new System.Drawing.Point(40, 81);
            this.cbode.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbode.Name = "cbode";
            this.cbode.Size = new System.Drawing.Size(98, 21);
            this.cbode.TabIndex = 4;
            // 
            // lblde
            // 
            this.lblde.AutoSize = true;
            this.lblde.Location = new System.Drawing.Point(10, 84);
            this.lblde.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblde.Name = "lblde";
            this.lblde.Size = new System.Drawing.Size(25, 13);
            this.lblde.TabIndex = 3;
            this.lblde.Text = "DE:";
            // 
            // cboa
            // 
            this.cboa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboa.FormattingEnabled = true;
            this.cboa.Location = new System.Drawing.Point(164, 81);
            this.cboa.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cboa.Name = "cboa";
            this.cboa.Size = new System.Drawing.Size(99, 21);
            this.cboa.TabIndex = 6;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(146, 83);
            this.lbla.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(17, 13);
            this.lbla.TabIndex = 5;
            this.lbla.Text = "A:";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(12, 138);
            this.lblcantidad.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(65, 13);
            this.lblcantidad.TabIndex = 7;
            this.lblcantidad.Text = "CANTIDAD:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(76, 136);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(96, 20);
            this.txtcantidad.TabIndex = 8;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(191, 137);
            this.lblrespuesta.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(13, 13);
            this.lblrespuesta.TabIndex = 9;
            this.lblrespuesta.Text = "?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // conversores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 262);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.cboa);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.cbode);
            this.Controls.Add(this.lblde);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.btnconvertir);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "conversores";
            this.Text = "conversores";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.ComboBox cbode;
        private System.Windows.Forms.Label lblde;
        private System.Windows.Forms.ComboBox cboa;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}