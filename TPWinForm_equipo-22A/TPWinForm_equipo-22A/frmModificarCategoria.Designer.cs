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
            this.grpBDetalleArticulo.Controls.Add(this.lblNombre);
            this.grpBDetalleArticulo.Controls.Add(this.btnCancelar);
            this.grpBDetalleArticulo.Controls.Add(this.btnGuardar);
            this.grpBDetalleArticulo.Controls.Add(this.txtBDescripción);
            this.grpBDetalleArticulo.Controls.Add(this.lblDescripción);
            this.grpBDetalleArticulo.Controls.Add(this.txtBNombre);
            this.grpBDetalleArticulo.Location = new System.Drawing.Point(15, 15);
            this.grpBDetalleArticulo.Margin = new System.Windows.Forms.Padding(6);
            this.grpBDetalleArticulo.Name = "grpBDetalleArticulo";
            this.grpBDetalleArticulo.Padding = new System.Windows.Forms.Padding(6);
            this.grpBDetalleArticulo.Size = new System.Drawing.Size(892, 715);
            this.grpBDetalleArticulo.TabIndex = 63;
            this.grpBDetalleArticulo.TabStop = false;
            this.grpBDetalleArticulo.Text = "Detalle de la categoria seleccionada";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 81);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(205, 30);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "ID de Categoria :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(558, 635);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 44);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(264, 635);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 44);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtBDescripción
            // 
            this.txtBDescripción.Location = new System.Drawing.Point(17, 167);
            this.txtBDescripción.Margin = new System.Windows.Forms.Padding(6);
            this.txtBDescripción.Multiline = true;
            this.txtBDescripción.Name = "txtBDescripción";
            this.txtBDescripción.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDescripción.Size = new System.Drawing.Size(863, 456);
            this.txtBDescripción.TabIndex = 52;
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.Location = new System.Drawing.Point(12, 131);
            this.lblDescripción.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(162, 30);
            this.lblDescripción.TabIndex = 45;
            this.lblDescripción.Text = "Descripción :";
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(198, 83);
            this.txtBNombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(332, 31);
            this.txtBNombre.TabIndex = 51;
            // 
            // frmModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(928, 738);
            this.Controls.Add(this.grpBDetalleArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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