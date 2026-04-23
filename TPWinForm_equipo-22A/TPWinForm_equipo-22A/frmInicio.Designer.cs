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
            this.grpBListaMarcas = new System.Windows.Forms.GroupBox();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.Categorias = new System.Windows.Forms.TabPage();
            this.grpCategorias = new System.Windows.Forms.GroupBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.stsInferior = new System.Windows.Forms.StatusStrip();
            this.grBBarraBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBPrecioHasta = new System.Windows.Forms.TextBox();
            this.rdBFiltroXPrecio = new System.Windows.Forms.RadioButton();
            this.rdBFiltroXCategoria = new System.Windows.Forms.RadioButton();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.rdBFiltroXMarca = new System.Windows.Forms.RadioButton();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            this.txtBPrecioDesde = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
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
            this.grpBListaMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.Categorias.SuspendLayout();
            this.grpCategorias.SuspendLayout();
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
            this.tlsSuperior.Size = new System.Drawing.Size(1122, 25);
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
            this.lblBuscarBarraTareas.Location = new System.Drawing.Point(1226, 5);
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
            this.txtBBuscarSuperior.Location = new System.Drawing.Point(1272, 1);
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
            this.tcMenu.Size = new System.Drawing.Size(742, 591);
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
            this.Articulos.Size = new System.Drawing.Size(734, 565);
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
            this.grpBListaArticulo.Size = new System.Drawing.Size(629, 511);
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
            this.dgvArticulos.Size = new System.Drawing.Size(524, 454);
            this.dgvArticulos.TabIndex = 0;
            // 
            // Marcas
            // 
            this.Marcas.Controls.Add(this.grpBListaMarcas);
            this.Marcas.Location = new System.Drawing.Point(4, 22);
            this.Marcas.Margin = new System.Windows.Forms.Padding(2);
            this.Marcas.Name = "Marcas";
            this.Marcas.Padding = new System.Windows.Forms.Padding(2);
            this.Marcas.Size = new System.Drawing.Size(734, 565);
            this.Marcas.TabIndex = 1;
            this.Marcas.Text = "Marcas";
            this.Marcas.UseVisualStyleBackColor = true;
            // 
            // grpBListaMarcas
            // 
            this.grpBListaMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBListaMarcas.Controls.Add(this.dgvMarcas);
            this.grpBListaMarcas.Location = new System.Drawing.Point(5, 5);
            this.grpBListaMarcas.Name = "grpBListaMarcas";
            this.grpBListaMarcas.Size = new System.Drawing.Size(592, 531);
            this.grpBListaMarcas.TabIndex = 0;
            this.grpBListaMarcas.TabStop = false;
            this.grpBListaMarcas.Text = "Listado de Marcas";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(5, 18);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 82;
            this.dgvMarcas.RowTemplate.Height = 33;
            this.dgvMarcas.Size = new System.Drawing.Size(554, 429);
            this.dgvMarcas.TabIndex = 1;
            // 
            // Categorias
            // 
            this.Categorias.Controls.Add(this.grpCategorias);
            this.Categorias.Location = new System.Drawing.Point(4, 22);
            this.Categorias.Margin = new System.Windows.Forms.Padding(2);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(734, 565);
            this.Categorias.TabIndex = 2;
            this.Categorias.Text = "Categorias";
            this.Categorias.UseVisualStyleBackColor = true;
            // 
            // grpCategorias
            // 
            this.grpCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCategorias.Controls.Add(this.dgvCategorias);
            this.grpCategorias.Location = new System.Drawing.Point(5, 5);
            this.grpCategorias.Name = "grpCategorias";
            this.grpCategorias.Size = new System.Drawing.Size(564, 452);
            this.grpCategorias.TabIndex = 1;
            this.grpCategorias.TabStop = false;
            this.grpCategorias.Text = "Listado de Categorias";
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
            this.dgvCategorias.Size = new System.Drawing.Size(554, 429);
            this.dgvCategorias.TabIndex = 0;
            // 
            // stsInferior
            // 
            this.stsInferior.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.stsInferior.Location = new System.Drawing.Point(0, 623);
            this.stsInferior.Name = "stsInferior";
            this.stsInferior.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.stsInferior.Size = new System.Drawing.Size(1122, 22);
            this.stsInferior.TabIndex = 6;
            this.stsInferior.Text = "statusStrip1";
            // 
            // grBBarraBusqueda
            // 
            this.grBBarraBusqueda.Controls.Add(this.txtBPrecioHasta);
            this.grBBarraBusqueda.Controls.Add(this.rdBFiltroXPrecio);
            this.grBBarraBusqueda.Controls.Add(this.rdBFiltroXCategoria);
            this.grBBarraBusqueda.Controls.Add(this.lblFiltroEstado);
            this.grBBarraBusqueda.Controls.Add(this.rdBFiltroXMarca);
            this.grBBarraBusqueda.Controls.Add(this.lblFiltroMarca);
            this.grBBarraBusqueda.Controls.Add(this.txtBPrecioDesde);
            this.grBBarraBusqueda.Controls.Add(this.cboCategoria);
            this.grBBarraBusqueda.Controls.Add(this.cboMarca);
            this.grBBarraBusqueda.Location = new System.Drawing.Point(0, 28);
            this.grBBarraBusqueda.Name = "grBBarraBusqueda";
            this.grBBarraBusqueda.Size = new System.Drawing.Size(638, 62);
            this.grBBarraBusqueda.TabIndex = 7;
            this.grBBarraBusqueda.TabStop = false;
            this.grBBarraBusqueda.Text = "Filtrar Articulos";
            // 
            // txtBPrecioHasta
            // 
            this.txtBPrecioHasta.Location = new System.Drawing.Point(408, 36);
            this.txtBPrecioHasta.Name = "txtBPrecioHasta";
            this.txtBPrecioHasta.Size = new System.Drawing.Size(82, 20);
            this.txtBPrecioHasta.TabIndex = 10;
            this.txtBPrecioHasta.Text = "Hasta:";
            this.txtBPrecioHasta.Click += new System.EventHandler(this.txtBPrecioHasta_Click);
            // 
            // rdBFiltroXPrecio
            // 
            this.rdBFiltroXPrecio.AutoSize = true;
            this.rdBFiltroXPrecio.Location = new System.Drawing.Point(314, 14);
            this.rdBFiltroXPrecio.Name = "rdBFiltroXPrecio";
            this.rdBFiltroXPrecio.Size = new System.Drawing.Size(55, 17);
            this.rdBFiltroXPrecio.TabIndex = 9;
            this.rdBFiltroXPrecio.TabStop = true;
            this.rdBFiltroXPrecio.Text = "Precio";
            this.rdBFiltroXPrecio.UseVisualStyleBackColor = true;
            // 
            // rdBFiltroXCategoria
            // 
            this.rdBFiltroXCategoria.AutoSize = true;
            this.rdBFiltroXCategoria.Location = new System.Drawing.Point(171, 15);
            this.rdBFiltroXCategoria.Name = "rdBFiltroXCategoria";
            this.rdBFiltroXCategoria.Size = new System.Drawing.Size(70, 17);
            this.rdBFiltroXCategoria.TabIndex = 8;
            this.rdBFiltroXCategoria.TabStop = true;
            this.rdBFiltroXCategoria.Text = "Categoria";
            this.rdBFiltroXCategoria.UseVisualStyleBackColor = true;
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Location = new System.Drawing.Point(438, 16);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(0, 13);
            this.lblFiltroEstado.TabIndex = 7;
            // 
            // rdBFiltroXMarca
            // 
            this.rdBFiltroXMarca.AutoSize = true;
            this.rdBFiltroXMarca.Location = new System.Drawing.Point(9, 16);
            this.rdBFiltroXMarca.Name = "rdBFiltroXMarca";
            this.rdBFiltroXMarca.Size = new System.Drawing.Size(55, 17);
            this.rdBFiltroXMarca.TabIndex = 6;
            this.rdBFiltroXMarca.TabStop = true;
            this.rdBFiltroXMarca.Text = "Marca";
            this.rdBFiltroXMarca.UseVisualStyleBackColor = true;
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Location = new System.Drawing.Point(29, 16);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(0, 13);
            this.lblFiltroMarca.TabIndex = 3;
            // 
            // txtBPrecioDesde
            // 
            this.txtBPrecioDesde.Location = new System.Drawing.Point(314, 36);
            this.txtBPrecioDesde.Name = "txtBPrecioDesde";
            this.txtBPrecioDesde.Size = new System.Drawing.Size(82, 20);
            this.txtBPrecioDesde.TabIndex = 2;
            this.txtBPrecioDesde.Text = "Desde:";
            this.txtBPrecioDesde.Click += new System.EventHandler(this.txtBPrecioDesde_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(171, 35);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 1;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(9, 35);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 0;
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoArticulo.Location = new System.Drawing.Point(804, 220);
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
            this.btnModificarArticulo.Location = new System.Drawing.Point(804, 274);
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
            this.btnDetallesArticulo.Location = new System.Drawing.Point(804, 313);
            this.btnDetallesArticulo.Name = "btnDetallesArticulo";
            this.btnDetallesArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnDetallesArticulo.TabIndex = 10;
            this.btnDetallesArticulo.Text = "Detalles";
            this.btnDetallesArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(804, 367);
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
            this.grpBUniversal.Location = new System.Drawing.Point(921, 112);
            this.grpBUniversal.Name = "grpBUniversal";
            this.grpBUniversal.Size = new System.Drawing.Size(500, 637);
            this.grpBUniversal.TabIndex = 12;
            this.grpBUniversal.TabStop = false;
            // 
            // pnlUniversal
            // 
            this.pnlUniversal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUniversal.Location = new System.Drawing.Point(3, 16);
            this.pnlUniversal.Name = "pnlUniversal";
            this.pnlUniversal.Size = new System.Drawing.Size(494, 618);
            this.pnlUniversal.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.AccessibleName = "pbLogo";
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.Image = global::TPWinForm_equipo_22A.Properties.Resources.handle_with_care_100;
            this.pbLogo.Location = new System.Drawing.Point(1223, 24);
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
            this.ClientSize = new System.Drawing.Size(1122, 645);
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
            this.MinimumSize = new System.Drawing.Size(962, 539);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion de gestion";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.tlsSuperior.ResumeLayout(false);
            this.tlsSuperior.PerformLayout();
            this.tcMenu.ResumeLayout(false);
            this.Articulos.ResumeLayout(false);
            this.grpBListaArticulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.Marcas.ResumeLayout(false);
            this.grpBListaMarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.Categorias.ResumeLayout(false);
            this.grpCategorias.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtBPrecioDesde;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.RadioButton rdBFiltroXMarca;
        private System.Windows.Forms.Label lblFiltroMarca;
        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnDetallesArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.GroupBox grpBUniversal;
        private System.Windows.Forms.Panel pnlUniversal;
        private System.Windows.Forms.GroupBox grpCategorias;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox grpBListaMarcas;
        private System.Windows.Forms.RadioButton rdBFiltroXCategoria;
        private System.Windows.Forms.RadioButton rdBFiltroXPrecio;
        private System.Windows.Forms.TextBox txtBPrecioHasta;
    }
}


