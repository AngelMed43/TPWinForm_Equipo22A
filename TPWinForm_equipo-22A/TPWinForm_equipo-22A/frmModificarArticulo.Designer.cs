namespace TPWinForm_equipo_22A
{
    partial class frmModificarArticulo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpbDetalleActual = new System.Windows.Forms.GroupBox();
            this.txtbPrecioActual = new System.Windows.Forms.TextBox();
            this.txtbCategoriaActual = new System.Windows.Forms.TextBox();
            this.txtbMarcaActual = new System.Windows.Forms.TextBox();
            this.txtbDescripciónActual = new System.Windows.Forms.TextBox();
            this.txtbNombreActual = new System.Windows.Forms.TextBox();
            this.txtbCódigoActual = new System.Windows.Forms.TextBox();
            this.lblCódigoActual = new System.Windows.Forms.Label();
            this.lblPrecioActual = new System.Windows.Forms.Label();
            this.lblNombreActual = new System.Windows.Forms.Label();
            this.lblCategoriaActual = new System.Windows.Forms.Label();
            this.lblDescripciónActual = new System.Windows.Forms.Label();
            this.lblMarcaActual = new System.Windows.Forms.Label();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBPrecio = new System.Windows.Forms.TextBox();
            this.cbCategoría = new System.Windows.Forms.ComboBox();
            this.txtBDescripción = new System.Windows.Forms.TextBox();
            this.btnDeleteImagen = new System.Windows.Forms.Button();
            this.lbxImagenes = new System.Windows.Forms.ListBox();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.btnAddImagen = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBCódigo = new System.Windows.Forms.TextBox();
            this.lblCategoría = new System.Windows.Forms.Label();
            this.lblImagenes = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBDetalleArticulo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpbDetalleActual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBDetalleArticulo
            // 
            this.grpBDetalleArticulo.AutoSize = true;
            this.grpBDetalleArticulo.Controls.Add(this.panel2);
            this.grpBDetalleArticulo.Controls.Add(this.grpbDetalleActual);
            this.grpBDetalleArticulo.Controls.Add(this.lblCódigo);
            this.grpBDetalleArticulo.Controls.Add(this.cbMarca);
            this.grpBDetalleArticulo.Controls.Add(this.lblNombre);
            this.grpBDetalleArticulo.Controls.Add(this.txtBPrecio);
            this.grpBDetalleArticulo.Controls.Add(this.cbCategoría);
            this.grpBDetalleArticulo.Controls.Add(this.txtBDescripción);
            this.grpBDetalleArticulo.Controls.Add(this.btnDeleteImagen);
            this.grpBDetalleArticulo.Controls.Add(this.lbxImagenes);
            this.grpBDetalleArticulo.Controls.Add(this.lblDescripción);
            this.grpBDetalleArticulo.Controls.Add(this.txtBNombre);
            this.grpBDetalleArticulo.Controls.Add(this.btnAddImagen);
            this.grpBDetalleArticulo.Controls.Add(this.pbxImagen);
            this.grpBDetalleArticulo.Controls.Add(this.lblMarca);
            this.grpBDetalleArticulo.Controls.Add(this.txtBCódigo);
            this.grpBDetalleArticulo.Controls.Add(this.lblCategoría);
            this.grpBDetalleArticulo.Controls.Add(this.lblImagenes);
            this.grpBDetalleArticulo.Controls.Add(this.lblPrecio);
            this.grpBDetalleArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBDetalleArticulo.Location = new System.Drawing.Point(0, 0);
            this.grpBDetalleArticulo.Name = "grpBDetalleArticulo";
            this.grpBDetalleArticulo.Size = new System.Drawing.Size(620, 553);
            this.grpBDetalleArticulo.TabIndex = 64;
            this.grpBDetalleArticulo.TabStop = false;
            this.grpBDetalleArticulo.Text = "Modificar datos del Articulo ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 34);
            this.panel2.TabIndex = 65;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.Location = new System.Drawing.Point(168, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.Color.Yellow;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(350, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpbDetalleActual
            // 
            this.grpbDetalleActual.Controls.Add(this.txtbPrecioActual);
            this.grpbDetalleActual.Controls.Add(this.txtbCategoriaActual);
            this.grpbDetalleActual.Controls.Add(this.txtbMarcaActual);
            this.grpbDetalleActual.Controls.Add(this.txtbDescripciónActual);
            this.grpbDetalleActual.Controls.Add(this.txtbNombreActual);
            this.grpbDetalleActual.Controls.Add(this.txtbCódigoActual);
            this.grpbDetalleActual.Controls.Add(this.lblCódigoActual);
            this.grpbDetalleActual.Controls.Add(this.lblPrecioActual);
            this.grpbDetalleActual.Controls.Add(this.lblNombreActual);
            this.grpbDetalleActual.Controls.Add(this.lblCategoriaActual);
            this.grpbDetalleActual.Controls.Add(this.lblDescripciónActual);
            this.grpbDetalleActual.Controls.Add(this.lblMarcaActual);
            this.grpbDetalleActual.Location = new System.Drawing.Point(226, 12);
            this.grpbDetalleActual.Name = "grpbDetalleActual";
            this.grpbDetalleActual.Size = new System.Drawing.Size(351, 224);
            this.grpbDetalleActual.TabIndex = 68;
            this.grpbDetalleActual.TabStop = false;
            this.grpbDetalleActual.Text = "Datos actuales";
            // 
            // txtbPrecioActual
            // 
            this.txtbPrecioActual.Location = new System.Drawing.Point(108, 197);
            this.txtbPrecioActual.Name = "txtbPrecioActual";
            this.txtbPrecioActual.ReadOnly = true;
            this.txtbPrecioActual.Size = new System.Drawing.Size(223, 20);
            this.txtbPrecioActual.TabIndex = 72;
            // 
            // txtbCategoriaActual
            // 
            this.txtbCategoriaActual.Location = new System.Drawing.Point(108, 171);
            this.txtbCategoriaActual.Name = "txtbCategoriaActual";
            this.txtbCategoriaActual.ReadOnly = true;
            this.txtbCategoriaActual.Size = new System.Drawing.Size(223, 20);
            this.txtbCategoriaActual.TabIndex = 71;
            // 
            // txtbMarcaActual
            // 
            this.txtbMarcaActual.Location = new System.Drawing.Point(108, 146);
            this.txtbMarcaActual.Name = "txtbMarcaActual";
            this.txtbMarcaActual.ReadOnly = true;
            this.txtbMarcaActual.Size = new System.Drawing.Size(223, 20);
            this.txtbMarcaActual.TabIndex = 70;
            // 
            // txtbDescripciónActual
            // 
            this.txtbDescripciónActual.Location = new System.Drawing.Point(108, 63);
            this.txtbDescripciónActual.Multiline = true;
            this.txtbDescripciónActual.Name = "txtbDescripciónActual";
            this.txtbDescripciónActual.ReadOnly = true;
            this.txtbDescripciónActual.Size = new System.Drawing.Size(223, 74);
            this.txtbDescripciónActual.TabIndex = 69;
            // 
            // txtbNombreActual
            // 
            this.txtbNombreActual.Location = new System.Drawing.Point(109, 37);
            this.txtbNombreActual.Name = "txtbNombreActual";
            this.txtbNombreActual.ReadOnly = true;
            this.txtbNombreActual.Size = new System.Drawing.Size(222, 20);
            this.txtbNombreActual.TabIndex = 69;
            // 
            // txtbCódigoActual
            // 
            this.txtbCódigoActual.Location = new System.Drawing.Point(109, 11);
            this.txtbCódigoActual.Name = "txtbCódigoActual";
            this.txtbCódigoActual.ReadOnly = true;
            this.txtbCódigoActual.Size = new System.Drawing.Size(222, 20);
            this.txtbCódigoActual.TabIndex = 69;
            // 
            // lblCódigoActual
            // 
            this.lblCódigoActual.AutoSize = true;
            this.lblCódigoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigoActual.Location = new System.Drawing.Point(6, 16);
            this.lblCódigoActual.Name = "lblCódigoActual";
            this.lblCódigoActual.Size = new System.Drawing.Size(97, 16);
            this.lblCódigoActual.TabIndex = 62;
            this.lblCódigoActual.Text = "Código Actual :";
            // 
            // lblPrecioActual
            // 
            this.lblPrecioActual.AutoSize = true;
            this.lblPrecioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioActual.Location = new System.Drawing.Point(6, 202);
            this.lblPrecioActual.Name = "lblPrecioActual";
            this.lblPrecioActual.Size = new System.Drawing.Size(52, 16);
            this.lblPrecioActual.TabIndex = 67;
            this.lblPrecioActual.Text = "Precio :";
            // 
            // lblNombreActual
            // 
            this.lblNombreActual.AutoSize = true;
            this.lblNombreActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreActual.Location = new System.Drawing.Point(6, 42);
            this.lblNombreActual.Name = "lblNombreActual";
            this.lblNombreActual.Size = new System.Drawing.Size(102, 16);
            this.lblNombreActual.TabIndex = 63;
            this.lblNombreActual.Text = "Nombre Actual :";
            // 
            // lblCategoriaActual
            // 
            this.lblCategoriaActual.AutoSize = true;
            this.lblCategoriaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaActual.Location = new System.Drawing.Point(6, 175);
            this.lblCategoriaActual.Name = "lblCategoriaActual";
            this.lblCategoriaActual.Size = new System.Drawing.Size(72, 16);
            this.lblCategoriaActual.TabIndex = 66;
            this.lblCategoriaActual.Text = "Categoría :";
            // 
            // lblDescripciónActual
            // 
            this.lblDescripciónActual.AutoSize = true;
            this.lblDescripciónActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripciónActual.Location = new System.Drawing.Point(6, 68);
            this.lblDescripciónActual.Name = "lblDescripciónActual";
            this.lblDescripciónActual.Size = new System.Drawing.Size(85, 16);
            this.lblDescripciónActual.TabIndex = 64;
            this.lblDescripciónActual.Text = "Descripción :";
            // 
            // lblMarcaActual
            // 
            this.lblMarcaActual.AutoSize = true;
            this.lblMarcaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaActual.Location = new System.Drawing.Point(6, 148);
            this.lblMarcaActual.Name = "lblMarcaActual";
            this.lblMarcaActual.Size = new System.Drawing.Size(51, 16);
            this.lblMarcaActual.TabIndex = 65;
            this.lblMarcaActual.Text = "Marca :";
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.Location = new System.Drawing.Point(6, 24);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(57, 16);
            this.lblCódigo.TabIndex = 43;
            this.lblCódigo.Text = "Código :";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(97, 156);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(123, 21);
            this.cbMarca.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Nombre :";
            // 
            // txtBPrecio
            // 
            this.txtBPrecio.Location = new System.Drawing.Point(97, 210);
            this.txtBPrecio.Name = "txtBPrecio";
            this.txtBPrecio.Size = new System.Drawing.Size(102, 20);
            this.txtBPrecio.TabIndex = 5;
            // 
            // cbCategoría
            // 
            this.cbCategoría.FormattingEnabled = true;
            this.cbCategoría.Location = new System.Drawing.Point(97, 183);
            this.cbCategoría.Name = "cbCategoría";
            this.cbCategoría.Size = new System.Drawing.Size(123, 21);
            this.cbCategoría.TabIndex = 4;
            // 
            // txtBDescripción
            // 
            this.txtBDescripción.Location = new System.Drawing.Point(97, 76);
            this.txtBDescripción.Multiline = true;
            this.txtBDescripción.Name = "txtBDescripción";
            this.txtBDescripción.Size = new System.Drawing.Size(123, 74);
            this.txtBDescripción.TabIndex = 2;
            // 
            // btnDeleteImagen
            // 
            this.btnDeleteImagen.Location = new System.Drawing.Point(258, 307);
            this.btnDeleteImagen.Name = "btnDeleteImagen";
            this.btnDeleteImagen.Size = new System.Drawing.Size(77, 39);
            this.btnDeleteImagen.TabIndex = 61;
            this.btnDeleteImagen.Text = "Eliminar Imagen";
            this.btnDeleteImagen.UseVisualStyleBackColor = true;
            // 
            // lbxImagenes
            // 
            this.lbxImagenes.FormattingEnabled = true;
            this.lbxImagenes.Location = new System.Drawing.Point(97, 238);
            this.lbxImagenes.Name = "lbxImagenes";
            this.lbxImagenes.Size = new System.Drawing.Size(122, 108);
            this.lbxImagenes.TabIndex = 56;
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.Location = new System.Drawing.Point(6, 76);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(85, 16);
            this.lblDescripción.TabIndex = 45;
            this.lblDescripción.Text = "Descripción :";
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(97, 50);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(122, 20);
            this.txtBNombre.TabIndex = 1;
            // 
            // btnAddImagen
            // 
            this.btnAddImagen.Location = new System.Drawing.Point(258, 238);
            this.btnAddImagen.Name = "btnAddImagen";
            this.btnAddImagen.Size = new System.Drawing.Size(77, 38);
            this.btnAddImagen.TabIndex = 6;
            this.btnAddImagen.Text = "Agregar Imagen";
            this.btnAddImagen.UseVisualStyleBackColor = true;
            // 
            // pbxImagen
            // 
            this.pbxImagen.InitialImage = null;
            this.pbxImagen.Location = new System.Drawing.Point(341, 238);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(120, 108);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 57;
            this.pbxImagen.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(6, 156);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 16);
            this.lblMarca.TabIndex = 46;
            this.lblMarca.Text = "Marca :";
            // 
            // txtBCódigo
            // 
            this.txtBCódigo.Location = new System.Drawing.Point(97, 24);
            this.txtBCódigo.Name = "txtBCódigo";
            this.txtBCódigo.Size = new System.Drawing.Size(122, 20);
            this.txtBCódigo.TabIndex = 0;
            // 
            // lblCategoría
            // 
            this.lblCategoría.AutoSize = true;
            this.lblCategoría.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoría.Location = new System.Drawing.Point(6, 183);
            this.lblCategoría.Name = "lblCategoría";
            this.lblCategoría.Size = new System.Drawing.Size(72, 16);
            this.lblCategoría.TabIndex = 47;
            this.lblCategoría.Text = "Categoría :";
            // 
            // lblImagenes
            // 
            this.lblImagenes.AutoSize = true;
            this.lblImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenes.Location = new System.Drawing.Point(6, 238);
            this.lblImagenes.Name = "lblImagenes";
            this.lblImagenes.Size = new System.Drawing.Size(73, 16);
            this.lblImagenes.TabIndex = 49;
            this.lblImagenes.Text = "Imágenes :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 210);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 16);
            this.lblPrecio.TabIndex = 48;
            this.lblPrecio.Text = "Precio :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpBDetalleArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 553);
            this.panel1.TabIndex = 65;
            // 
            // frmModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(620, 553);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarArticulo";
            this.Text = "frmModificar";
            this.Load += new System.EventHandler(this.frmModificarArticulo_Load);
            this.grpBDetalleArticulo.ResumeLayout(false);
            this.grpBDetalleArticulo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.grpbDetalleActual.ResumeLayout(false);
            this.grpbDetalleActual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBDetalleArticulo;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbCategoría;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBDescripción;
        private System.Windows.Forms.Button btnDeleteImagen;
        private System.Windows.Forms.ListBox lbxImagenes;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Button btnAddImagen;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBCódigo;
        private System.Windows.Forms.Label lblCategoría;
        private System.Windows.Forms.Label lblImagenes;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox grpbDetalleActual;
        private System.Windows.Forms.Label lblCódigoActual;
        private System.Windows.Forms.Label lblPrecioActual;
        private System.Windows.Forms.Label lblNombreActual;
        private System.Windows.Forms.Label lblCategoriaActual;
        private System.Windows.Forms.Label lblDescripciónActual;
        private System.Windows.Forms.Label lblMarcaActual;
        private System.Windows.Forms.TextBox txtbPrecioActual;
        private System.Windows.Forms.TextBox txtbCategoriaActual;
        private System.Windows.Forms.TextBox txtbMarcaActual;
        private System.Windows.Forms.TextBox txtbDescripciónActual;
        private System.Windows.Forms.TextBox txtbNombreActual;
        private System.Windows.Forms.TextBox txtbCódigoActual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
