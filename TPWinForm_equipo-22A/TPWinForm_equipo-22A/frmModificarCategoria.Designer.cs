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
            this.NuevoIDCategoria = new System.Windows.Forms.Label();
            this.grpBDatosActualesMarca = new System.Windows.Forms.GroupBox();
            this.ActualIDCategoria = new System.Windows.Forms.Label();
            this.txtBDescripcionCategoriaActual = new System.Windows.Forms.TextBox();
            this.lblDescripcionCategoriaActual = new System.Windows.Forms.Label();
            this.lblIDActualCategoria = new System.Windows.Forms.Label();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.txtBDescripcionNuevaCategoria = new System.Windows.Forms.TextBox();
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.lblNuevoIDCategoria = new System.Windows.Forms.Label();
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
            this.grpBModificarCategoria.Controls.Add(this.NuevoIDCategoria);
            this.grpBModificarCategoria.Controls.Add(this.grpBDatosActualesMarca);
            this.grpBModificarCategoria.Controls.Add(this.btnCancelarCategoria);
            this.grpBModificarCategoria.Controls.Add(this.btnGuardarCategoria);
            this.grpBModificarCategoria.Controls.Add(this.txtBDescripcionNuevaCategoria);
            this.grpBModificarCategoria.Controls.Add(this.lblDescripcionCategoria);
            this.grpBModificarCategoria.Controls.Add(this.lblNuevoIDCategoria);
            this.grpBModificarCategoria.Location = new System.Drawing.Point(16, 15);
            this.grpBModificarCategoria.Margin = new System.Windows.Forms.Padding(6);
            this.grpBModificarCategoria.Name = "grpBModificarCategoria";
            this.grpBModificarCategoria.Padding = new System.Windows.Forms.Padding(6);
            this.grpBModificarCategoria.Size = new System.Drawing.Size(1006, 806);
            this.grpBModificarCategoria.TabIndex = 1;
            this.grpBModificarCategoria.TabStop = false;
            this.grpBModificarCategoria.Text = "Modificar Categoria";
            // 
            // NuevoIDCategoria
            // 
            this.NuevoIDCategoria.AutoSize = true;
            this.NuevoIDCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NuevoIDCategoria.Location = new System.Drawing.Point(69, 69);
            this.NuevoIDCategoria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NuevoIDCategoria.Name = "NuevoIDCategoria";
            this.NuevoIDCategoria.Size = new System.Drawing.Size(161, 30);
            this.NuevoIDCategoria.TabIndex = 7;
            this.NuevoIDCategoria.Text = "NUMERO ID";
            // 
            // grpBDatosActualesMarca
            // 
            this.grpBDatosActualesMarca.Controls.Add(this.ActualIDCategoria);
            this.grpBDatosActualesMarca.Controls.Add(this.txtBDescripcionCategoriaActual);
            this.grpBDatosActualesMarca.Controls.Add(this.lblDescripcionCategoriaActual);
            this.grpBDatosActualesMarca.Controls.Add(this.lblIDActualCategoria);
            this.grpBDatosActualesMarca.Location = new System.Drawing.Point(476, 21);
            this.grpBDatosActualesMarca.Margin = new System.Windows.Forms.Padding(6);
            this.grpBDatosActualesMarca.Name = "grpBDatosActualesMarca";
            this.grpBDatosActualesMarca.Padding = new System.Windows.Forms.Padding(6);
            this.grpBDatosActualesMarca.Size = new System.Drawing.Size(490, 521);
            this.grpBDatosActualesMarca.TabIndex = 6;
            this.grpBDatosActualesMarca.TabStop = false;
            this.grpBDatosActualesMarca.Text = "Datos actuales";
            // 
            // ActualIDCategoria
            // 
            this.ActualIDCategoria.AutoSize = true;
            this.ActualIDCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ActualIDCategoria.Location = new System.Drawing.Point(69, 48);
            this.ActualIDCategoria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ActualIDCategoria.Name = "ActualIDCategoria";
            this.ActualIDCategoria.Size = new System.Drawing.Size(161, 30);
            this.ActualIDCategoria.TabIndex = 4;
            this.ActualIDCategoria.Text = "NUMERO ID";
            // 
            // txtBDescripcionCategoriaActual
            // 
            this.txtBDescripcionCategoriaActual.BackColor = System.Drawing.SystemColors.Control;
            this.txtBDescripcionCategoriaActual.Location = new System.Drawing.Point(18, 135);
            this.txtBDescripcionCategoriaActual.Margin = new System.Windows.Forms.Padding(6);
            this.txtBDescripcionCategoriaActual.Multiline = true;
            this.txtBDescripcionCategoriaActual.Name = "txtBDescripcionCategoriaActual";
            this.txtBDescripcionCategoriaActual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDescripcionCategoriaActual.Size = new System.Drawing.Size(442, 371);
            this.txtBDescripcionCategoriaActual.TabIndex = 3;
            // 
            // lblDescripcionCategoriaActual
            // 
            this.lblDescripcionCategoriaActual.AutoSize = true;
            this.lblDescripcionCategoriaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDescripcionCategoriaActual.Location = new System.Drawing.Point(12, 98);
            this.lblDescripcionCategoriaActual.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcionCategoriaActual.Name = "lblDescripcionCategoriaActual";
            this.lblDescripcionCategoriaActual.Size = new System.Drawing.Size(148, 30);
            this.lblDescripcionCategoriaActual.TabIndex = 2;
            this.lblDescripcionCategoriaActual.Text = "Descripción";
            // 
            // lblIDActualCategoria
            // 
            this.lblIDActualCategoria.AutoSize = true;
            this.lblIDActualCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblIDActualCategoria.Location = new System.Drawing.Point(12, 48);
            this.lblIDActualCategoria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIDActualCategoria.Name = "lblIDActualCategoria";
            this.lblIDActualCategoria.Size = new System.Drawing.Size(45, 30);
            this.lblIDActualCategoria.TabIndex = 1;
            this.lblIDActualCategoria.Text = "ID:";
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarCategoria.Location = new System.Drawing.Point(558, 704);
            this.btnCancelarCategoria.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(154, 44);
            this.btnCancelarCategoria.TabIndex = 5;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarCategoria.Location = new System.Drawing.Point(264, 704);
            this.btnGuardarCategoria.Margin = new System.Windows.Forms.Padding(6);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(154, 44);
            this.btnGuardarCategoria.TabIndex = 4;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = false;
            // 
            // txtBDescripcionNuevaCategoria
            // 
            this.txtBDescripcionNuevaCategoria.Location = new System.Drawing.Point(16, 156);
            this.txtBDescripcionNuevaCategoria.Margin = new System.Windows.Forms.Padding(6);
            this.txtBDescripcionNuevaCategoria.Multiline = true;
            this.txtBDescripcionNuevaCategoria.Name = "txtBDescripcionNuevaCategoria";
            this.txtBDescripcionNuevaCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDescripcionNuevaCategoria.Size = new System.Drawing.Size(442, 371);
            this.txtBDescripcionNuevaCategoria.TabIndex = 3;
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(12, 119);
            this.lblDescripcionCategoria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(162, 30);
            this.lblDescripcionCategoria.TabIndex = 2;
            this.lblDescripcionCategoria.Text = "Descripción: ";
            // 
            // lblNuevoIDCategoria
            // 
            this.lblNuevoIDCategoria.AutoSize = true;
            this.lblNuevoIDCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNuevoIDCategoria.Location = new System.Drawing.Point(12, 69);
            this.lblNuevoIDCategoria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNuevoIDCategoria.Name = "lblNuevoIDCategoria";
            this.lblNuevoIDCategoria.Size = new System.Drawing.Size(45, 30);
            this.lblNuevoIDCategoria.TabIndex = 0;
            this.lblNuevoIDCategoria.Text = "ID:";
            // 
            // frmModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1042, 829);
            this.Controls.Add(this.grpBModificarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lblIDActualCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.TextBox txtBDescripcionNuevaCategoria;
        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.Label lblNuevoIDCategoria;
        private System.Windows.Forms.Label NuevoIDCategoria;
        private System.Windows.Forms.Label ActualIDCategoria;
    }
}