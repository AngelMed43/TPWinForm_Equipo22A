namespace TPWinForm_equipo_22A
{
    partial class frmModificarMarca
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
            this.grpBModificarMarca = new System.Windows.Forms.GroupBox();
            this.grpBDatosActualesMarca = new System.Windows.Forms.GroupBox();
            this.txtBDescripcionMarcaActual = new System.Windows.Forms.TextBox();
            this.lblDescripcionMarcaActual = new System.Windows.Forms.Label();
            this.lblNombreActualMarca = new System.Windows.Forms.Label();
            this.txtBNombreActualMarca = new System.Windows.Forms.TextBox();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.txtBDescripcionMarca = new System.Windows.Forms.TextBox();
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIDMarca = new System.Windows.Forms.Label();
            this.grpBModificarMarca.SuspendLayout();
            this.grpBDatosActualesMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBModificarMarca
            // 
            this.grpBModificarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBModificarMarca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBModificarMarca.Controls.Add(this.grpBDatosActualesMarca);
            this.grpBModificarMarca.Controls.Add(this.btnCancelarMarca);
            this.grpBModificarMarca.Controls.Add(this.btnGuardarMarca);
            this.grpBModificarMarca.Controls.Add(this.txtBDescripcionMarca);
            this.grpBModificarMarca.Controls.Add(this.lblDescripcionMarca);
            this.grpBModificarMarca.Controls.Add(this.textBox1);
            this.grpBModificarMarca.Controls.Add(this.lblIDMarca);
            this.grpBModificarMarca.Location = new System.Drawing.Point(8, 8);
            this.grpBModificarMarca.Name = "grpBModificarMarca";
            this.grpBModificarMarca.Size = new System.Drawing.Size(503, 419);
            this.grpBModificarMarca.TabIndex = 0;
            this.grpBModificarMarca.TabStop = false;
            this.grpBModificarMarca.Text = "Modificar Marca";
            // 
            // grpBDatosActualesMarca
            // 
            this.grpBDatosActualesMarca.Controls.Add(this.txtBDescripcionMarcaActual);
            this.grpBDatosActualesMarca.Controls.Add(this.lblDescripcionMarcaActual);
            this.grpBDatosActualesMarca.Controls.Add(this.lblNombreActualMarca);
            this.grpBDatosActualesMarca.Controls.Add(this.txtBNombreActualMarca);
            this.grpBDatosActualesMarca.Location = new System.Drawing.Point(238, 11);
            this.grpBDatosActualesMarca.Name = "grpBDatosActualesMarca";
            this.grpBDatosActualesMarca.Size = new System.Drawing.Size(245, 271);
            this.grpBDatosActualesMarca.TabIndex = 6;
            this.grpBDatosActualesMarca.TabStop = false;
            this.grpBDatosActualesMarca.Text = "Datos actuales";
            // 
            // txtBDescripcionMarcaActual
            // 
            this.txtBDescripcionMarcaActual.BackColor = System.Drawing.SystemColors.Control;
            this.txtBDescripcionMarcaActual.Location = new System.Drawing.Point(9, 70);
            this.txtBDescripcionMarcaActual.Multiline = true;
            this.txtBDescripcionMarcaActual.Name = "txtBDescripcionMarcaActual";
            this.txtBDescripcionMarcaActual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDescripcionMarcaActual.Size = new System.Drawing.Size(223, 195);
            this.txtBDescripcionMarcaActual.TabIndex = 3;
            // 
            // lblDescripcionMarcaActual
            // 
            this.lblDescripcionMarcaActual.AutoSize = true;
            this.lblDescripcionMarcaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDescripcionMarcaActual.Location = new System.Drawing.Point(6, 51);
            this.lblDescripcionMarcaActual.Name = "lblDescripcionMarcaActual";
            this.lblDescripcionMarcaActual.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcionMarcaActual.TabIndex = 2;
            this.lblDescripcionMarcaActual.Text = "Descripción";
            // 
            // lblNombreActualMarca
            // 
            this.lblNombreActualMarca.AutoSize = true;
            this.lblNombreActualMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNombreActualMarca.Location = new System.Drawing.Point(6, 25);
            this.lblNombreActualMarca.Name = "lblNombreActualMarca";
            this.lblNombreActualMarca.Size = new System.Drawing.Size(23, 16);
            this.lblNombreActualMarca.TabIndex = 1;
            this.lblNombreActualMarca.Text = "ID:";
            // 
            // txtBNombreActualMarca
            // 
            this.txtBNombreActualMarca.BackColor = System.Drawing.SystemColors.Control;
            this.txtBNombreActualMarca.Location = new System.Drawing.Point(35, 24);
            this.txtBNombreActualMarca.Name = "txtBNombreActualMarca";
            this.txtBNombreActualMarca.Size = new System.Drawing.Size(78, 20);
            this.txtBNombreActualMarca.TabIndex = 0;
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.BackColor = System.Drawing.Color.Yellow;
            this.btnCancelarMarca.Location = new System.Drawing.Point(279, 366);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(77, 23);
            this.btnCancelarMarca.TabIndex = 5;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = false;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardarMarca.Location = new System.Drawing.Point(132, 366);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(77, 23);
            this.btnGuardarMarca.TabIndex = 4;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = false;
            // 
            // txtBDescripcionMarca
            // 
            this.txtBDescripcionMarca.Location = new System.Drawing.Point(8, 81);
            this.txtBDescripcionMarca.Multiline = true;
            this.txtBDescripcionMarca.Name = "txtBDescripcionMarca";
            this.txtBDescripcionMarca.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDescripcionMarca.Size = new System.Drawing.Size(223, 195);
            this.txtBDescripcionMarca.TabIndex = 3;
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDescripcionMarca.Location = new System.Drawing.Point(6, 62);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(85, 16);
            this.lblDescripcionMarca.TabIndex = 2;
            this.lblDescripcionMarca.Text = "Descripción: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblIDMarca
            // 
            this.lblIDMarca.AutoSize = true;
            this.lblIDMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblIDMarca.Location = new System.Drawing.Point(6, 36);
            this.lblIDMarca.Name = "lblIDMarca";
            this.lblIDMarca.Size = new System.Drawing.Size(23, 16);
            this.lblIDMarca.TabIndex = 0;
            this.lblIDMarca.Text = "ID:";
            // 
            // frmModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(521, 431);
            this.Controls.Add(this.grpBModificarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarMarca";
            this.Text = "frmModificarMarca";
            this.grpBModificarMarca.ResumeLayout(false);
            this.grpBModificarMarca.PerformLayout();
            this.grpBDatosActualesMarca.ResumeLayout(false);
            this.grpBDatosActualesMarca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBModificarMarca;
        private System.Windows.Forms.Label lblIDMarca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescripcionMarca;
        private System.Windows.Forms.TextBox txtBDescripcionMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.GroupBox grpBDatosActualesMarca;
        private System.Windows.Forms.Label lblDescripcionMarcaActual;
        private System.Windows.Forms.Label lblNombreActualMarca;
        private System.Windows.Forms.TextBox txtBNombreActualMarca;
        private System.Windows.Forms.TextBox txtBDescripcionMarcaActual;
    }
}
