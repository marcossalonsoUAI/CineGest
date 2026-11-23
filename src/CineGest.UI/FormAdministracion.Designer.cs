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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
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
            this.tlpMain.SuspendLayout();
            this.pnlPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.pnlFormPelicula.SuspendLayout();
            this.flowLayoutPanelPel.SuspendLayout();
            this.pnlSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            this.pnlFormSala.SuspendLayout();
            this.flowLayoutPanelSala.SuspendLayout();
            this.SuspendLayout();

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineGest - Panel de Administración";

            
            
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 70);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(30, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Panel de Administración";

           
            // LAYOUT PRINCIPAL (2 Columnas)
           
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.pnlPeliculas, 0, 0);
            this.tlpMain.Controls.Add(this.pnlSalas, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 70);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(20);
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1100, 580);

           
            // COLUMNA IZQUIERDA: PELÍCULAS
           
            this.pnlPeliculas.BackColor = System.Drawing.Color.White;
            this.pnlPeliculas.Controls.Add(this.lblTitPeliculas);
            this.pnlPeliculas.Controls.Add(this.dgvPeliculas);
            this.pnlPeliculas.Controls.Add(this.pnlFormPelicula);
            this.pnlPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPeliculas.Name = "pnlPeliculas";
            this.pnlPeliculas.Padding = new System.Windows.Forms.Padding(20);
            this.pnlPeliculas.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);

            this.lblTitPeliculas.AutoSize = true;
            this.lblTitPeliculas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitPeliculas.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTitPeliculas.Location = new System.Drawing.Point(20, 20);
            this.lblTitPeliculas.Name = "lblTitPeliculas";
            this.lblTitPeliculas.Text = "🎬 Gestión de Películas";

            this.dgvPeliculas.Location = new System.Drawing.Point(20, 50);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.Size = new System.Drawing.Size(490, 200);
            this.dgvPeliculas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            this.pnlFormPelicula.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.pnlFormPelicula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormPelicula.Location = new System.Drawing.Point(20, 270);
            this.pnlFormPelicula.Name = "pnlFormPelicula";
            this.pnlFormPelicula.Size = new System.Drawing.Size(490, 260);
            this.pnlFormPelicula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormPelicula.Padding = new System.Windows.Forms.Padding(20);

            this.lblSelPelicula.AutoSize = true;
            this.lblSelPelicula.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelPelicula.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblSelPelicula.Location = new System.Drawing.Point(20, 20);
            this.lblSelPelicula.Name = "lblSelPelicula";
            this.lblSelPelicula.Text = "Seleccionar para Editar/Borrar:";

            this.cmbPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPelicula.Location = new System.Drawing.Point(20, 40);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.Size = new System.Drawing.Size(440, 25);
            this.cmbPelicula.SelectedIndexChanged += new System.EventHandler(this.cmbPelicula_SelectedIndexChanged);

            this.lblTituloPel.AutoSize = true;
            this.lblTituloPel.Location = new System.Drawing.Point(20, 80);
            this.lblTituloPel.Name = "lblTituloPel";
            this.lblTituloPel.Text = "Título:";

            this.txtTitulo.Location = new System.Drawing.Point(20, 100);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(210, 25);
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(250, 80);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Text = "Género:";

            this.txtGenero.Location = new System.Drawing.Point(250, 100);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(210, 25);
            this.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(20, 140);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Text = "Duración (min):";

            this.txtDuracion.Location = new System.Drawing.Point(20, 160);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(210, 25);
            this.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(250, 140);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Text = "Director:";

            this.txtDirector.Location = new System.Drawing.Point(250, 160);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(210, 25);
            this.txtDirector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkEstado.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.chkEstado.Location = new System.Drawing.Point(20, 200);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(120, 20);
            this.chkEstado.Text = "En Cartelera";
            this.chkEstado.UseVisualStyleBackColor = true;

            this.flowLayoutPanelPel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelPel.Location = new System.Drawing.Point(20, 220);
            this.flowLayoutPanelPel.Name = "flowLayoutPanelPel";
            this.flowLayoutPanelPel.Size = new System.Drawing.Size(440, 30);

            this.btnPelAgregar.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnPelAgregar.FlatAppearance.BorderSize = 0;
            this.btnPelAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPelAgregar.ForeColor = System.Drawing.Color.White;
            this.btnPelAgregar.Location = new System.Drawing.Point(320, 0);
            this.btnPelAgregar.Name = "btnPelAgregar";
            this.btnPelAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnPelAgregar.Text = "AGREGAR";
            this.btnPelAgregar.Click += new System.EventHandler(this.btnPelAgregar_Click);

            this.btnPelEditar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnPelEditar.FlatAppearance.BorderSize = 0;
            this.btnPelEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPelEditar.ForeColor = System.Drawing.Color.White;
            this.btnPelEditar.Location = new System.Drawing.Point(210, 0);
            this.btnPelEditar.Name = "btnPelEditar";
            this.btnPelEditar.Size = new System.Drawing.Size(100, 30);
            this.btnPelEditar.Text = "EDITAR";
            this.btnPelEditar.Click += new System.EventHandler(this.btnPelEditar_Click);

            this.btnPelBorrar.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnPelBorrar.FlatAppearance.BorderSize = 0;
            this.btnPelBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelBorrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPelBorrar.ForeColor = System.Drawing.Color.White;
            this.btnPelBorrar.Location = new System.Drawing.Point(100, 0);
            this.btnPelBorrar.Name = "btnPelBorrar";
            this.btnPelBorrar.Size = new System.Drawing.Size(100, 30);
            this.btnPelBorrar.Text = "BORRAR";
            this.btnPelBorrar.Click += new System.EventHandler(this.btnPelBorrar_Click);

            this.flowLayoutPanelPel.Controls.Add(this.btnPelBorrar);
            this.flowLayoutPanelPel.Controls.Add(this.btnPelEditar);
            this.flowLayoutPanelPel.Controls.Add(this.btnPelAgregar); // ✅ Agregado al panel

            this.pnlFormPelicula.Controls.Add(this.lblSelPelicula);
            this.pnlFormPelicula.Controls.Add(this.cmbPelicula);
            this.pnlFormPelicula.Controls.Add(this.lblTituloPel);
            this.pnlFormPelicula.Controls.Add(this.txtTitulo);
            this.pnlFormPelicula.Controls.Add(this.lblGenero);
            this.pnlFormPelicula.Controls.Add(this.txtGenero);
            this.pnlFormPelicula.Controls.Add(this.lblDuracion);
            this.pnlFormPelicula.Controls.Add(this.txtDuracion);
            this.pnlFormPelicula.Controls.Add(this.lblDirector);
            this.pnlFormPelicula.Controls.Add(this.txtDirector);
            this.pnlFormPelicula.Controls.Add(this.chkEstado);
            this.pnlFormPelicula.Controls.Add(this.flowLayoutPanelPel);

           
            this.pnlSalas.BackColor = System.Drawing.Color.White;
            this.pnlSalas.Controls.Add(this.lblTitSalas);
            this.pnlSalas.Controls.Add(this.dgvSalas);
            this.pnlSalas.Controls.Add(this.pnlFormSala);
            this.pnlSalas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalas.Name = "pnlSalas";
            this.pnlSalas.Padding = new System.Windows.Forms.Padding(20);
            this.pnlSalas.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);

            this.lblTitSalas.AutoSize = true;
            this.lblTitSalas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitSalas.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTitSalas.Location = new System.Drawing.Point(20, 20);
            this.lblTitSalas.Name = "lblTitSalas";
            this.lblTitSalas.Text = "🏢 Gestión de Salas";

            this.dgvSalas.Location = new System.Drawing.Point(20, 50);
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.Size = new System.Drawing.Size(490, 200);
            this.dgvSalas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            this.pnlFormSala.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.pnlFormSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormSala.Location = new System.Drawing.Point(20, 270);
            this.pnlFormSala.Name = "pnlFormSala";
            this.pnlFormSala.Size = new System.Drawing.Size(490, 260);
            this.pnlFormSala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormSala.Padding = new System.Windows.Forms.Padding(20);

            this.lblSelSala.AutoSize = true;
            this.lblSelSala.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelSala.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblSelSala.Location = new System.Drawing.Point(20, 20);
            this.lblSelSala.Name = "lblSelSala";
            this.lblSelSala.Text = "Seleccionar para Editar/Borrar:";

            this.cmbSalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSalas.Location = new System.Drawing.Point(20, 40);
            this.cmbSalas.Name = "cmbSalas";
            this.cmbSalas.Size = new System.Drawing.Size(440, 25);
            this.cmbSalas.SelectedIndexChanged += new System.EventHandler(this.cmbSalas_SelectedIndexChanged);

            this.lblNomSala.AutoSize = true;
            this.lblNomSala.Location = new System.Drawing.Point(20, 80);
            this.lblNomSala.Name = "lblNomSala";
            this.lblNomSala.Text = "Nombre:";

            this.txtNomSala.Location = new System.Drawing.Point(20, 100);
            this.txtNomSala.Name = "txtNomSala";
            this.txtNomSala.Size = new System.Drawing.Size(210, 25);
            this.txtNomSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblTipoSala.AutoSize = true;
            this.lblTipoSala.Location = new System.Drawing.Point(250, 80);
            this.lblTipoSala.Name = "lblTipoSala";
            this.lblTipoSala.Text = "Tipo (ej: 2D, 3D, VIP):";

            this.txtTipoSala.Location = new System.Drawing.Point(250, 100);
            this.txtTipoSala.Name = "txtTipoSala";
            this.txtTipoSala.Size = new System.Drawing.Size(210, 25);
            this.txtTipoSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(20, 140);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Text = "Capacidad:";

            this.txtCapacidadSala.Location = new System.Drawing.Point(20, 160);
            this.txtCapacidadSala.Name = "txtCapacidadSala";
            this.txtCapacidadSala.Size = new System.Drawing.Size(210, 25);
            this.txtCapacidadSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.flowLayoutPanelSala.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelSala.Location = new System.Drawing.Point(20, 210);
            this.flowLayoutPanelSala.Name = "flowLayoutPanelSala";
            this.flowLayoutPanelSala.Size = new System.Drawing.Size(440, 30);

            this.btnSalaGuardar.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnSalaGuardar.FlatAppearance.BorderSize = 0;
            this.btnSalaGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalaGuardar.ForeColor = System.Drawing.Color.White;
            this.btnSalaGuardar.Location = new System.Drawing.Point(320, 0);
            this.btnSalaGuardar.Name = "btnSalaGuardar";
            this.btnSalaGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnSalaGuardar.Text = "GUARDAR";
            this.btnSalaGuardar.Click += new System.EventHandler(this.btnSalaGuardar_Click);

            this.btnSalaEditar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSalaEditar.FlatAppearance.BorderSize = 0;
            this.btnSalaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalaEditar.ForeColor = System.Drawing.Color.White;
            this.btnSalaEditar.Location = new System.Drawing.Point(210, 0);
            this.btnSalaEditar.Name = "btnSalaEditar";
            this.btnSalaEditar.Size = new System.Drawing.Size(100, 30);
            this.btnSalaEditar.Text = "EDITAR";
            this.btnSalaEditar.Click += new System.EventHandler(this.btnSalaEditar_Click);

            this.btnSalaBorrar.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnSalaBorrar.FlatAppearance.BorderSize = 0;
            this.btnSalaBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaBorrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalaBorrar.ForeColor = System.Drawing.Color.White;
            this.btnSalaBorrar.Location = new System.Drawing.Point(100, 0);
            this.btnSalaBorrar.Name = "btnSalaBorrar";
            this.btnSalaBorrar.Size = new System.Drawing.Size(100, 30);
            this.btnSalaBorrar.Text = "BORRAR";
            this.btnSalaBorrar.Click += new System.EventHandler(this.btnSalaBorrar_Click);

            this.flowLayoutPanelSala.Controls.Add(this.btnSalaBorrar);
            this.flowLayoutPanelSala.Controls.Add(this.btnSalaEditar);
            this.flowLayoutPanelSala.Controls.Add(this.btnSalaGuardar);

            this.pnlFormSala.Controls.Add(this.lblSelSala);
            this.pnlFormSala.Controls.Add(this.cmbSalas);
            this.pnlFormSala.Controls.Add(this.lblNomSala);
            this.pnlFormSala.Controls.Add(this.txtNomSala);
            this.pnlFormSala.Controls.Add(this.lblTipoSala);
            this.pnlFormSala.Controls.Add(this.txtTipoSala);
            this.pnlFormSala.Controls.Add(this.lblCapacidad);
            this.pnlFormSala.Controls.Add(this.txtCapacidadSala);
            this.pnlFormSala.Controls.Add(this.flowLayoutPanelSala);

           
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.panelHeader);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.pnlPeliculas.ResumeLayout(false);
            this.pnlPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.pnlFormPelicula.ResumeLayout(false);
            this.pnlFormPelicula.PerformLayout();
            this.flowLayoutPanelPel.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tlpMain;
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