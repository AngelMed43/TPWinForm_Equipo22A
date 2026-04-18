namespace TPWinForm_equipo_22A
{
    partial class frmModificar
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
            this.lblCódigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDeleteImagen = new System.Windows.Forms.Button();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.btnAddImagen = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoría = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImagenes = new System.Windows.Forms.Label();
            this.txtBCódigo = new System.Windows.Forms.TextBox();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.lbxImagenes = new System.Windows.Forms.ListBox();
            this.txtBDescripción = new System.Windows.Forms.TextBox();
            this.cbCategoría = new System.Windows.Forms.ComboBox();
            this.txtBPrecio = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.grpBDetalleArticulo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.grpBDetalleArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.Location = new System.Drawing.Point(6, 16);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(57, 16);
            this.lblCódigo.TabIndex = 43;
            this.lblCódigo.Text = "Código :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Nombre :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Yellow;
            this.btnCancelar.Location = new System.Drawing.Point(279, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 23);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.Location = new System.Drawing.Point(132, 330);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 23);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnDeleteImagen
            // 
            this.btnDeleteImagen.Location = new System.Drawing.Point(223, 271);
            this.btnDeleteImagen.Name = "btnDeleteImagen";
            this.btnDeleteImagen.Size = new System.Drawing.Size(77, 39);
            this.btnDeleteImagen.TabIndex = 61;
            this.btnDeleteImagen.Text = "Eliminar Imagen";
            this.btnDeleteImagen.UseVisualStyleBackColor = true;
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
            // btnAddImagen
            // 
            this.btnAddImagen.Location = new System.Drawing.Point(223, 202);
            this.btnAddImagen.Name = "btnAddImagen";
            this.btnAddImagen.Size = new System.Drawing.Size(77, 38);
            this.btnAddImagen.TabIndex = 60;
            this.btnAddImagen.Text = "Agregar Imagen";
            this.btnAddImagen.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(6, 94);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 16);
            this.lblMarca.TabIndex = 46;
            this.lblMarca.Text = "Marca :";
            // 
            // lblCategoría
            // 
            this.lblCategoría.AutoSize = true;
            this.lblCategoría.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoría.Location = new System.Drawing.Point(6, 121);
            this.lblCategoría.Name = "lblCategoría";
            this.lblCategoría.Size = new System.Drawing.Size(72, 16);
            this.lblCategoría.TabIndex = 47;
            this.lblCategoría.Text = "Categoría :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 148);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 16);
            this.lblPrecio.TabIndex = 48;
            this.lblPrecio.Text = "Precio :";
            // 
            // lblImagenes
            // 
            this.lblImagenes.AutoSize = true;
            this.lblImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenes.Location = new System.Drawing.Point(6, 202);
            this.lblImagenes.Name = "lblImagenes";
            this.lblImagenes.Size = new System.Drawing.Size(73, 16);
            this.lblImagenes.TabIndex = 49;
            this.lblImagenes.Text = "Imágenes :";
            // 
            // txtBCódigo
            // 
            this.txtBCódigo.Location = new System.Drawing.Point(97, 16);
            this.txtBCódigo.Name = "txtBCódigo";
            this.txtBCódigo.Size = new System.Drawing.Size(102, 20);
            this.txtBCódigo.TabIndex = 50;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(304, 202);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(123, 108);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxImagen.TabIndex = 57;
            this.pbxImagen.TabStop = false;
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(97, 42);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(102, 20);
            this.txtBNombre.TabIndex = 51;
            // 
            // lbxImagenes
            // 
            this.lbxImagenes.FormattingEnabled = true;
            this.lbxImagenes.Location = new System.Drawing.Point(97, 202);
            this.lbxImagenes.Name = "lbxImagenes";
            this.lbxImagenes.Size = new System.Drawing.Size(122, 108);
            this.lbxImagenes.TabIndex = 56;
            // 
            // txtBDescripción
            // 
            this.txtBDescripción.Location = new System.Drawing.Point(97, 68);
            this.txtBDescripción.Name = "txtBDescripción";
            this.txtBDescripción.Size = new System.Drawing.Size(102, 20);
            this.txtBDescripción.TabIndex = 52;
            // 
            // cbCategoría
            // 
            this.cbCategoría.FormattingEnabled = true;
            this.cbCategoría.Location = new System.Drawing.Point(97, 121);
            this.cbCategoría.Name = "cbCategoría";
            this.cbCategoría.Size = new System.Drawing.Size(123, 21);
            this.cbCategoría.TabIndex = 55;
            // 
            // txtBPrecio
            // 
            this.txtBPrecio.Location = new System.Drawing.Point(97, 148);
            this.txtBPrecio.Name = "txtBPrecio";
            this.txtBPrecio.Size = new System.Drawing.Size(102, 20);
            this.txtBPrecio.TabIndex = 53;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(97, 94);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(123, 21);
            this.cbMarca.TabIndex = 54;
            // 
            // grpBDetalleArticulo
            // 
            this.grpBDetalleArticulo.Controls.Add(this.lblCódigo);
            this.grpBDetalleArticulo.Controls.Add(this.cbMarca);
            this.grpBDetalleArticulo.Controls.Add(this.lblNombre);
            this.grpBDetalleArticulo.Controls.Add(this.txtBPrecio);
            this.grpBDetalleArticulo.Controls.Add(this.btnCancelar);
            this.grpBDetalleArticulo.Controls.Add(this.cbCategoría);
            this.grpBDetalleArticulo.Controls.Add(this.btnGuardar);
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
            this.grpBDetalleArticulo.Location = new System.Drawing.Point(12, 12);
            this.grpBDetalleArticulo.Name = "grpBDetalleArticulo";
            this.grpBDetalleArticulo.Size = new System.Drawing.Size(446, 372);
            this.grpBDetalleArticulo.TabIndex = 62;
            this.grpBDetalleArticulo.TabStop = false;
            this.grpBDetalleArticulo.Text = "Detalle del articulo seleccionado";
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(471, 400);
            this.Controls.Add(this.grpBDetalleArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificar";
            this.Text = "frmModificar";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.grpBDetalleArticulo.ResumeLayout(false);
            this.grpBDetalleArticulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDeleteImagen;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Button btnAddImagen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoría;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImagenes;
        private System.Windows.Forms.TextBox txtBCódigo;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.ListBox lbxImagenes;
        private System.Windows.Forms.TextBox txtBDescripción;
        private System.Windows.Forms.ComboBox cbCategoría;
        private System.Windows.Forms.TextBox txtBPrecio;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.GroupBox grpBDetalleArticulo;
    }
}