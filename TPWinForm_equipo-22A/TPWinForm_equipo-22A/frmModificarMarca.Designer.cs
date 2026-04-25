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
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.txtBDescripcionMarca = new System.Windows.Forms.TextBox();
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.grpBModificarMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBModificarMarca
            // 
            this.grpBModificarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBModificarMarca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBModificarMarca.Controls.Add(this.btnCancelarMarca);
            this.grpBModificarMarca.Controls.Add(this.btnGuardarMarca);
            this.grpBModificarMarca.Controls.Add(this.txtBDescripcionMarca);
            this.grpBModificarMarca.Controls.Add(this.lblDescripcionMarca);
            this.grpBModificarMarca.Location = new System.Drawing.Point(8, 8);
            this.grpBModificarMarca.Name = "grpBModificarMarca";
            this.grpBModificarMarca.Size = new System.Drawing.Size(446, 372);
            this.grpBModificarMarca.TabIndex = 0;
            this.grpBModificarMarca.TabStop = false;
            this.grpBModificarMarca.Text = "Modificar Marca";
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.BackColor = System.Drawing.Color.Yellow;
            this.btnCancelarMarca.Location = new System.Drawing.Point(279, 330);
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
            this.btnGuardarMarca.Location = new System.Drawing.Point(132, 330);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(77, 23);
            this.btnGuardarMarca.TabIndex = 4;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = false;
            // 
            // txtBDescripcionMarca
            // 
            this.txtBDescripcionMarca.Location = new System.Drawing.Point(8, 58);
            this.txtBDescripcionMarca.Multiline = true;
            this.txtBDescripcionMarca.Name = "txtBDescripcionMarca";
            this.txtBDescripcionMarca.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDescripcionMarca.Size = new System.Drawing.Size(434, 239);
            this.txtBDescripcionMarca.TabIndex = 3;
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDescripcionMarca.Location = new System.Drawing.Point(6, 39);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(85, 16);
            this.lblDescripcionMarca.TabIndex = 2;
            this.lblDescripcionMarca.Text = "Descripción: ";
            // 
            // frmModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(464, 384);
            this.Controls.Add(this.grpBModificarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarMarca";
            this.Text = "frmModificarMarca";
            this.grpBModificarMarca.ResumeLayout(false);
            this.grpBModificarMarca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBModificarMarca;
        private System.Windows.Forms.Label lblDescripcionMarca;
        private System.Windows.Forms.TextBox txtBDescripcionMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnGuardarMarca;
    }
}
