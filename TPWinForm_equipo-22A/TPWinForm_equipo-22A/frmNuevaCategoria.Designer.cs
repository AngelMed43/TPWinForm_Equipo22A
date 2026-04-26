namespace TPWinForm_equipo_22A
{
    partial class frmNuevaCategoria
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
            this.grpBDetalleCategoria = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtBDescripcionNuevaCategoria = new System.Windows.Forms.TextBox();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.grpBDetalleCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBDetalleCategoria
            // 
            this.grpBDetalleCategoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBDetalleCategoria.Controls.Add(this.btnCancelar);
            this.grpBDetalleCategoria.Controls.Add(this.btnGuardar);
            this.grpBDetalleCategoria.Controls.Add(this.txtBDescripcionNuevaCategoria);
            this.grpBDetalleCategoria.Controls.Add(this.lblDescripción);
            this.grpBDetalleCategoria.Location = new System.Drawing.Point(8, 8);
            this.grpBDetalleCategoria.Name = "grpBDetalleCategoria";
            this.grpBDetalleCategoria.Size = new System.Drawing.Size(446, 372);
            this.grpBDetalleCategoria.TabIndex = 64;
            this.grpBDetalleCategoria.TabStop = false;
            this.grpBDetalleCategoria.Text = "Detalle de la categoria seleccionada";
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtBDescripcionNuevaCategoria
            // 
            this.txtBDescripcionNuevaCategoria.Location = new System.Drawing.Point(8, 58);
            this.txtBDescripcionNuevaCategoria.Multiline = true;
            this.txtBDescripcionNuevaCategoria.Name = "txtBDescripcionNuevaCategoria";
            this.txtBDescripcionNuevaCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDescripcionNuevaCategoria.Size = new System.Drawing.Size(434, 239);
            this.txtBDescripcionNuevaCategoria.TabIndex = 52;
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.Location = new System.Drawing.Point(6, 39);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(82, 16);
            this.lblDescripción.TabIndex = 45;
            this.lblDescripción.Text = "Descripción:";
            // 
            // frmNuevaCategoria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(464, 384);
            this.Controls.Add(this.grpBDetalleCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNuevaCategoria";
            this.Text = "frmNuevaCategoria";
            this.Load += new System.EventHandler(this.frmNuevaCategoria_Load);
            this.grpBDetalleCategoria.ResumeLayout(false);
            this.grpBDetalleCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBDetalleCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBDescripcionNuevaCategoria;
        private System.Windows.Forms.Label lblDescripción;
    }
}
