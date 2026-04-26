namespace TPWinForm_equipo_22A
{
    partial class frmModificarCategoria
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
            this.grpBModificarCategoria = new System.Windows.Forms.GroupBox();
            this.grpBDatosActualesMarca = new System.Windows.Forms.GroupBox();
            this.txtBDescripcionCategoriaActual = new System.Windows.Forms.TextBox();
            this.lblDescripcionCategoriaActual = new System.Windows.Forms.Label();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.txtBDescripcionNuevaCategoria = new System.Windows.Forms.TextBox();
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.grpBModificarCategoria.SuspendLayout();
            this.grpBDatosActualesMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBModificarCategoria
            // 
            this.grpBModificarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBModificarCategoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBModificarCategoria.Controls.Add(this.grpBDatosActualesMarca);
            this.grpBModificarCategoria.Controls.Add(this.btnCancelarCategoria);
            this.grpBModificarCategoria.Controls.Add(this.btnGuardarCategoria);
            this.grpBModificarCategoria.Controls.Add(this.txtBDescripcionNuevaCategoria);
            this.grpBModificarCategoria.Controls.Add(this.lblDescripcionCategoria);
            this.grpBModificarCategoria.Location = new System.Drawing.Point(8, 8);
            this.grpBModificarCategoria.Name = "grpBModificarCategoria";
            this.grpBModificarCategoria.Size = new System.Drawing.Size(503, 419);
            this.grpBModificarCategoria.TabIndex = 1;
            this.grpBModificarCategoria.TabStop = false;
            this.grpBModificarCategoria.Text = "Modificar Categoria";
            // 
            // grpBDatosActualesMarca
            // 
            this.grpBDatosActualesMarca.Controls.Add(this.txtBDescripcionCategoriaActual);
            this.grpBDatosActualesMarca.Controls.Add(this.lblDescripcionCategoriaActual);
            this.grpBDatosActualesMarca.Location = new System.Drawing.Point(238, 11);
            this.grpBDatosActualesMarca.Name = "grpBDatosActualesMarca";
            this.grpBDatosActualesMarca.Size = new System.Drawing.Size(245, 271);
            this.grpBDatosActualesMarca.TabIndex = 6;
            this.grpBDatosActualesMarca.TabStop = false;
            this.grpBDatosActualesMarca.Text = "Datos actuales";
            // 
            // txtBDescripcionCategoriaActual
            // 
            this.txtBDescripcionCategoriaActual.BackColor = System.Drawing.SystemColors.Control;
            this.txtBDescripcionCategoriaActual.Location = new System.Drawing.Point(9, 70);
            this.txtBDescripcionCategoriaActual.Multiline = true;
            this.txtBDescripcionCategoriaActual.Name = "txtBDescripcionCategoriaActual";
            this.txtBDescripcionCategoriaActual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDescripcionCategoriaActual.Size = new System.Drawing.Size(223, 195);
            this.txtBDescripcionCategoriaActual.TabIndex = 3;
            // 
            // lblDescripcionCategoriaActual
            // 
            this.lblDescripcionCategoriaActual.AutoSize = true;
            this.lblDescripcionCategoriaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDescripcionCategoriaActual.Location = new System.Drawing.Point(6, 51);
            this.lblDescripcionCategoriaActual.Name = "lblDescripcionCategoriaActual";
            this.lblDescripcionCategoriaActual.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcionCategoriaActual.TabIndex = 2;
            this.lblDescripcionCategoriaActual.Text = "Descripción";
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarCategoria.Location = new System.Drawing.Point(279, 366);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(77, 23);
            this.btnCancelarCategoria.TabIndex = 5;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarCategoria.Location = new System.Drawing.Point(132, 366);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(77, 23);
            this.btnGuardarCategoria.TabIndex = 4;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = false;
            // 
            // txtBDescripcionNuevaCategoria
            // 
            this.txtBDescripcionNuevaCategoria.Location = new System.Drawing.Point(8, 81);
            this.txtBDescripcionNuevaCategoria.Multiline = true;
            this.txtBDescripcionNuevaCategoria.Name = "txtBDescripcionNuevaCategoria";
            this.txtBDescripcionNuevaCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDescripcionNuevaCategoria.Size = new System.Drawing.Size(223, 195);
            this.txtBDescripcionNuevaCategoria.TabIndex = 3;
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(6, 62);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(85, 16);
            this.lblDescripcionCategoria.TabIndex = 2;
            this.lblDescripcionCategoria.Text = "Descripción: ";
            // 
            // frmModificarCategoria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(521, 431);
            this.Controls.Add(this.grpBModificarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmModificarCategoria";
            this.Text = "frmModificarClase";
            this.Load += new System.EventHandler(this.frmModificarCategoria_Load);
            this.grpBModificarCategoria.ResumeLayout(false);
            this.grpBModificarCategoria.PerformLayout();
            this.grpBDatosActualesMarca.ResumeLayout(false);
            this.grpBDatosActualesMarca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBModificarCategoria;
        private System.Windows.Forms.GroupBox grpBDatosActualesMarca;
        private System.Windows.Forms.TextBox txtBDescripcionCategoriaActual;
        private System.Windows.Forms.Label lblDescripcionCategoriaActual;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.TextBox txtBDescripcionNuevaCategoria;
        private System.Windows.Forms.Label lblDescripcionCategoria;
    }
}
