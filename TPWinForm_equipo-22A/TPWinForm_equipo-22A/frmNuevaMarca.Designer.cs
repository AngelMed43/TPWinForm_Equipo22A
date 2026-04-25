namespace TPWinForm_equipo_22A
{
    partial class frmNuevaMarca
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
            this.grpBAgregarMarca = new System.Windows.Forms.GroupBox();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.txtBDescripcionNuevaMarca = new System.Windows.Forms.TextBox();
            this.lblAgregarDescripcionMarca = new System.Windows.Forms.Label();
            this.grpBAgregarMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBAgregarMarca
            // 
            this.grpBAgregarMarca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBAgregarMarca.Controls.Add(this.btnCancelarMarca);
            this.grpBAgregarMarca.Controls.Add(this.btnGuardarMarca);
            this.grpBAgregarMarca.Controls.Add(this.txtBDescripcionNuevaMarca);
            this.grpBAgregarMarca.Controls.Add(this.lblAgregarDescripcionMarca);
            this.grpBAgregarMarca.Location = new System.Drawing.Point(8, 8);
            this.grpBAgregarMarca.Name = "grpBAgregarMarca";
            this.grpBAgregarMarca.Size = new System.Drawing.Size(446, 372);
            this.grpBAgregarMarca.TabIndex = 0;
            this.grpBAgregarMarca.TabStop = false;
            this.grpBAgregarMarca.Text = "Agregar Marca";
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
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // txtBDescripcionNuevaMarca
            // 
            this.txtBDescripcionNuevaMarca.Location = new System.Drawing.Point(8, 58);
            this.txtBDescripcionNuevaMarca.Multiline = true;
            this.txtBDescripcionNuevaMarca.Name = "txtBDescripcionNuevaMarca";
            this.txtBDescripcionNuevaMarca.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDescripcionNuevaMarca.Size = new System.Drawing.Size(434, 239);
            this.txtBDescripcionNuevaMarca.TabIndex = 3;
            // 
            // lblAgregarDescripcionMarca
            // 
            this.lblAgregarDescripcionMarca.AutoSize = true;
            this.lblAgregarDescripcionMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblAgregarDescripcionMarca.Location = new System.Drawing.Point(6, 39);
            this.lblAgregarDescripcionMarca.Name = "lblAgregarDescripcionMarca";
            this.lblAgregarDescripcionMarca.Size = new System.Drawing.Size(82, 16);
            this.lblAgregarDescripcionMarca.TabIndex = 1;
            this.lblAgregarDescripcionMarca.Text = "Descripción:";
            // 
            // frmNuevaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(464, 384);
            this.Controls.Add(this.grpBAgregarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaMarca";
            this.Text = "frmNuevaMarca";
            this.Load += new System.EventHandler(this.frmNuevaMarca_Load);
            this.grpBAgregarMarca.ResumeLayout(false);
            this.grpBAgregarMarca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBAgregarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.TextBox txtBDescripcionNuevaMarca;
        private System.Windows.Forms.Label lblAgregarDescripcionMarca;
    }
}
