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
            this.IDGenerado = new System.Windows.Forms.Label();
            this.lblIDCategoria = new System.Windows.Forms.Label();
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
            this.grpBDetalleCategoria.Controls.Add(this.IDGenerado);
            this.grpBDetalleCategoria.Controls.Add(this.lblIDCategoria);
            this.grpBDetalleCategoria.Controls.Add(this.btnCancelar);
            this.grpBDetalleCategoria.Controls.Add(this.btnGuardar);
            this.grpBDetalleCategoria.Controls.Add(this.txtBDescripcionNuevaCategoria);
            this.grpBDetalleCategoria.Controls.Add(this.lblDescripción);
            this.grpBDetalleCategoria.Location = new System.Drawing.Point(16, 15);
            this.grpBDetalleCategoria.Margin = new System.Windows.Forms.Padding(6);
            this.grpBDetalleCategoria.Name = "grpBDetalleCategoria";
            this.grpBDetalleCategoria.Padding = new System.Windows.Forms.Padding(6);
            this.grpBDetalleCategoria.Size = new System.Drawing.Size(892, 715);
            this.grpBDetalleCategoria.TabIndex = 64;
            this.grpBDetalleCategoria.TabStop = false;
            this.grpBDetalleCategoria.Text = "Detalle de la categoria seleccionada";
            // 
            // IDGenerado
            // 
            this.IDGenerado.AutoSize = true;
            this.IDGenerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDGenerado.Location = new System.Drawing.Point(229, 81);
            this.IDGenerado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IDGenerado.Name = "IDGenerado";
            this.IDGenerado.Size = new System.Drawing.Size(248, 30);
            this.IDGenerado.TabIndex = 60;
            this.IDGenerado.Text = "ID AUTOGENRADO";
            // 
            // lblIDCategoria
            // 
            this.lblIDCategoria.AutoSize = true;
            this.lblIDCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCategoria.Location = new System.Drawing.Point(12, 81);
            this.lblIDCategoria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIDCategoria.Name = "lblIDCategoria";
            this.lblIDCategoria.Size = new System.Drawing.Size(205, 30);
            this.lblIDCategoria.TabIndex = 44;
            this.lblIDCategoria.Text = "ID de Categoria :";
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtBDescripcionNuevaCategoria
            // 
            this.txtBDescripcionNuevaCategoria.Location = new System.Drawing.Point(16, 167);
            this.txtBDescripcionNuevaCategoria.Margin = new System.Windows.Forms.Padding(6);
            this.txtBDescripcionNuevaCategoria.Multiline = true;
            this.txtBDescripcionNuevaCategoria.Name = "txtBDescripcionNuevaCategoria";
            this.txtBDescripcionNuevaCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDescripcionNuevaCategoria.Size = new System.Drawing.Size(864, 456);
            this.txtBDescripcionNuevaCategoria.TabIndex = 52;
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
            // frmNuevaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(928, 738);
            this.Controls.Add(this.grpBDetalleCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaCategoria";
            this.Text = "frmNuevaCategoria";
            this.Load += new System.EventHandler(this.frmNuevaCategoria_Load);
            this.grpBDetalleCategoria.ResumeLayout(false);
            this.grpBDetalleCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBDetalleCategoria;
        private System.Windows.Forms.Label lblIDCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBDescripcionNuevaCategoria;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Label IDGenerado;
    }
}
