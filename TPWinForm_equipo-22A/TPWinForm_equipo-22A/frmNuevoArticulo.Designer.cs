namespace TPWinForm_equipo_22A
{
    partial class frmNuevoArticulo
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
            this.grpBNuevoArticulo = new System.Windows.Forms.GroupBox();
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBCódigo = new System.Windows.Forms.TextBox();
            this.lblCategoría = new System.Windows.Forms.Label();
            this.lblImagenes = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpBNuevoArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBNuevoArticulo
            // 
            this.grpBNuevoArticulo.AutoSize = true;
            this.grpBNuevoArticulo.Controls.Add(this.panel2);
            this.grpBNuevoArticulo.Controls.Add(this.lblCódigo);
            this.grpBNuevoArticulo.Controls.Add(this.cbMarca);
            this.grpBNuevoArticulo.Controls.Add(this.lblNombre);
            this.grpBNuevoArticulo.Controls.Add(this.txtBPrecio);
            this.grpBNuevoArticulo.Controls.Add(this.cbCategoría);
            this.grpBNuevoArticulo.Controls.Add(this.txtBDescripción);
            this.grpBNuevoArticulo.Controls.Add(this.btnDeleteImagen);
            this.grpBNuevoArticulo.Controls.Add(this.lbxImagenes);
            this.grpBNuevoArticulo.Controls.Add(this.lblDescripción);
            this.grpBNuevoArticulo.Controls.Add(this.txtBNombre);
            this.grpBNuevoArticulo.Controls.Add(this.btnAddImagen);
            this.grpBNuevoArticulo.Controls.Add(this.pbxImagen);
            this.grpBNuevoArticulo.Controls.Add(this.lblMarca);
            this.grpBNuevoArticulo.Controls.Add(this.txtBCódigo);
            this.grpBNuevoArticulo.Controls.Add(this.lblCategoría);
            this.grpBNuevoArticulo.Controls.Add(this.lblImagenes);
            this.grpBNuevoArticulo.Controls.Add(this.lblPrecio);
            this.grpBNuevoArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBNuevoArticulo.Location = new System.Drawing.Point(0, 0);
            this.grpBNuevoArticulo.Name = "grpBNuevoArticulo";
            this.grpBNuevoArticulo.Size = new System.Drawing.Size(620, 553);
            this.grpBNuevoArticulo.TabIndex = 64;
            this.grpBNuevoArticulo.TabStop = false;
            this.grpBNuevoArticulo.Text = "Datos del articulo";
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
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(97, 94);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(123, 21);
            this.cbMarca.TabIndex = 3;
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
            // txtBPrecio
            // 
            this.txtBPrecio.Location = new System.Drawing.Point(97, 148);
            this.txtBPrecio.Name = "txtBPrecio";
            this.txtBPrecio.Size = new System.Drawing.Size(102, 20);
            this.txtBPrecio.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.Color.Yellow;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(331, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbCategoría
            // 
            this.cbCategoría.FormattingEnabled = true;
            this.cbCategoría.Location = new System.Drawing.Point(97, 121);
            this.cbCategoría.Name = "cbCategoría";
            this.cbCategoría.Size = new System.Drawing.Size(123, 21);
            this.cbCategoría.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.Location = new System.Drawing.Point(184, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtBDescripción
            // 
            this.txtBDescripción.Location = new System.Drawing.Point(97, 68);
            this.txtBDescripción.Name = "txtBDescripción";
            this.txtBDescripción.Size = new System.Drawing.Size(102, 20);
            this.txtBDescripción.TabIndex = 2;
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
            // lbxImagenes
            // 
            this.lbxImagenes.FormattingEnabled = true;
            this.lbxImagenes.Location = new System.Drawing.Point(97, 202);
            this.lbxImagenes.Name = "lbxImagenes";
            this.lbxImagenes.Size = new System.Drawing.Size(122, 108);
            this.lbxImagenes.TabIndex = 56;
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
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(97, 42);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(102, 20);
            this.txtBNombre.TabIndex = 1;
            // 
            // btnAddImagen
            // 
            this.btnAddImagen.Location = new System.Drawing.Point(223, 202);
            this.btnAddImagen.Name = "btnAddImagen";
            this.btnAddImagen.Size = new System.Drawing.Size(77, 38);
            this.btnAddImagen.TabIndex = 6;
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
            // txtBCódigo
            // 
            this.txtBCódigo.AcceptsTab = true;
            this.txtBCódigo.Location = new System.Drawing.Point(97, 16);
            this.txtBCódigo.Name = "txtBCódigo";
            this.txtBCódigo.Size = new System.Drawing.Size(102, 20);
            this.txtBCódigo.TabIndex = 0;
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
            // pbxImagen
            // 
            this.pbxImagen.Image = global::TPWinForm_equipo_22A.Properties.Resources.add_image_30;
            this.pbxImagen.InitialImage = null;
            this.pbxImagen.Location = new System.Drawing.Point(306, 202);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(120, 108);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 57;
            this.pbxImagen.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpBNuevoArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 553);
            this.panel1.TabIndex = 65;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 517);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 33);
            this.panel2.TabIndex = 62;
            // 
            // frmNuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(620, 553);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoArticulo";
            this.Text = "frmModificar";
            this.grpBNuevoArticulo.ResumeLayout(false);
            this.grpBNuevoArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBNuevoArticulo;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
