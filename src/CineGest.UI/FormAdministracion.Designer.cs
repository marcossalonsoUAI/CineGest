namespace CineGest.UI
{
    partial class FormAdministracion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePeliculas = new System.Windows.Forms.TabPage();
            this.tlpPeliculas = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPeliculas = new System.Windows.Forms.Panel();
            this.lblTitPeliculas = new System.Windows.Forms.Label();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.pnlFormPelicula = new System.Windows.Forms.Panel();
            this.cmbPelicula = new System.Windows.Forms.ComboBox();
            this.lblSelPelicula = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTituloPel = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelPel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPelAgregar = new System.Windows.Forms.Button();
            this.btnPelEditar = new System.Windows.Forms.Button();
            this.btnPelBorrar = new System.Windows.Forms.Button();
            this.tabPageFunciones = new System.Windows.Forms.TabPage();
            this.tlpFunciones = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFunciones = new System.Windows.Forms.Panel();
            this.lblTitFunciones = new System.Windows.Forms.Label();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.pnlFormFuncion = new System.Windows.Forms.Panel();
            this.cmbFuncionSeleccionar = new System.Windows.Forms.ComboBox();
            this.lblSelFuncion = new System.Windows.Forms.Label();
            this.cmbFuncionPelicula = new System.Windows.Forms.ComboBox();
            this.lblFuncionPelicula = new System.Windows.Forms.Label();
            this.cmbFuncionSala = new System.Windows.Forms.ComboBox();
            this.lblFuncionSala = new System.Windows.Forms.Label();
            this.dtpFuncionFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFuncionFecha = new System.Windows.Forms.Label();
            this.txtFuncionPrecio = new System.Windows.Forms.TextBox();
            this.lblFuncionPrecio = new System.Windows.Forms.Label();
            this.chkFuncionEstado = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelFuncion = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFuncionAgregar = new System.Windows.Forms.Button();
            this.btnFuncionEditar = new System.Windows.Forms.Button();
            this.btnFuncionBorrar = new System.Windows.Forms.Button();
            this.tabPageSalas = new System.Windows.Forms.TabPage();
            this.tlpSalas = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSalas = new System.Windows.Forms.Panel();
            this.lblTitSalas = new System.Windows.Forms.Label();
            this.dgvSalas = new System.Windows.Forms.DataGridView();
            this.pnlFormSala = new System.Windows.Forms.Panel();
            this.cmbSalas = new System.Windows.Forms.ComboBox();
            this.lblSelSala = new System.Windows.Forms.Label();
            this.txtNomSala = new System.Windows.Forms.TextBox();
            this.lblNomSala = new System.Windows.Forms.Label();
            this.txtTipoSala = new System.Windows.Forms.TextBox();
            this.lblTipoSala = new System.Windows.Forms.Label();
            this.txtCapacidadSala = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.flowLayoutPanelSala = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSalaGuardar = new System.Windows.Forms.Button();
            this.btnSalaEditar = new System.Windows.Forms.Button();
            this.btnSalaBorrar = new System.Windows.Forms.Button();

            this.panelHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePeliculas.SuspendLayout();
            this.tlpPeliculas.SuspendLayout();
            this.pnlPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.pnlFormPelicula.SuspendLayout();
            this.flowLayoutPanelPel.SuspendLayout();
            this.tabPageFunciones.SuspendLayout();
            this.tlpFunciones.SuspendLayout();
            this.pnlFunciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.pnlFormFuncion.SuspendLayout();
            this.flowLayoutPanelFuncion.SuspendLayout();
            this.tabPageSalas.SuspendLayout();
            this.tlpSalas.SuspendLayout();
            this.pnlSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            this.pnlFormSala.SuspendLayout();
            this.flowLayoutPanelSala.SuspendLayout();
            this.SuspendLayout();

            // FORM
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineGest - Panel de Administración";

            // HEADER
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Size = new System.Drawing.Size(1100, 70);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(30, 18);
            this.lblTitulo.Text = "Panel de Administración";

            // TAB CONTROL
            this.tabControl1.Controls.Add(this.tabPagePeliculas);
            this.tabControl1.Controls.Add(this.tabPageFunciones);
            this.tabControl1.Controls.Add(this.tabPageSalas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // TAB PELÍCULAS
            this.tabPagePeliculas.Text = "🎬 Películas";
            this.tabPagePeliculas.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.tabPagePeliculas.Controls.Add(this.tlpPeliculas);

            this.tlpPeliculas.ColumnCount = 1;
            this.tlpPeliculas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPeliculas.Controls.Add(this.pnlPeliculas, 0, 0);
            this.tlpPeliculas.Controls.Add(this.pnlFormPelicula, 0, 1);
            this.tlpPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPeliculas.RowCount = 2;
            this.tlpPeliculas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpPeliculas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpPeliculas.Padding = new System.Windows.Forms.Padding(20);

            this.pnlPeliculas.BackColor = System.Drawing.Color.White;
            this.pnlPeliculas.Controls.Add(this.lblTitPeliculas);
            this.pnlPeliculas.Controls.Add(this.dgvPeliculas);
            this.pnlPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPeliculas.Padding = new System.Windows.Forms.Padding(15);
            this.pnlPeliculas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);

            this.lblTitPeliculas.AutoSize = true;
            this.lblTitPeliculas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitPeliculas.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTitPeliculas.Location = new System.Drawing.Point(15, 10);
            this.lblTitPeliculas.Text = "PELÍCULAS EN CARTELERA";

            this.dgvPeliculas.Location = new System.Drawing.Point(15, 45);
            this.dgvPeliculas.Size = new System.Drawing.Size(1030, 250);
            this.dgvPeliculas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            this.pnlFormPelicula.BackColor = System.Drawing.Color.White;
            this.pnlFormPelicula.Controls.Add(this.cmbPelicula);
            this.pnlFormPelicula.Controls.Add(this.lblSelPelicula);
            this.pnlFormPelicula.Controls.Add(this.txtTitulo);
            this.pnlFormPelicula.Controls.Add(this.lblTituloPel);
            this.pnlFormPelicula.Controls.Add(this.txtGenero);
            this.pnlFormPelicula.Controls.Add(this.lblGenero);
            this.pnlFormPelicula.Controls.Add(this.txtDuracion);
            this.pnlFormPelicula.Controls.Add(this.lblDuracion);
            this.pnlFormPelicula.Controls.Add(this.txtDirector);
            this.pnlFormPelicula.Controls.Add(this.lblDirector);
            this.pnlFormPelicula.Controls.Add(this.chkEstado);
            this.pnlFormPelicula.Controls.Add(this.flowLayoutPanelPel);
            this.pnlFormPelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormPelicula.Padding = new System.Windows.Forms.Padding(20);

            this.lblSelPelicula.AutoSize = true; this.lblSelPelicula.Location = new System.Drawing.Point(20, 15); this.lblSelPelicula.Text = "Seleccionar para Editar/Borrar:";
            this.cmbPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPelicula.Location = new System.Drawing.Point(220, 12); this.cmbPelicula.Size = new System.Drawing.Size(400, 25);
            this.cmbPelicula.SelectedIndexChanged += new System.EventHandler(this.cmbPelicula_SelectedIndexChanged);

            this.lblTituloPel.AutoSize = true; this.lblTituloPel.Location = new System.Drawing.Point(20, 55); this.lblTituloPel.Text = "Título:";
            this.txtTitulo.Location = new System.Drawing.Point(20, 75); this.txtTitulo.Size = new System.Drawing.Size(250, 25);
            this.lblGenero.AutoSize = true; this.lblGenero.Location = new System.Drawing.Point(290, 55); this.lblGenero.Text = "Género:";
            this.txtGenero.Location = new System.Drawing.Point(290, 75); this.txtGenero.Size = new System.Drawing.Size(250, 25);
            this.lblDuracion.AutoSize = true; this.lblDuracion.Location = new System.Drawing.Point(20, 115); this.lblDuracion.Text = "Duración (min):";
            this.txtDuracion.Location = new System.Drawing.Point(20, 135); this.txtDuracion.Size = new System.Drawing.Size(250, 25);
            this.lblDirector.AutoSize = true; this.lblDirector.Location = new System.Drawing.Point(290, 115); this.lblDirector.Text = "Director:";
            this.txtDirector.Location = new System.Drawing.Point(290, 135); this.txtDirector.Size = new System.Drawing.Size(250, 25);
            this.chkEstado.AutoSize = true; this.chkEstado.Location = new System.Drawing.Point(20, 170); this.chkEstado.Text = "En Cartelera";

            this.flowLayoutPanelPel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelPel.Location = new System.Drawing.Point(20, 200);
            this.flowLayoutPanelPel.Size = new System.Drawing.Size(1030, 35);
            this.flowLayoutPanelPel.Controls.Add(this.btnPelBorrar);
            this.flowLayoutPanelPel.Controls.Add(this.btnPelEditar);
            this.flowLayoutPanelPel.Controls.Add(this.btnPelAgregar);

            this.btnPelAgregar.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnPelAgregar.FlatAppearance.BorderSize = 0; this.btnPelAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPelAgregar.ForeColor = System.Drawing.Color.White;
            this.btnPelAgregar.Size = new System.Drawing.Size(120, 32); this.btnPelAgregar.Text = "AGREGAR";
            this.btnPelAgregar.Click += new System.EventHandler(this.btnPelAgregar_Click);

            this.btnPelEditar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnPelEditar.FlatAppearance.BorderSize = 0; this.btnPelEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPelEditar.ForeColor = System.Drawing.Color.White;
            this.btnPelEditar.Size = new System.Drawing.Size(120, 32); this.btnPelEditar.Text = "EDITAR";
            this.btnPelEditar.Click += new System.EventHandler(this.btnPelEditar_Click);

            this.btnPelBorrar.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnPelBorrar.FlatAppearance.BorderSize = 0; this.btnPelBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelBorrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPelBorrar.ForeColor = System.Drawing.Color.White;
            this.btnPelBorrar.Size = new System.Drawing.Size(120, 32); this.btnPelBorrar.Text = "BORRAR";
            this.btnPelBorrar.Click += new System.EventHandler(this.btnPelBorrar_Click);

            // TAB FUNCIONES
            this.tabPageFunciones.Text = "🕒 Funciones (Precio)";
            this.tabPageFunciones.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.tabPageFunciones.Controls.Add(this.tlpFunciones);

            this.tlpFunciones.ColumnCount = 1;
            this.tlpFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFunciones.Controls.Add(this.pnlFunciones, 0, 0);
            this.tlpFunciones.Controls.Add(this.pnlFormFuncion, 0, 1);
            this.tlpFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFunciones.RowCount = 2;
            this.tlpFunciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpFunciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpFunciones.Padding = new System.Windows.Forms.Padding(20);

            this.pnlFunciones.BackColor = System.Drawing.Color.White;
            this.pnlFunciones.Controls.Add(this.lblTitFunciones);
            this.pnlFunciones.Controls.Add(this.dgvFunciones);
            this.pnlFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFunciones.Padding = new System.Windows.Forms.Padding(15);
            this.pnlFunciones.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);

            this.lblTitFunciones.AutoSize = true;
            this.lblTitFunciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitFunciones.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTitFunciones.Location = new System.Drawing.Point(15, 10);
            this.lblTitFunciones.Text = "FUNCIONES (precio por función)";

            this.dgvFunciones.Location = new System.Drawing.Point(15, 45);
            this.dgvFunciones.Size = new System.Drawing.Size(1030, 250);
            this.dgvFunciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            this.pnlFormFuncion.BackColor = System.Drawing.Color.White;
            this.pnlFormFuncion.Controls.Add(this.cmbFuncionSeleccionar);
            this.pnlFormFuncion.Controls.Add(this.lblSelFuncion);
            this.pnlFormFuncion.Controls.Add(this.cmbFuncionPelicula);
            this.pnlFormFuncion.Controls.Add(this.lblFuncionPelicula);
            this.pnlFormFuncion.Controls.Add(this.cmbFuncionSala);
            this.pnlFormFuncion.Controls.Add(this.lblFuncionSala);
            this.pnlFormFuncion.Controls.Add(this.dtpFuncionFecha);
            this.pnlFormFuncion.Controls.Add(this.lblFuncionFecha);
            this.pnlFormFuncion.Controls.Add(this.txtFuncionPrecio);
            this.pnlFormFuncion.Controls.Add(this.lblFuncionPrecio);
            this.pnlFormFuncion.Controls.Add(this.chkFuncionEstado);
            this.pnlFormFuncion.Controls.Add(this.flowLayoutPanelFuncion);
            this.pnlFormFuncion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormFuncion.Padding = new System.Windows.Forms.Padding(20);

            this.lblSelFuncion.AutoSize = true; this.lblSelFuncion.Location = new System.Drawing.Point(20, 15); this.lblSelFuncion.Text = "Seleccionar para Editar/Borrar:";
            this.cmbFuncionSeleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionSeleccionar.Location = new System.Drawing.Point(220, 12); this.cmbFuncionSeleccionar.Size = new System.Drawing.Size(500, 25);
            this.cmbFuncionSeleccionar.SelectedIndexChanged += new System.EventHandler(this.cmbFuncionSeleccionar_SelectedIndexChanged);

            this.lblFuncionPelicula.AutoSize = true; this.lblFuncionPelicula.Location = new System.Drawing.Point(20, 55); this.lblFuncionPelicula.Text = "Película:";
            this.cmbFuncionPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionPelicula.Location = new System.Drawing.Point(20, 75); this.cmbFuncionPelicula.Size = new System.Drawing.Size(250, 25);

            this.lblFuncionSala.AutoSize = true; this.lblFuncionSala.Location = new System.Drawing.Point(290, 55); this.lblFuncionSala.Text = "Sala:";
            this.cmbFuncionSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionSala.Location = new System.Drawing.Point(290, 75); this.cmbFuncionSala.Size = new System.Drawing.Size(200, 25);

            this.lblFuncionFecha.AutoSize = true; this.lblFuncionFecha.Location = new System.Drawing.Point(510, 55); this.lblFuncionFecha.Text = "Fecha/Hora:";
            this.dtpFuncionFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFuncionFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFuncionFecha.ShowUpDown = true;
            this.dtpFuncionFecha.Location = new System.Drawing.Point(510, 75); this.dtpFuncionFecha.Size = new System.Drawing.Size(200, 25);

            this.lblFuncionPrecio.AutoSize = true; this.lblFuncionPrecio.Location = new System.Drawing.Point(20, 115); this.lblFuncionPrecio.Text = "Precio ($):";
            this.txtFuncionPrecio.Location = new System.Drawing.Point(20, 135); this.txtFuncionPrecio.Size = new System.Drawing.Size(200, 25);

            this.chkFuncionEstado.AutoSize = true; this.chkFuncionEstado.Location = new System.Drawing.Point(240, 137); this.chkFuncionEstado.Text = "Activa";

            this.flowLayoutPanelFuncion.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelFuncion.Location = new System.Drawing.Point(20, 180);
            this.flowLayoutPanelFuncion.Size = new System.Drawing.Size(1030, 35);
            this.flowLayoutPanelFuncion.Controls.Add(this.btnFuncionBorrar);
            this.flowLayoutPanelFuncion.Controls.Add(this.btnFuncionEditar);
            this.flowLayoutPanelFuncion.Controls.Add(this.btnFuncionAgregar);

            this.btnFuncionAgregar.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnFuncionAgregar.FlatAppearance.BorderSize = 0; this.btnFuncionAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFuncionAgregar.ForeColor = System.Drawing.Color.White;
            this.btnFuncionAgregar.Size = new System.Drawing.Size(140, 32); this.btnFuncionAgregar.Text = "AGREGAR FUNCIÓN";
            this.btnFuncionAgregar.Click += new System.EventHandler(this.btnFuncionAgregar_Click);

            this.btnFuncionEditar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnFuncionEditar.FlatAppearance.BorderSize = 0; this.btnFuncionEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFuncionEditar.ForeColor = System.Drawing.Color.White;
            this.btnFuncionEditar.Size = new System.Drawing.Size(140, 32); this.btnFuncionEditar.Text = "EDITAR FUNCIÓN";
            this.btnFuncionEditar.Click += new System.EventHandler(this.btnFuncionEditar_Click);

            this.btnFuncionBorrar.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnFuncionBorrar.FlatAppearance.BorderSize = 0; this.btnFuncionBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionBorrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFuncionBorrar.ForeColor = System.Drawing.Color.White;
            this.btnFuncionBorrar.Size = new System.Drawing.Size(140, 32); this.btnFuncionBorrar.Text = "DESACTIVAR FUNCIÓN";
            this.btnFuncionBorrar.Click += new System.EventHandler(this.btnFuncionBorrar_Click);

            // TAB SALAS
            this.tabPageSalas.Text = "🏢 Salas";
            this.tabPageSalas.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.tabPageSalas.Controls.Add(this.tlpSalas);

            this.tlpSalas.ColumnCount = 1;
            this.tlpSalas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalas.Controls.Add(this.pnlSalas, 0, 0);
            this.tlpSalas.Controls.Add(this.pnlFormSala, 0, 1);
            this.tlpSalas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSalas.RowCount = 2;
            this.tlpSalas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpSalas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpSalas.Padding = new System.Windows.Forms.Padding(20);

            this.pnlSalas.BackColor = System.Drawing.Color.White;
            this.pnlSalas.Controls.Add(this.lblTitSalas);
            this.pnlSalas.Controls.Add(this.dgvSalas);
            this.pnlSalas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalas.Padding = new System.Windows.Forms.Padding(15);
            this.pnlSalas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);

            this.lblTitSalas.AutoSize = true;
            this.lblTitSalas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitSalas.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTitSalas.Location = new System.Drawing.Point(15, 10);
            this.lblTitSalas.Text = "SALAS DEL CINE";

            this.dgvSalas.Location = new System.Drawing.Point(15, 45);
            this.dgvSalas.Size = new System.Drawing.Size(1030, 250);
            this.dgvSalas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            this.pnlFormSala.BackColor = System.Drawing.Color.White;
            this.pnlFormSala.Controls.Add(this.cmbSalas);
            this.pnlFormSala.Controls.Add(this.lblSelSala);
            this.pnlFormSala.Controls.Add(this.txtNomSala);
            this.pnlFormSala.Controls.Add(this.lblNomSala);
            this.pnlFormSala.Controls.Add(this.txtTipoSala);
            this.pnlFormSala.Controls.Add(this.lblTipoSala);
            this.pnlFormSala.Controls.Add(this.txtCapacidadSala);
            this.pnlFormSala.Controls.Add(this.lblCapacidad);
            this.pnlFormSala.Controls.Add(this.flowLayoutPanelSala);
            this.pnlFormSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormSala.Padding = new System.Windows.Forms.Padding(20);

            this.lblSelSala.AutoSize = true; this.lblSelSala.Location = new System.Drawing.Point(20, 15); this.lblSelSala.Text = "Seleccionar para Editar/Borrar:";
            this.cmbSalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalas.Location = new System.Drawing.Point(220, 12); this.cmbSalas.Size = new System.Drawing.Size(400, 25);
            this.cmbSalas.SelectedIndexChanged += new System.EventHandler(this.cmbSalas_SelectedIndexChanged);

            this.lblNomSala.AutoSize = true; this.lblNomSala.Location = new System.Drawing.Point(20, 55); this.lblNomSala.Text = "Nombre:";
            this.txtNomSala.Location = new System.Drawing.Point(20, 75); this.txtNomSala.Size = new System.Drawing.Size(250, 25);
            this.lblCapacidad.AutoSize = true; this.lblCapacidad.Location = new System.Drawing.Point(290, 55); this.lblCapacidad.Text = "Capacidad:";
            this.txtCapacidadSala.Location = new System.Drawing.Point(290, 75); this.txtCapacidadSala.Size = new System.Drawing.Size(200, 25);
            this.lblTipoSala.AutoSize = true; this.lblTipoSala.Location = new System.Drawing.Point(510, 55); this.lblTipoSala.Text = "Tipo:";
            this.txtTipoSala.Location = new System.Drawing.Point(510, 75); this.txtTipoSala.Size = new System.Drawing.Size(200, 25);

            this.flowLayoutPanelSala.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelSala.Location = new System.Drawing.Point(20, 130);
            this.flowLayoutPanelSala.Size = new System.Drawing.Size(1030, 35);
            this.flowLayoutPanelSala.Controls.Add(this.btnSalaBorrar);
            this.flowLayoutPanelSala.Controls.Add(this.btnSalaEditar);
            this.flowLayoutPanelSala.Controls.Add(this.btnSalaGuardar);

            this.btnSalaGuardar.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnSalaGuardar.FlatAppearance.BorderSize = 0; this.btnSalaGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalaGuardar.ForeColor = System.Drawing.Color.White;
            this.btnSalaGuardar.Size = new System.Drawing.Size(120, 32); this.btnSalaGuardar.Text = "GUARDAR";
            this.btnSalaGuardar.Click += new System.EventHandler(this.btnSalaGuardar_Click);

            this.btnSalaEditar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSalaEditar.FlatAppearance.BorderSize = 0; this.btnSalaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalaEditar.ForeColor = System.Drawing.Color.White;
            this.btnSalaEditar.Size = new System.Drawing.Size(120, 32); this.btnSalaEditar.Text = "EDITAR";
            this.btnSalaEditar.Click += new System.EventHandler(this.btnSalaEditar_Click);

            this.btnSalaBorrar.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnSalaBorrar.FlatAppearance.BorderSize = 0; this.btnSalaBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaBorrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalaBorrar.ForeColor = System.Drawing.Color.White;
            this.btnSalaBorrar.Size = new System.Drawing.Size(120, 32); this.btnSalaBorrar.Text = "BORRAR";
            this.btnSalaBorrar.Click += new System.EventHandler(this.btnSalaBorrar_Click);

            // ENSAMBLAJE
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelHeader);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePeliculas.ResumeLayout(false);
            this.tlpPeliculas.ResumeLayout(false);
            this.pnlPeliculas.ResumeLayout(false);
            this.pnlPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.pnlFormPelicula.ResumeLayout(false);
            this.pnlFormPelicula.PerformLayout();
            this.flowLayoutPanelPel.ResumeLayout(false);
            this.tabPageFunciones.ResumeLayout(false);
            this.tlpFunciones.ResumeLayout(false);
            this.pnlFunciones.ResumeLayout(false);
            this.pnlFunciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.pnlFormFuncion.ResumeLayout(false);
            this.pnlFormFuncion.PerformLayout();
            this.flowLayoutPanelFuncion.ResumeLayout(false);
            this.tabPageSalas.ResumeLayout(false);
            this.tlpSalas.ResumeLayout(false);
            this.pnlSalas.ResumeLayout(false);
            this.pnlSalas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
            this.pnlFormSala.ResumeLayout(false);
            this.pnlFormSala.PerformLayout();
            this.flowLayoutPanelSala.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePeliculas;
        private System.Windows.Forms.TableLayoutPanel tlpPeliculas;
        private System.Windows.Forms.Panel pnlPeliculas;
        private System.Windows.Forms.Label lblTitPeliculas;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Panel pnlFormPelicula;
        private System.Windows.Forms.ComboBox cmbPelicula;
        private System.Windows.Forms.Label lblSelPelicula;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTituloPel;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPel;
        private System.Windows.Forms.Button btnPelAgregar;
        private System.Windows.Forms.Button btnPelEditar;
        private System.Windows.Forms.Button btnPelBorrar;
        private System.Windows.Forms.TabPage tabPageFunciones;
        private System.Windows.Forms.TableLayoutPanel tlpFunciones;
        private System.Windows.Forms.Panel pnlFunciones;
        private System.Windows.Forms.Label lblTitFunciones;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.Panel pnlFormFuncion;
        private System.Windows.Forms.ComboBox cmbFuncionSeleccionar;
        private System.Windows.Forms.Label lblSelFuncion;
        private System.Windows.Forms.ComboBox cmbFuncionPelicula;
        private System.Windows.Forms.Label lblFuncionPelicula;
        private System.Windows.Forms.ComboBox cmbFuncionSala;
        private System.Windows.Forms.Label lblFuncionSala;
        private System.Windows.Forms.DateTimePicker dtpFuncionFecha;
        private System.Windows.Forms.Label lblFuncionFecha;
        private System.Windows.Forms.TextBox txtFuncionPrecio;
        private System.Windows.Forms.Label lblFuncionPrecio;
        private System.Windows.Forms.CheckBox chkFuncionEstado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFuncion;
        private System.Windows.Forms.Button btnFuncionAgregar;
        private System.Windows.Forms.Button btnFuncionEditar;
        private System.Windows.Forms.Button btnFuncionBorrar;
        private System.Windows.Forms.TabPage tabPageSalas;
        private System.Windows.Forms.TableLayoutPanel tlpSalas;
        private System.Windows.Forms.Panel pnlSalas;
        private System.Windows.Forms.Label lblTitSalas;
        private System.Windows.Forms.DataGridView dgvSalas;
        private System.Windows.Forms.Panel pnlFormSala;
        private System.Windows.Forms.ComboBox cmbSalas;
        private System.Windows.Forms.Label lblSelSala;
        private System.Windows.Forms.TextBox txtNomSala;
        private System.Windows.Forms.Label lblNomSala;
        private System.Windows.Forms.TextBox txtTipoSala;
        private System.Windows.Forms.Label lblTipoSala;
        private System.Windows.Forms.TextBox txtCapacidadSala;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSala;
        private System.Windows.Forms.Button btnSalaGuardar;
        private System.Windows.Forms.Button btnSalaEditar;
        private System.Windows.Forms.Button btnSalaBorrar;
    }
}