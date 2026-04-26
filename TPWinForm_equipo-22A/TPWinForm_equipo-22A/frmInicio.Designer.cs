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
            this.stsInferior = new System.Windows.Forms.StatusStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsSuperior = new System.Windows.Forms.ToolStrip();
            this.txtBBuscarSuperior = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            this.rdBFiltroXMarca = new System.Windows.Forms.RadioButton();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.rdBFiltroXCategoria = new System.Windows.Forms.RadioButton();
            this.rdBFiltroXBuscar = new System.Windows.Forms.RadioButton();
            this.grBBarraBusqueda = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.Articulos = new System.Windows.Forms.TabPage();
            this.grpBListaArticulo = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFiltroArticulos = new System.Windows.Forms.Panel();
            this.btnBuscarArticulos = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtBFiltro = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.Marcas = new System.Windows.Forms.TabPage();
            this.grpBListaMarcas = new System.Windows.Forms.GroupBox();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.Categorias = new System.Windows.Forms.TabPage();
            this.grpCategorias = new System.Windows.Forms.GroupBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpBUniversal = new System.Windows.Forms.GroupBox();
            this.pnlUniversal = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnDetallesArticulo = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tlsSuperior.SuspendLayout();
            this.grBBarraBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcMenu.SuspendLayout();
            this.Articulos.SuspendLayout();
            this.grpBListaArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.pnlFiltroArticulos.SuspendLayout();
            this.Marcas.SuspendLayout();
            this.grpBListaMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.Categorias.SuspendLayout();
            this.grpCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpBUniversal.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsInferior
            // 
            this.stsInferior.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.stsInferior.Location = new System.Drawing.Point(0, 659);
            this.stsInferior.Name = "stsInferior";
            this.stsInferior.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.stsInferior.Size = new System.Drawing.Size(1264, 22);
            this.stsInferior.TabIndex = 6;
            this.stsInferior.Text = "statusStrip1";
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
            // txtBBuscarSuperior
            // 
            this.txtBBuscarSuperior.Location = new System.Drawing.Point(380, 36);
            this.txtBBuscarSuperior.Margin = new System.Windows.Forms.Padding(1);
            this.txtBBuscarSuperior.Name = "txtBBuscarSuperior";
            this.txtBBuscarSuperior.Size = new System.Drawing.Size(157, 20);
            this.txtBBuscarSuperior.TabIndex = 4;
            this.txtBBuscarSuperior.TextChanged += new System.EventHandler(this.txtBBuscarSuperior_TextChanged);
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(31, 36);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(104, 21);
            this.cboMarca.TabIndex = 0;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(192, 36);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(104, 21);
            this.cboCategoria.TabIndex = 1;
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Location = new System.Drawing.Point(37, 8);
            this.lblFiltroMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(0, 13);
            this.lblFiltroMarca.TabIndex = 3;
            // 
            // rdBFiltroXMarca
            // 
            this.rdBFiltroXMarca.AutoSize = true;
            this.rdBFiltroXMarca.BackColor = System.Drawing.Color.Transparent;
            this.rdBFiltroXMarca.Location = new System.Drawing.Point(31, 17);
            this.rdBFiltroXMarca.Margin = new System.Windows.Forms.Padding(2);
            this.rdBFiltroXMarca.Name = "rdBFiltroXMarca";
            this.rdBFiltroXMarca.Size = new System.Drawing.Size(55, 17);
            this.rdBFiltroXMarca.TabIndex = 6;
            this.rdBFiltroXMarca.TabStop = true;
            this.rdBFiltroXMarca.Text = "Marca";
            this.rdBFiltroXMarca.UseVisualStyleBackColor = false;
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Location = new System.Drawing.Point(242, 8);
            this.lblFiltroEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(0, 13);
            this.lblFiltroEstado.TabIndex = 7;
            // 
            // rdBFiltroXCategoria
            // 
            this.rdBFiltroXCategoria.AutoSize = true;
            this.rdBFiltroXCategoria.BackColor = System.Drawing.Color.Transparent;
            this.rdBFiltroXCategoria.Location = new System.Drawing.Point(200, 17);
            this.rdBFiltroXCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.rdBFiltroXCategoria.Name = "rdBFiltroXCategoria";
            this.rdBFiltroXCategoria.Size = new System.Drawing.Size(70, 17);
            this.rdBFiltroXCategoria.TabIndex = 8;
            this.rdBFiltroXCategoria.TabStop = true;
            this.rdBFiltroXCategoria.Text = "Categoria";
            this.rdBFiltroXCategoria.UseVisualStyleBackColor = false;
            // 
            // rdBFiltroXBuscar
            // 
            this.rdBFiltroXBuscar.AutoSize = true;
            this.rdBFiltroXBuscar.BackColor = System.Drawing.Color.Transparent;
            this.rdBFiltroXBuscar.Checked = true;
            this.rdBFiltroXBuscar.Location = new System.Drawing.Point(388, 17);
            this.rdBFiltroXBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.rdBFiltroXBuscar.Name = "rdBFiltroXBuscar";
            this.rdBFiltroXBuscar.Size = new System.Drawing.Size(58, 17);
            this.rdBFiltroXBuscar.TabIndex = 11;
            this.rdBFiltroXBuscar.TabStop = true;
            this.rdBFiltroXBuscar.Text = "Buscar";
            this.rdBFiltroXBuscar.UseVisualStyleBackColor = false;
            // 
            // grBBarraBusqueda
            // 
            this.grBBarraBusqueda.Controls.Add(this.rdBFiltroXBuscar);
            this.grBBarraBusqueda.Controls.Add(this.rdBFiltroXCategoria);
            this.grBBarraBusqueda.Controls.Add(this.lblFiltroEstado);
            this.grBBarraBusqueda.Controls.Add(this.txtBBuscarSuperior);
            this.grBBarraBusqueda.Controls.Add(this.rdBFiltroXMarca);
            this.grBBarraBusqueda.Controls.Add(this.lblFiltroMarca);
            this.grBBarraBusqueda.Controls.Add(this.cboCategoria);
            this.grBBarraBusqueda.Controls.Add(this.cboMarca);
            this.grBBarraBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.grBBarraBusqueda.Location = new System.Drawing.Point(0, 25);
            this.grBBarraBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.grBBarraBusqueda.Name = "grBBarraBusqueda";
            this.grBBarraBusqueda.Padding = new System.Windows.Forms.Padding(2);
            this.grBBarraBusqueda.Size = new System.Drawing.Size(1264, 62);
            this.grBBarraBusqueda.TabIndex = 7;
            this.grBBarraBusqueda.TabStop = false;
            this.grBBarraBusqueda.Text = "Filtrar Articulos";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleDescription = "scpnl1";
            this.splitContainer1.Panel1.Controls.Add(this.tcMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleDescription = "scpnl2";
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.pnlButtons);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 572);
            this.splitContainer1.SplitterDistance = 632;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 13;
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.Articulos);
            this.tcMenu.Controls.Add(this.Marcas);
            this.tcMenu.Controls.Add(this.Categorias);
            this.tcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMenu.Location = new System.Drawing.Point(0, 0);
            this.tcMenu.Margin = new System.Windows.Forms.Padding(1);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(632, 572);
            this.tcMenu.TabIndex = 5;
            this.tcMenu.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Articulos
            // 
            this.Articulos.Controls.Add(this.grpBListaArticulo);
            this.Articulos.Location = new System.Drawing.Point(4, 22);
            this.Articulos.Margin = new System.Windows.Forms.Padding(1);
            this.Articulos.Name = "Articulos";
            this.Articulos.Padding = new System.Windows.Forms.Padding(1);
            this.Articulos.Size = new System.Drawing.Size(624, 546);
            this.Articulos.TabIndex = 0;
            this.Articulos.Text = "Articulos";
            this.Articulos.UseVisualStyleBackColor = true;
            // 
            // grpBListaArticulo
            // 
            this.grpBListaArticulo.Controls.Add(this.dgvArticulos);
            this.grpBListaArticulo.Controls.Add(this.pnlFiltroArticulos);
            this.grpBListaArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBListaArticulo.Location = new System.Drawing.Point(1, 1);
            this.grpBListaArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.grpBListaArticulo.Name = "grpBListaArticulo";
            this.grpBListaArticulo.Padding = new System.Windows.Forms.Padding(2);
            this.grpBListaArticulo.Size = new System.Drawing.Size(622, 544);
            this.grpBListaArticulo.TabIndex = 0;
            this.grpBListaArticulo.TabStop = false;
            this.grpBListaArticulo.Text = "Listado de Articulos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.NullValue = "0";
            this.dgvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Descripción,
            this.Precio});
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.Location = new System.Drawing.Point(2, 15);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(1);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 82;
            this.dgvArticulos.RowTemplate.Height = 33;
            this.dgvArticulos.Size = new System.Drawing.Size(618, 467);
            this.dgvArticulos.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.DataPropertyName = "Codigo";
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 10;
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 10;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "Descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 10;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 200;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 10;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 200;
            // 
            // pnlFiltroArticulos
            // 
            this.pnlFiltroArticulos.Controls.Add(this.btnBuscarArticulos);
            this.pnlFiltroArticulos.Controls.Add(this.lblFiltro);
            this.pnlFiltroArticulos.Controls.Add(this.txtBFiltro);
            this.pnlFiltroArticulos.Controls.Add(this.cboCriterio);
            this.pnlFiltroArticulos.Controls.Add(this.cboCampo);
            this.pnlFiltroArticulos.Controls.Add(this.lblCriterio);
            this.pnlFiltroArticulos.Controls.Add(this.lblCampo);
            this.pnlFiltroArticulos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFiltroArticulos.Location = new System.Drawing.Point(2, 482);
            this.pnlFiltroArticulos.Name = "pnlFiltroArticulos";
            this.pnlFiltroArticulos.Size = new System.Drawing.Size(618, 60);
            this.pnlFiltroArticulos.TabIndex = 1;
            // 
            // btnBuscarArticulos
            // 
            this.btnBuscarArticulos.Location = new System.Drawing.Point(536, 18);
            this.btnBuscarArticulos.Name = "btnBuscarArticulos";
            this.btnBuscarArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarArticulos.TabIndex = 6;
            this.btnBuscarArticulos.Text = "Buscar";
            this.btnBuscarArticulos.UseVisualStyleBackColor = true;
            this.btnBuscarArticulos.Click += new System.EventHandler(this.btnBuscarArticulos_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(366, 22);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txtBFiltro
            // 
            this.txtBFiltro.Location = new System.Drawing.Point(404, 19);
            this.txtBFiltro.Name = "txtBFiltro";
            this.txtBFiltro.Size = new System.Drawing.Size(116, 20);
            this.txtBFiltro.TabIndex = 4;
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(230, 19);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(100, 21);
            this.cboCriterio.TabIndex = 3;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(55, 20);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(100, 21);
            this.cboCampo.TabIndex = 2;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(182, 23);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 1;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(6, 24);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo:";
            // 
            // Marcas
            // 
            this.Marcas.Controls.Add(this.grpBListaMarcas);
            this.Marcas.Location = new System.Drawing.Point(4, 22);
            this.Marcas.Margin = new System.Windows.Forms.Padding(1);
            this.Marcas.Name = "Marcas";
            this.Marcas.Padding = new System.Windows.Forms.Padding(1);
            this.Marcas.Size = new System.Drawing.Size(473, 417);
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
            this.grpBListaMarcas.Location = new System.Drawing.Point(2, 3);
            this.grpBListaMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.grpBListaMarcas.Name = "grpBListaMarcas";
            this.grpBListaMarcas.Padding = new System.Windows.Forms.Padding(2);
            this.grpBListaMarcas.Size = new System.Drawing.Size(344, 393);
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
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(2, 16);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(1);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 82;
            this.dgvMarcas.RowTemplate.Height = 33;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(339, 374);
            this.dgvMarcas.TabIndex = 1;
            // 
            // Categorias
            // 
            this.Categorias.Controls.Add(this.grpCategorias);
            this.Categorias.Location = new System.Drawing.Point(4, 22);
            this.Categorias.Margin = new System.Windows.Forms.Padding(1);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(473, 417);
            this.Categorias.TabIndex = 2;
            this.Categorias.Text = "Categorias";
            this.Categorias.UseVisualStyleBackColor = true;
            // 
            // grpCategorias
            // 
            this.grpCategorias.Controls.Add(this.dgvCategorias);
            this.grpCategorias.Location = new System.Drawing.Point(0, 0);
            this.grpCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.grpCategorias.Name = "grpCategorias";
            this.grpCategorias.Padding = new System.Windows.Forms.Padding(2);
            this.grpCategorias.Size = new System.Drawing.Size(624, 546);
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
            this.dgvCategorias.Location = new System.Drawing.Point(2, 16);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(1);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 82;
            this.dgvCategorias.RowTemplate.Height = 33;
            this.dgvCategorias.Size = new System.Drawing.Size(619, 527);
            this.dgvCategorias.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpBUniversal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(84, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 572);
            this.panel2.TabIndex = 14;
            // 
            // grpBUniversal
            // 
            this.grpBUniversal.Controls.Add(this.pnlUniversal);
            this.grpBUniversal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBUniversal.Location = new System.Drawing.Point(0, 0);
            this.grpBUniversal.Margin = new System.Windows.Forms.Padding(2);
            this.grpBUniversal.Name = "grpBUniversal";
            this.grpBUniversal.Padding = new System.Windows.Forms.Padding(2);
            this.grpBUniversal.Size = new System.Drawing.Size(546, 572);
            this.grpBUniversal.TabIndex = 12;
            this.grpBUniversal.TabStop = false;
            // 
            // pnlUniversal
            // 
            this.pnlUniversal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUniversal.Location = new System.Drawing.Point(2, 15);
            this.pnlUniversal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUniversal.Name = "pnlUniversal";
            this.pnlUniversal.Size = new System.Drawing.Size(542, 555);
            this.pnlUniversal.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.pbLogo);
            this.pnlButtons.Controls.Add(this.btnNuevoArticulo);
            this.pnlButtons.Controls.Add(this.btnEliminarArticulo);
            this.pnlButtons.Controls.Add(this.btnModificarArticulo);
            this.pnlButtons.Controls.Add(this.btnDetallesArticulo);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(84, 572);
            this.pnlButtons.TabIndex = 13;
            // 
            // pbLogo
            // 
            this.pbLogo.AccessibleName = "pbLogo";
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::TPWinForm_equipo_22A.Properties.Resources.handle_with_care_100;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(84, 70);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoArticulo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoArticulo.Location = new System.Drawing.Point(6, 209);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(75, 24);
            this.btnNuevoArticulo.TabIndex = 8;
            this.btnNuevoArticulo.Text = "Nuevo";
            this.btnNuevoArticulo.UseVisualStyleBackColor = false;
            this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(6, 339);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(75, 24);
            this.btnEliminarArticulo.TabIndex = 11;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarArticulo.Location = new System.Drawing.Point(6, 256);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(75, 24);
            this.btnModificarArticulo.TabIndex = 9;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = false;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnDetallesArticulo
            // 
            this.btnDetallesArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetallesArticulo.BackColor = System.Drawing.Color.Transparent;
            this.btnDetallesArticulo.Location = new System.Drawing.Point(6, 295);
            this.btnDetallesArticulo.Name = "btnDetallesArticulo";
            this.btnDetallesArticulo.Size = new System.Drawing.Size(75, 24);
            this.btnDetallesArticulo.TabIndex = 10;
            this.btnDetallesArticulo.Text = "Detalles";
            this.btnDetallesArticulo.UseVisualStyleBackColor = false;
            this.btnDetallesArticulo.Click += new System.EventHandler(this.btnDetallesArticulo_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainer1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 87);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1264, 572);
            this.pnlMain.TabIndex = 13;
            // 
            // frmInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.grBBarraBusqueda);
            this.Controls.Add(this.stsInferior);
            this.Controls.Add(this.tlsSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(952, 509);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion de gestion";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.tlsSuperior.ResumeLayout(false);
            this.tlsSuperior.PerformLayout();
            this.grBBarraBusqueda.ResumeLayout(false);
            this.grBBarraBusqueda.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tcMenu.ResumeLayout(false);
            this.Articulos.ResumeLayout(false);
            this.grpBListaArticulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.pnlFiltroArticulos.ResumeLayout(false);
            this.pnlFiltroArticulos.PerformLayout();
            this.Marcas.ResumeLayout(false);
            this.grpBListaMarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.Categorias.ResumeLayout(false);
            this.grpCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grpBUniversal.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip stsInferior;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip tlsSuperior;
        private System.Windows.Forms.TextBox txtBBuscarSuperior;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblFiltroMarca;
        private System.Windows.Forms.RadioButton rdBFiltroXMarca;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.RadioButton rdBFiltroXCategoria;
        private System.Windows.Forms.RadioButton rdBFiltroXBuscar;
        private System.Windows.Forms.GroupBox grBBarraBusqueda;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage Articulos;
        private System.Windows.Forms.GroupBox grpBListaArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TabPage Marcas;
        private System.Windows.Forms.GroupBox grpBListaMarcas;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.TabPage Categorias;
        private System.Windows.Forms.GroupBox grpCategorias;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpBUniversal;
        private System.Windows.Forms.Panel pnlUniversal;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnDetallesArticulo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Panel pnlFiltroArticulos;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtBFiltro;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnBuscarArticulos;
    }
}


