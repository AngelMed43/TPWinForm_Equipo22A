namespace TPWinForm_equipo_22A
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.tlsSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscarBarraTareas = new System.Windows.Forms.Label();
            this.txtBBuscarSuperior = new System.Windows.Forms.TextBox();
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.Articulos = new System.Windows.Forms.TabPage();
            this.grpBListaArticulo = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.Marcas = new System.Windows.Forms.TabPage();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.Categorias = new System.Windows.Forms.TabPage();
            this.grbCategorias = new System.Windows.Forms.GroupBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.stsInferior = new System.Windows.Forms.StatusStrip();
            this.grBBarraBusqueda = new System.Windows.Forms.GroupBox();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.rbFiltroEstado = new System.Windows.Forms.RadioButton();
            this.lblfFiltroPrecio = new System.Windows.Forms.Label();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnDetallesArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.grpBUniversal = new System.Windows.Forms.GroupBox();
            this.pnlUniversal = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tlsSuperior.SuspendLayout();
            this.tcMenu.SuspendLayout();
            this.Articulos.SuspendLayout();
            this.grpBListaArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.Marcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.Categorias.SuspendLayout();
            this.grbCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.grBBarraBusqueda.SuspendLayout();
            this.grpBUniversal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsSuperior
            // 
            this.tlsSuperior.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tlsSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.tlsSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlsSuperior.Name = "tlsSuperior";
            this.tlsSuperior.Padding = new System.Windows.Forms.Padding(0);
            this.tlsSuperior.Size = new System.Drawing.Size(1264, 25);
            this.tlsSuperior.TabIndex = 2;
            this.tlsSuperior.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBuscarBarraTareas
            // 
            this.lblBuscarBarraTareas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscarBarraTareas.AutoSize = true;
            this.lblBuscarBarraTareas.Location = new System.Drawing.Point(1066, 5);
            this.lblBuscarBarraTareas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarBarraTareas.Name = "lblBuscarBarraTareas";
            this.lblBuscarBarraTareas.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarBarraTareas.TabIndex = 3;
            this.lblBuscarBarraTareas.Text = "Buscar:";
            this.lblBuscarBarraTareas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBBuscarSuperior
            // 
            this.txtBBuscarSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBBuscarSuperior.Location = new System.Drawing.Point(1112, 1);
            this.txtBBuscarSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.txtBBuscarSuperior.Name = "txtBBuscarSuperior";
            this.txtBBuscarSuperior.Size = new System.Drawing.Size(150, 20);
            this.txtBBuscarSuperior.TabIndex = 4;
            // 
            // tcMenu
            // 
            this.tcMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMenu.Controls.Add(this.Articulos);
            this.tcMenu.Controls.Add(this.Marcas);
            this.tcMenu.Controls.Add(this.Categorias);
            this.tcMenu.Location = new System.Drawing.Point(0, 90);
            this.tcMenu.Margin = new System.Windows.Forms.Padding(2);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(610, 567);
            this.tcMenu.TabIndex = 5;
            this.tcMenu.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Articulos
            // 
            this.Articulos.Controls.Add(this.grpBListaArticulo);
            this.Articulos.Location = new System.Drawing.Point(4, 22);
            this.Articulos.Margin = new System.Windows.Forms.Padding(2);
            this.Articulos.Name = "Articulos";
            this.Articulos.Padding = new System.Windows.Forms.Padding(2);
            this.Articulos.Size = new System.Drawing.Size(602, 541);
            this.Articulos.TabIndex = 0;
            this.Articulos.Text = "Articulos";
            this.Articulos.UseVisualStyleBackColor = true;
            // 
            // grpBListaArticulo
            // 
            this.grpBListaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBListaArticulo.Controls.Add(this.dgvArticulos);
            this.grpBListaArticulo.Location = new System.Drawing.Point(5, 5);
            this.grpBListaArticulo.Name = "grpBListaArticulo";
            this.grpBListaArticulo.Size = new System.Drawing.Size(592, 521);
            this.grpBListaArticulo.TabIndex = 0;
            this.grpBListaArticulo.TabStop = false;
            this.grpBListaArticulo.Text = "Listado de Articulos";
            // 
            // dgvArticulos
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.dgvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(5, 18);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 82;
            this.dgvArticulos.RowTemplate.Height = 33;
            this.dgvArticulos.Size = new System.Drawing.Size(582, 498);
            this.dgvArticulos.TabIndex = 0;
            // 
            // Marcas
            // 
            this.Marcas.Controls.Add(this.dgvMarcas);
            this.Marcas.Location = new System.Drawing.Point(4, 22);
            this.Marcas.Margin = new System.Windows.Forms.Padding(2);
            this.Marcas.Name = "Marcas";
            this.Marcas.Padding = new System.Windows.Forms.Padding(2);
            this.Marcas.Size = new System.Drawing.Size(602, 541);
            this.Marcas.TabIndex = 1;
            this.Marcas.Text = "Marcas";
            this.Marcas.UseVisualStyleBackColor = true;
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(8, 14);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 82;
            this.dgvMarcas.RowTemplate.Height = 33;
            this.dgvMarcas.Size = new System.Drawing.Size(568, 506);
            this.dgvMarcas.TabIndex = 0;
            // 
            // Categorias
            // 
            this.Categorias.Controls.Add(this.grbCategorias);
            this.Categorias.Location = new System.Drawing.Point(4, 22);
            this.Categorias.Margin = new System.Windows.Forms.Padding(2);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(602, 541);
            this.Categorias.TabIndex = 2;
            this.Categorias.Text = "Categorias";
            this.Categorias.UseVisualStyleBackColor = true;
            // 
            // grbCategorias
            // 
            this.grbCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCategorias.Controls.Add(this.dgvCategorias);
            this.grbCategorias.Location = new System.Drawing.Point(5, 6);
            this.grbCategorias.Name = "grbCategorias";
            this.grbCategorias.Size = new System.Drawing.Size(592, 531);
            this.grbCategorias.TabIndex = 1;
            this.grbCategorias.TabStop = false;
            this.grbCategorias.Text = "Listado de Categorias";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(5, 18);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 82;
            this.dgvCategorias.RowTemplate.Height = 33;
            this.dgvCategorias.Size = new System.Drawing.Size(582, 508);
            this.dgvCategorias.TabIndex = 0;
            // 
            // stsInferior
            // 
            this.stsInferior.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.stsInferior.Location = new System.Drawing.Point(0, 659);
            this.stsInferior.Name = "stsInferior";
            this.stsInferior.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.stsInferior.Size = new System.Drawing.Size(1264, 22);
            this.stsInferior.TabIndex = 6;
            this.stsInferior.Text = "statusStrip1";
            // 
            // grBBarraBusqueda
            // 
            this.grBBarraBusqueda.Controls.Add(this.lblFiltroEstado);
            this.grBBarraBusqueda.Controls.Add(this.rbFiltroEstado);
            this.grBBarraBusqueda.Controls.Add(this.lblfFiltroPrecio);
            this.grBBarraBusqueda.Controls.Add(this.lblFiltroCategoria);
            this.grBBarraBusqueda.Controls.Add(this.lblFiltroMarca);
            this.grBBarraBusqueda.Controls.Add(this.textBox2);
            this.grBBarraBusqueda.Controls.Add(this.comboBox2);
            this.grBBarraBusqueda.Controls.Add(this.comboBox1);
            this.grBBarraBusqueda.Location = new System.Drawing.Point(0, 28);
            this.grBBarraBusqueda.Name = "grBBarraBusqueda";
            this.grBBarraBusqueda.Size = new System.Drawing.Size(638, 62);
            this.grBBarraBusqueda.TabIndex = 7;
            this.grBBarraBusqueda.TabStop = false;
            this.grBBarraBusqueda.Text = "Menú Filtros";
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Location = new System.Drawing.Point(438, 16);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(71, 13);
            this.lblFiltroEstado.TabIndex = 7;
            this.lblFiltroEstado.Text = "Activar Filtro :";
            // 
            // rbFiltroEstado
            // 
            this.rbFiltroEstado.AutoSize = true;
            this.rbFiltroEstado.Location = new System.Drawing.Point(441, 39);
            this.rbFiltroEstado.Name = "rbFiltroEstado";
            this.rbFiltroEstado.Size = new System.Drawing.Size(59, 17);
            this.rbFiltroEstado.TabIndex = 6;
            this.rbFiltroEstado.TabStop = true;
            this.rbFiltroEstado.Text = "Si / No";
            this.rbFiltroEstado.UseVisualStyleBackColor = true;
            // 
            // lblfFiltroPrecio
            // 
            this.lblfFiltroPrecio.AutoSize = true;
            this.lblfFiltroPrecio.Location = new System.Drawing.Point(345, 16);
            this.lblfFiltroPrecio.Name = "lblfFiltroPrecio";
            this.lblfFiltroPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblfFiltroPrecio.TabIndex = 5;
            this.lblfFiltroPrecio.Text = "Precio :";
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Location = new System.Drawing.Point(204, 16);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(60, 13);
            this.lblFiltroCategoria.TabIndex = 4;
            this.lblFiltroCategoria.Text = "Categoría :";
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Location = new System.Drawing.Point(46, 16);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(43, 13);
            this.lblFiltroMarca.TabIndex = 3;
            this.lblFiltroMarca.Text = "Marca :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(171, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoArticulo.Location = new System.Drawing.Point(644, 220);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoArticulo.TabIndex = 8;
            this.btnNuevoArticulo.Text = "Nuevo";
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarArticulo.Location = new System.Drawing.Point(644, 274);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnModificarArticulo.TabIndex = 9;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnDetallesArticulo
            // 
            this.btnDetallesArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetallesArticulo.Location = new System.Drawing.Point(644, 313);
            this.btnDetallesArticulo.Name = "btnDetallesArticulo";
            this.btnDetallesArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnDetallesArticulo.TabIndex = 10;
            this.btnDetallesArticulo.Text = "Detalles";
            this.btnDetallesArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(644, 367);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarArticulo.TabIndex = 11;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // grpBUniversal
            // 
            this.grpBUniversal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBUniversal.Controls.Add(this.pnlUniversal);
            this.grpBUniversal.Location = new System.Drawing.Point(761, 112);
            this.grpBUniversal.Name = "grpBUniversal";
            this.grpBUniversal.Size = new System.Drawing.Size(500, 544);
            this.grpBUniversal.TabIndex = 12;
            this.grpBUniversal.TabStop = false;
            // 
            // pnlUniversal
            // 
            this.pnlUniversal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUniversal.Location = new System.Drawing.Point(3, 16);
            this.pnlUniversal.Name = "pnlUniversal";
            this.pnlUniversal.Size = new System.Drawing.Size(494, 525);
            this.pnlUniversal.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.AccessibleName = "pbLogo";
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.Image = global::TPWinForm_equipo_22A.Properties.Resources.handle_with_care_100;
            this.pbLogo.Location = new System.Drawing.Point(1063, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(102, 94);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.grpBUniversal);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnDetallesArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnNuevoArticulo);
            this.Controls.Add(this.grBBarraBusqueda);
            this.Controls.Add(this.stsInferior);
            this.Controls.Add(this.tcMenu);
            this.Controls.Add(this.txtBBuscarSuperior);
            this.Controls.Add(this.lblBuscarBarraTareas);
            this.Controls.Add(this.tlsSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(967, 554);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion de gestion";
            this.tlsSuperior.ResumeLayout(false);
            this.tlsSuperior.PerformLayout();
            this.tcMenu.ResumeLayout(false);
            this.Articulos.ResumeLayout(false);
            this.grpBListaArticulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.Marcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.Categorias.ResumeLayout(false);
            this.grbCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.grBBarraBusqueda.ResumeLayout(false);
            this.grBBarraBusqueda.PerformLayout();
            this.grpBUniversal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tlsSuperior;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblBuscarBarraTareas;
        private System.Windows.Forms.TextBox txtBBuscarSuperior;
        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage Articulos;
        private System.Windows.Forms.TabPage Marcas;
        private System.Windows.Forms.TabPage Categorias;
        private System.Windows.Forms.StatusStrip stsInferior;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.GroupBox grBBarraBusqueda;
        private System.Windows.Forms.GroupBox grpBListaArticulo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.RadioButton rbFiltroEstado;
        private System.Windows.Forms.Label lblfFiltroPrecio;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.Label lblFiltroMarca;
        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnDetallesArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.GroupBox grpBUniversal;
        private System.Windows.Forms.Panel pnlUniversal;
        private System.Windows.Forms.GroupBox grbCategorias;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

