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
            this.grpBDetalleArticulo = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtBDescripción = new System.Windows.Forms.TextBox();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.grpBDetalleArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBDetalleArticulo
            // 
            this.grpBDetalleArticulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBDetalleArticulo.Controls.Add(this.lblNombre);
            this.grpBDetalleArticulo.Controls.Add(this.btnCancelar);
            this.grpBDetalleArticulo.Controls.Add(this.btnGuardar);
            this.grpBDetalleArticulo.Controls.Add(this.txtBDescripción);
            this.grpBDetalleArticulo.Controls.Add(this.lblDescripción);
            this.grpBDetalleArticulo.Controls.Add(this.txtBNombre);
            this.grpBDetalleArticulo.Location = new System.Drawing.Point(8, 8);
            this.grpBDetalleArticulo.Name = "grpBDetalleArticulo";
            this.grpBDetalleArticulo.Size = new System.Drawing.Size(446, 372);
            this.grpBDetalleArticulo.TabIndex = 63;
            this.grpBDetalleArticulo.TabStop = false;
            this.grpBDetalleArticulo.Text = "Detalle de la categoria seleccionada";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 16);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "ID de Categoria :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(279, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 23);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(132, 330);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 23);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtBDescripción
            // 
            this.txtBDescripción.Location = new System.Drawing.Point(8, 87);
            this.txtBDescripción.Multiline = true;
            this.txtBDescripción.Name = "txtBDescripción";
            this.txtBDescripción.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDescripción.Size = new System.Drawing.Size(434, 239);
            this.txtBDescripción.TabIndex = 52;
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.Location = new System.Drawing.Point(6, 68);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(85, 16);
            this.lblDescripción.TabIndex = 45;
            this.lblDescripción.Text = "Descripción :";
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(99, 43);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(168, 20);
            this.txtBNombre.TabIndex = 51;
            // 
            // frmModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(464, 384);
            this.Controls.Add(this.grpBDetalleArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmModificarCategoria";
            this.Text = "frmModificarClase";
            this.grpBDetalleArticulo.ResumeLayout(false);
            this.grpBDetalleArticulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBDetalleArticulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBDescripción;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.TextBox txtBNombre;
    }
}