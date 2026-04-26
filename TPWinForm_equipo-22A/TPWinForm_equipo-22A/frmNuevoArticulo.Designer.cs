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
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.rbPorPC = new System.Windows.Forms.RadioButton();
            this.rbPorUrl = new System.Windows.Forms.RadioButton();
            this.lblMetodoCargaImagen = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBPrecio = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtBDescripcion = new System.Windows.Forms.TextBox();
            this.btnDeleteImagen = new System.Windows.Forms.Button();
            this.lbxImagenes = new System.Windows.Forms.ListBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.btnAddImagen = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBCodigo = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagenes = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBNuevoArticulo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBNuevoArticulo
            // 
            this.grpBNuevoArticulo.AutoSize = true;
            this.grpBNuevoArticulo.Controls.Add(this.txtUrlImagen);
            this.grpBNuevoArticulo.Controls.Add(this.rbPorPC);
            this.grpBNuevoArticulo.Controls.Add(this.rbPorUrl);
            this.grpBNuevoArticulo.Controls.Add(this.lblMetodoCargaImagen);
            this.grpBNuevoArticulo.Controls.Add(this.panel2);
            this.grpBNuevoArticulo.Controls.Add(this.lblCodigo);
            this.grpBNuevoArticulo.Controls.Add(this.cbMarca);
            this.grpBNuevoArticulo.Controls.Add(this.lblNombre);
            this.grpBNuevoArticulo.Controls.Add(this.txtBPrecio);
            this.grpBNuevoArticulo.Controls.Add(this.cbCategoria);
            this.grpBNuevoArticulo.Controls.Add(this.txtBDescripcion);
            this.grpBNuevoArticulo.Controls.Add(this.btnDeleteImagen);
            this.grpBNuevoArticulo.Controls.Add(this.lbxImagenes);
            this.grpBNuevoArticulo.Controls.Add(this.lblDescripcion);
            this.grpBNuevoArticulo.Controls.Add(this.txtBNombre);
            this.grpBNuevoArticulo.Controls.Add(this.btnAddImagen);
            this.grpBNuevoArticulo.Controls.Add(this.pbxImagen);
            this.grpBNuevoArticulo.Controls.Add(this.lblMarca);
            this.grpBNuevoArticulo.Controls.Add(this.txtBCodigo);
            this.grpBNuevoArticulo.Controls.Add(this.lblCategoria);
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
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(97, 268);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(203, 20);
            this.txtUrlImagen.TabIndex = 66;
            // 
            // rbPorPC
            // 
            this.rbPorPC.AutoSize = true;
            this.rbPorPC.Location = new System.Drawing.Point(77, 304);
            this.rbPorPC.Name = "rbPorPC";
            this.rbPorPC.Size = new System.Drawing.Size(76, 17);
            this.rbPorPC.TabIndex = 65;
            this.rbPorPC.TabStop = true;
            this.rbPorPC.Text = "Local / PC";
            this.rbPorPC.UseVisualStyleBackColor = true;
            this.rbPorPC.CheckedChanged += new System.EventHandler(this.rbPorPC_CheckedChanged);
            // 
            // rbPorUrl
            // 
            this.rbPorUrl.AutoSize = true;
            this.rbPorUrl.Location = new System.Drawing.Point(77, 245);
            this.rbPorUrl.Name = "rbPorUrl";
            this.rbPorUrl.Size = new System.Drawing.Size(66, 17);
            this.rbPorUrl.TabIndex = 64;
            this.rbPorUrl.TabStop = true;
            this.rbPorUrl.Text = "Por URL";
            this.rbPorUrl.UseVisualStyleBackColor = true;
            this.rbPorUrl.CheckedChanged += new System.EventHandler(this.rbPorUrl_CheckedChanged);
            // 
            // lblMetodoCargaImagen
            // 
            this.lblMetodoCargaImagen.AutoSize = true;
            this.lblMetodoCargaImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoCargaImagen.Location = new System.Drawing.Point(6, 212);
            this.lblMetodoCargaImagen.Name = "lblMetodoCargaImagen";
            this.lblMetodoCargaImagen.Size = new System.Drawing.Size(102, 16);
            this.lblMetodoCargaImagen.TabIndex = 63;
            this.lblMetodoCargaImagen.Text = "Cargar Imagen :";
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 16);
            this.lblCodigo.TabIndex = 43;
            this.lblCodigo.Text = "Código :";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(97, 124);
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
            this.txtBPrecio.Location = new System.Drawing.Point(97, 178);
            this.txtBPrecio.Name = "txtBPrecio";
            this.txtBPrecio.Size = new System.Drawing.Size(102, 20);
            this.txtBPrecio.TabIndex = 5;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(97, 151);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(123, 21);
            this.cbCategoria.TabIndex = 4;
            // 
            // txtBDescripcion
            // 
            this.txtBDescripcion.Location = new System.Drawing.Point(97, 68);
            this.txtBDescripcion.Multiline = true;
            this.txtBDescripcion.Name = "txtBDescripcion";
            this.txtBDescripcion.Size = new System.Drawing.Size(203, 50);
            this.txtBDescripcion.TabIndex = 2;
            // 
            // btnDeleteImagen
            // 
            this.btnDeleteImagen.Location = new System.Drawing.Point(223, 400);
            this.btnDeleteImagen.Name = "btnDeleteImagen";
            this.btnDeleteImagen.Size = new System.Drawing.Size(77, 39);
            this.btnDeleteImagen.TabIndex = 61;
            this.btnDeleteImagen.Text = "Eliminar Imagen";
            this.btnDeleteImagen.UseVisualStyleBackColor = true;
            this.btnDeleteImagen.Click += new System.EventHandler(this.btnDeleteImagen_Click);
            // 
            // lbxImagenes
            // 
            this.lbxImagenes.FormattingEnabled = true;
            this.lbxImagenes.Location = new System.Drawing.Point(97, 331);
            this.lbxImagenes.Name = "lbxImagenes";
            this.lbxImagenes.Size = new System.Drawing.Size(122, 108);
            this.lbxImagenes.TabIndex = 56;
            this.lbxImagenes.SelectedIndexChanged += new System.EventHandler(this.lbxImagenes_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(6, 68);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(85, 16);
            this.lblDescripcion.TabIndex = 45;
            this.lblDescripcion.Text = "Descripción :";
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(97, 42);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(122, 20);
            this.txtBNombre.TabIndex = 1;
            // 
            // btnAddImagen
            // 
            this.btnAddImagen.Location = new System.Drawing.Point(223, 331);
            this.btnAddImagen.Name = "btnAddImagen";
            this.btnAddImagen.Size = new System.Drawing.Size(77, 38);
            this.btnAddImagen.TabIndex = 6;
            this.btnAddImagen.Text = "Agregar Imagen";
            this.btnAddImagen.UseVisualStyleBackColor = true;
            this.btnAddImagen.Click += new System.EventHandler(this.btnAddImagen_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Image = global::TPWinForm_equipo_22A.Properties.Resources.add_image_30;
            this.pbxImagen.InitialImage = null;
            this.pbxImagen.Location = new System.Drawing.Point(306, 331);
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
            this.lblMarca.Location = new System.Drawing.Point(6, 124);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 16);
            this.lblMarca.TabIndex = 46;
            this.lblMarca.Text = "Marca :";
            // 
            // txtBCodigo
            // 
            this.txtBCodigo.AcceptsTab = true;
            this.txtBCodigo.Location = new System.Drawing.Point(97, 16);
            this.txtBCodigo.Name = "txtBCodigo";
            this.txtBCodigo.Size = new System.Drawing.Size(123, 20);
            this.txtBCodigo.TabIndex = 0;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(6, 151);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 16);
            this.lblCategoria.TabIndex = 47;
            this.lblCategoria.Text = "Categoría :";
            // 
            // lblImagenes
            // 
            this.lblImagenes.AutoSize = true;
            this.lblImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenes.Location = new System.Drawing.Point(6, 331);
            this.lblImagenes.Name = "lblImagenes";
            this.lblImagenes.Size = new System.Drawing.Size(73, 16);
            this.lblImagenes.TabIndex = 49;
            this.lblImagenes.Text = "Imágenes :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 178);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 16);
            this.lblPrecio.TabIndex = 48;
            this.lblPrecio.Text = "Precio :";
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
            // frmNuevoArticulo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(620, 553);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoArticulo";
            this.Text = "frmModificar";
            this.Load += new System.EventHandler(this.frmNuevoArticulo_Load);
            this.grpBNuevoArticulo.ResumeLayout(false);
            this.grpBNuevoArticulo.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBNuevoArticulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBDescripcion;
        private System.Windows.Forms.Button btnDeleteImagen;
        private System.Windows.Forms.ListBox lbxImagenes;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Button btnAddImagen;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImagenes;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMetodoCargaImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.RadioButton rbPorPC;
        private System.Windows.Forms.RadioButton rbPorUrl;
    }
}
