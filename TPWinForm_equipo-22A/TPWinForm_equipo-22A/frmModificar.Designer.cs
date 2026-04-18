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
            this.grpBDetalleArticulo = new System.Windows.Forms.GroupBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBPrecio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbCategoría = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
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
            this.grpBDetalleArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
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
            this.grpBDetalleArticulo.Location = new System.Drawing.Point(25, 27);
            this.grpBDetalleArticulo.Margin = new System.Windows.Forms.Padding(6);
            this.grpBDetalleArticulo.Name = "grpBDetalleArticulo";
            this.grpBDetalleArticulo.Padding = new System.Windows.Forms.Padding(6);
            this.grpBDetalleArticulo.Size = new System.Drawing.Size(892, 715);
            this.grpBDetalleArticulo.TabIndex = 64;
            this.grpBDetalleArticulo.TabStop = false;
            this.grpBDetalleArticulo.Text = "Detalle del articulo seleccionado";
            this.grpBDetalleArticulo.Enter += new System.EventHandler(this.grpBDetalleArticulo_Enter);
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.Location = new System.Drawing.Point(12, 31);
            this.lblCódigo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(108, 30);
            this.lblCódigo.TabIndex = 43;
            this.lblCódigo.Text = "Código :";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(194, 181);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(6);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(242, 33);
            this.cbMarca.TabIndex = 54;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 81);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(119, 30);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Nombre :";
            // 
            // txtBPrecio
            // 
            this.txtBPrecio.Location = new System.Drawing.Point(194, 285);
            this.txtBPrecio.Margin = new System.Windows.Forms.Padding(6);
            this.txtBPrecio.Name = "txtBPrecio";
            this.txtBPrecio.Size = new System.Drawing.Size(200, 31);
            this.txtBPrecio.TabIndex = 53;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Yellow;
            this.btnCancelar.Location = new System.Drawing.Point(558, 635);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 44);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cbCategoría
            // 
            this.cbCategoría.FormattingEnabled = true;
            this.cbCategoría.Location = new System.Drawing.Point(194, 233);
            this.cbCategoría.Margin = new System.Windows.Forms.Padding(6);
            this.cbCategoría.Name = "cbCategoría";
            this.cbCategoría.Size = new System.Drawing.Size(242, 33);
            this.cbCategoría.TabIndex = 55;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SkyBlue;
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
            this.txtBDescripción.Location = new System.Drawing.Point(194, 131);
            this.txtBDescripción.Margin = new System.Windows.Forms.Padding(6);
            this.txtBDescripción.Name = "txtBDescripción";
            this.txtBDescripción.Size = new System.Drawing.Size(200, 31);
            this.txtBDescripción.TabIndex = 52;
            // 
            // btnDeleteImagen
            // 
            this.btnDeleteImagen.Location = new System.Drawing.Point(446, 521);
            this.btnDeleteImagen.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteImagen.Name = "btnDeleteImagen";
            this.btnDeleteImagen.Size = new System.Drawing.Size(154, 75);
            this.btnDeleteImagen.TabIndex = 61;
            this.btnDeleteImagen.Text = "Eliminar Imagen";
            this.btnDeleteImagen.UseVisualStyleBackColor = true;
            // 
            // lbxImagenes
            // 
            this.lbxImagenes.FormattingEnabled = true;
            this.lbxImagenes.ItemHeight = 25;
            this.lbxImagenes.Location = new System.Drawing.Point(194, 388);
            this.lbxImagenes.Margin = new System.Windows.Forms.Padding(6);
            this.lbxImagenes.Name = "lbxImagenes";
            this.lbxImagenes.Size = new System.Drawing.Size(240, 204);
            this.lbxImagenes.TabIndex = 56;
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
            this.txtBNombre.Location = new System.Drawing.Point(194, 81);
            this.txtBNombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(200, 31);
            this.txtBNombre.TabIndex = 51;
            // 
            // btnAddImagen
            // 
            this.btnAddImagen.Location = new System.Drawing.Point(446, 388);
            this.btnAddImagen.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddImagen.Name = "btnAddImagen";
            this.btnAddImagen.Size = new System.Drawing.Size(154, 73);
            this.btnAddImagen.TabIndex = 60;
            this.btnAddImagen.Text = "Agregar Imagen";
            this.btnAddImagen.UseVisualStyleBackColor = true;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(608, 388);
            this.pbxImagen.Margin = new System.Windows.Forms.Padding(6);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(123, 108);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxImagen.TabIndex = 57;
            this.pbxImagen.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(12, 181);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(99, 30);
            this.lblMarca.TabIndex = 46;
            this.lblMarca.Text = "Marca :";
            // 
            // txtBCódigo
            // 
            this.txtBCódigo.Location = new System.Drawing.Point(194, 31);
            this.txtBCódigo.Margin = new System.Windows.Forms.Padding(6);
            this.txtBCódigo.Name = "txtBCódigo";
            this.txtBCódigo.Size = new System.Drawing.Size(200, 31);
            this.txtBCódigo.TabIndex = 50;
            // 
            // lblCategoría
            // 
            this.lblCategoría.AutoSize = true;
            this.lblCategoría.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoría.Location = new System.Drawing.Point(12, 233);
            this.lblCategoría.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategoría.Name = "lblCategoría";
            this.lblCategoría.Size = new System.Drawing.Size(138, 30);
            this.lblCategoría.TabIndex = 47;
            this.lblCategoría.Text = "Categoría :";
            // 
            // lblImagenes
            // 
            this.lblImagenes.AutoSize = true;
            this.lblImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenes.Location = new System.Drawing.Point(12, 388);
            this.lblImagenes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblImagenes.Name = "lblImagenes";
            this.lblImagenes.Size = new System.Drawing.Size(138, 30);
            this.lblImagenes.TabIndex = 49;
            this.lblImagenes.Text = "Imágenes :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 285);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(100, 30);
            this.lblPrecio.TabIndex = 48;
            this.lblPrecio.Text = "Precio :";
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(942, 769);
            this.Controls.Add(this.grpBDetalleArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmModificar";
            this.Text = "frmModificar";
            this.grpBDetalleArticulo.ResumeLayout(false);
            this.grpBDetalleArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
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
    }
}