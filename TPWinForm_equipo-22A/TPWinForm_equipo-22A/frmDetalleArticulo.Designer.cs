namespace TPWinForm_equipo_22A
{
    partial class frmDetalleArticulo
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
            this.gbDetalleArticulo = new System.Windows.Forms.GroupBox();
            this.pnlInferiorDetalle = new System.Windows.Forms.Panel();
            this.btnCerrarDetalle = new System.Windows.Forms.Button();
            this.dgvDetallesArticulo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDetalleArticulo.SuspendLayout();
            this.pnlInferiorDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesArticulo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetalleArticulo
            // 
            this.gbDetalleArticulo.Controls.Add(this.pnlInferiorDetalle);
            this.gbDetalleArticulo.Controls.Add(this.dgvDetallesArticulo);
            this.gbDetalleArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetalleArticulo.Location = new System.Drawing.Point(0, 0);
            this.gbDetalleArticulo.Name = "gbDetalleArticulo";
            this.gbDetalleArticulo.Size = new System.Drawing.Size(800, 450);
            this.gbDetalleArticulo.TabIndex = 0;
            this.gbDetalleArticulo.TabStop = false;
            this.gbDetalleArticulo.Text = "Detalle del Articulo seleccionado";
            // 
            // pnlInferiorDetalle
            // 
            this.pnlInferiorDetalle.Controls.Add(this.btnCerrarDetalle);
            this.pnlInferiorDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferiorDetalle.Location = new System.Drawing.Point(3, 403);
            this.pnlInferiorDetalle.Name = "pnlInferiorDetalle";
            this.pnlInferiorDetalle.Size = new System.Drawing.Size(794, 44);
            this.pnlInferiorDetalle.TabIndex = 1;
            // 
            // btnCerrarDetalle
            // 
            this.btnCerrarDetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrarDetalle.Location = new System.Drawing.Point(359, 11);
            this.btnCerrarDetalle.Name = "btnCerrarDetalle";
            this.btnCerrarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarDetalle.TabIndex = 0;
            this.btnCerrarDetalle.Text = "Cerrar";
            this.btnCerrarDetalle.UseVisualStyleBackColor = true;
            this.btnCerrarDetalle.Click += new System.EventHandler(this.btnCerrarDetalle_Click);
            // 
            // dgvDetallesArticulo
            // 
            this.dgvDetallesArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetallesArticulo.Location = new System.Drawing.Point(3, 16);
            this.dgvDetallesArticulo.Name = "dgvDetallesArticulo";
            this.dgvDetallesArticulo.Size = new System.Drawing.Size(794, 431);
            this.dgvDetallesArticulo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbDetalleArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalleArticulo";
            this.gbDetalleArticulo.ResumeLayout(false);
            this.pnlInferiorDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesArticulo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalleArticulo;
        private System.Windows.Forms.DataGridView dgvDetallesArticulo;
        private System.Windows.Forms.Panel pnlInferiorDetalle;
        private System.Windows.Forms.Button btnCerrarDetalle;
        private System.Windows.Forms.Panel panel1;
    }
}