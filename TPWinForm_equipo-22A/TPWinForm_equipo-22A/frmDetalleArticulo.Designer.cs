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
            this.spcDetalles = new System.Windows.Forms.SplitContainer();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lbxImagenesLocales = new System.Windows.Forms.ListBox();
            this.txtbPrecio = new System.Windows.Forms.TextBox();
            this.txtbMarca = new System.Windows.Forms.TextBox();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.lblImagenesLocales = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.lbxImagenesUrl = new System.Windows.Forms.ListBox();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.txtbCategoria = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblImagenesUrl = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlInferiorDetalle = new System.Windows.Forms.Panel();
            this.btnCerrarDetalle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDetalleArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcDetalles)).BeginInit();
            this.spcDetalles.Panel1.SuspendLayout();
            this.spcDetalles.Panel2.SuspendLayout();
            this.spcDetalles.SuspendLayout();
            this.pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.pnlDerecho.SuspendLayout();
            this.pnlInferiorDetalle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetalleArticulo
            // 
            this.gbDetalleArticulo.Controls.Add(this.spcDetalles);
            this.gbDetalleArticulo.Controls.Add(this.pnlInferiorDetalle);
            this.gbDetalleArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetalleArticulo.Location = new System.Drawing.Point(0, 0);
            this.gbDetalleArticulo.Name = "gbDetalleArticulo";
            this.gbDetalleArticulo.Size = new System.Drawing.Size(800, 450);
            this.gbDetalleArticulo.TabIndex = 0;
            this.gbDetalleArticulo.TabStop = false;
            this.gbDetalleArticulo.Text = "Detalle del Articulo seleccionado";
            // 
            // spcDetalles
            // 
            this.spcDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcDetalles.Location = new System.Drawing.Point(3, 16);
            this.spcDetalles.Name = "spcDetalles";
            // 
            // spcDetalles.Panel1
            // 
            this.spcDetalles.Panel1.Controls.Add(this.pnlIzquierdo);
            // 
            // spcDetalles.Panel2
            // 
            this.spcDetalles.Panel2.Controls.Add(this.pnlDerecho);
            this.spcDetalles.Size = new System.Drawing.Size(794, 387);
            this.spcDetalles.SplitterDistance = 397;
            this.spcDetalles.TabIndex = 2;
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.Controls.Add(this.pbxImagen);
            this.pnlIzquierdo.Controls.Add(this.lbxImagenesLocales);
            this.pnlIzquierdo.Controls.Add(this.txtbPrecio);
            this.pnlIzquierdo.Controls.Add(this.txtbMarca);
            this.pnlIzquierdo.Controls.Add(this.txtbCodigo);
            this.pnlIzquierdo.Controls.Add(this.lblImagenesLocales);
            this.pnlIzquierdo.Controls.Add(this.lblPrecio);
            this.pnlIzquierdo.Controls.Add(this.lblMarca);
            this.pnlIzquierdo.Controls.Add(this.lblCodigo);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(397, 387);
            this.pnlIzquierdo.TabIndex = 0;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(12, 242);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(120, 84);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 8;
            this.pbxImagen.TabStop = false;
            // 
            // lbxImagenesLocales
            // 
            this.lbxImagenesLocales.FormattingEnabled = true;
            this.lbxImagenesLocales.Location = new System.Drawing.Point(12, 141);
            this.lbxImagenesLocales.Name = "lbxImagenesLocales";
            this.lbxImagenesLocales.Size = new System.Drawing.Size(120, 95);
            this.lbxImagenesLocales.TabIndex = 7;
            this.lbxImagenesLocales.SelectedIndexChanged += new System.EventHandler(this.lbxImagenesLocales_SelectedIndexChanged);
            // 
            // txtbPrecio
            // 
            this.txtbPrecio.Location = new System.Drawing.Point(12, 102);
            this.txtbPrecio.Name = "txtbPrecio";
            this.txtbPrecio.ReadOnly = true;
            this.txtbPrecio.Size = new System.Drawing.Size(182, 20);
            this.txtbPrecio.TabIndex = 6;
            // 
            // txtbMarca
            // 
            this.txtbMarca.Location = new System.Drawing.Point(12, 66);
            this.txtbMarca.Name = "txtbMarca";
            this.txtbMarca.ReadOnly = true;
            this.txtbMarca.Size = new System.Drawing.Size(182, 20);
            this.txtbMarca.TabIndex = 5;
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Location = new System.Drawing.Point(12, 26);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.ReadOnly = true;
            this.txtbCodigo.Size = new System.Drawing.Size(182, 20);
            this.txtbCodigo.TabIndex = 4;
            // 
            // lblImagenesLocales
            // 
            this.lblImagenesLocales.AutoSize = true;
            this.lblImagenesLocales.Location = new System.Drawing.Point(9, 125);
            this.lblImagenesLocales.Name = "lblImagenesLocales";
            this.lblImagenesLocales.Size = new System.Drawing.Size(93, 13);
            this.lblImagenesLocales.TabIndex = 3;
            this.lblImagenesLocales.Text = "Imagenes Locales";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(9, 89);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(9, 50);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(9, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.Controls.Add(this.lbxImagenesUrl);
            this.pnlDerecho.Controls.Add(this.txtbDescripcion);
            this.pnlDerecho.Controls.Add(this.txtbCategoria);
            this.pnlDerecho.Controls.Add(this.txtbNombre);
            this.pnlDerecho.Controls.Add(this.lblImagenesUrl);
            this.pnlDerecho.Controls.Add(this.lblCategoria);
            this.pnlDerecho.Controls.Add(this.lblDescripcion);
            this.pnlDerecho.Controls.Add(this.lblNombre);
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDerecho.Location = new System.Drawing.Point(0, 0);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Size = new System.Drawing.Size(393, 387);
            this.pnlDerecho.TabIndex = 0;
            // 
            // lbxImagenesUrl
            // 
            this.lbxImagenesUrl.FormattingEnabled = true;
            this.lbxImagenesUrl.Location = new System.Drawing.Point(16, 181);
            this.lbxImagenesUrl.Name = "lbxImagenesUrl";
            this.lbxImagenesUrl.Size = new System.Drawing.Size(120, 95);
            this.lbxImagenesUrl.TabIndex = 7;
            this.lbxImagenesUrl.SelectedIndexChanged += new System.EventHandler(this.lbxImagenesUrl_SelectedIndexChanged);
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(16, 105);
            this.txtbDescripcion.Multiline = true;
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.ReadOnly = true;
            this.txtbDescripcion.Size = new System.Drawing.Size(182, 57);
            this.txtbDescripcion.TabIndex = 6;
            // 
            // txtbCategoria
            // 
            this.txtbCategoria.Location = new System.Drawing.Point(16, 66);
            this.txtbCategoria.Name = "txtbCategoria";
            this.txtbCategoria.ReadOnly = true;
            this.txtbCategoria.Size = new System.Drawing.Size(182, 20);
            this.txtbCategoria.TabIndex = 5;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(16, 26);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.ReadOnly = true;
            this.txtbNombre.Size = new System.Drawing.Size(182, 20);
            this.txtbNombre.TabIndex = 4;
            // 
            // lblImagenesUrl
            // 
            this.lblImagenesUrl.AutoSize = true;
            this.lblImagenesUrl.Location = new System.Drawing.Point(13, 165);
            this.lblImagenesUrl.Name = "lblImagenesUrl";
            this.lblImagenesUrl.Size = new System.Drawing.Size(97, 13);
            this.lblImagenesUrl.TabIndex = 3;
            this.lblImagenesUrl.Text = "Imagenes Por URL";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(13, 50);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 89);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
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
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            this.gbDetalleArticulo.ResumeLayout(false);
            this.spcDetalles.Panel1.ResumeLayout(false);
            this.spcDetalles.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcDetalles)).EndInit();
            this.spcDetalles.ResumeLayout(false);
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.pnlDerecho.ResumeLayout(false);
            this.pnlDerecho.PerformLayout();
            this.pnlInferiorDetalle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalleArticulo;
        private System.Windows.Forms.Panel pnlInferiorDetalle;
        private System.Windows.Forms.Button btnCerrarDetalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer spcDetalles;
        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.Label lblImagenesLocales;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.Label lblImagenesUrl;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.ListBox lbxImagenesLocales;
        private System.Windows.Forms.TextBox txtbPrecio;
        private System.Windows.Forms.TextBox txtbMarca;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.ListBox lbxImagenesUrl;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.TextBox txtbCategoria;
        private System.Windows.Forms.TextBox txtbNombre;
    }
}