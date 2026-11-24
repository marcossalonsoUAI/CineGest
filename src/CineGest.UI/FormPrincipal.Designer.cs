namespace CineGest.UI
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.flpHeaderButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();

            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();

            this.pnlPeliculas = new System.Windows.Forms.Panel();
            this.tlpPeliculas = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitPeliculas = new System.Windows.Forms.Label();
            this.lblInfoPeliculas = new System.Windows.Forms.Label();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();

            this.pnlFunciones = new System.Windows.Forms.Panel();
            this.tlpFunciones = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitFunciones = new System.Windows.Forms.Label();
            this.lblInfoFunciones = new System.Windows.Forms.Label();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();

            this.panelFooter = new System.Windows.Forms.Panel();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.lblPaso1 = new System.Windows.Forms.Label();
            this.lblFlecha = new System.Windows.Forms.Label();
            this.lblPaso2 = new System.Windows.Forms.Label();
            this.lblFlecha2 = new System.Windows.Forms.Label();
            this.lblPaso3 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();

            this.panelHeader.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.flpHeaderButtons.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pnlPeliculas.SuspendLayout();
            this.tlpPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.pnlFunciones.SuspendLayout();
            this.tlpFunciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.SuspendLayout();

            // ==========================================
            // FORMULARIO PRINCIPAL
            // ==========================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineGest - Cartelera";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);

            // ==========================================
            // HEADER (TableLayoutPanel: texto flexible + botones auto)
            // ==========================================
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelHeader.Controls.Add(this.tlpHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 70;

            this.tlpHeader.ColumnCount = 2;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F)); // texto
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));       // botones
            this.tlpHeader.Controls.Add(this.lblBienvenida, 0, 0);
            this.tlpHeader.Controls.Add(this.flpHeaderButtons, 1, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);

            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBienvenida.AutoEllipsis = true;
            this.lblBienvenida.Text = "🎬 Bienvenido a CineGest";

            // FlowLayoutPanel CORREGIDO: sin Location fijo, WrapContents=false
            this.flpHeaderButtons.AutoSize = true;
            this.flpHeaderButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpHeaderButtons.WrapContents = false;
            this.flpHeaderButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpHeaderButtons.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flpHeaderButtons.Controls.Add(this.btnCerrarSesion);
            this.flpHeaderButtons.Controls.Add(this.btnCambiarPass);
            this.flpHeaderButtons.Controls.Add(this.btnIngresar);
            this.flpHeaderButtons.Controls.Add(this.btnReportes);
            this.flpHeaderButtons.Controls.Add(this.btnUsuarios);
            this.flpHeaderButtons.Controls.Add(this.btnPeliculas);
            this.flpHeaderButtons.Margin = new System.Windows.Forms.Padding(0, 17, 0, 0);

            System.Drawing.Font btnFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Windows.Forms.FlatStyle btnFlat = System.Windows.Forms.FlatStyle.Flat;
            System.Windows.Forms.Padding btnMargin = new System.Windows.Forms.Padding(6, 0, 6, 0);

            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = btnFlat;
            this.btnIngresar.Font = btnFont;
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Margin = btnMargin;
            this.btnIngresar.Size = new System.Drawing.Size(160, 36);
            this.btnIngresar.Text = "🔒 INGRESAR";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);

            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = btnFlat;
            this.btnCerrarSesion.Font = btnFont;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Margin = btnMargin;
            this.btnCerrarSesion.Size = new System.Drawing.Size(160, 36);
            this.btnCerrarSesion.Text = "🚪 CERRAR SESIÓN";
            this.btnCerrarSesion.Visible = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);

            this.btnCambiarPass.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnCambiarPass.FlatAppearance.BorderSize = 0;
            this.btnCambiarPass.FlatStyle = btnFlat;
            this.btnCambiarPass.Font = btnFont;
            this.btnCambiarPass.ForeColor = System.Drawing.Color.White;
            this.btnCambiarPass.Margin = btnMargin;
            this.btnCambiarPass.Size = new System.Drawing.Size(180, 36);
            this.btnCambiarPass.Text = "🔑 CAMBIAR CONTRASEÑA";
            this.btnCambiarPass.Visible = false;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);

            this.btnPeliculas.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnPeliculas.FlatAppearance.BorderSize = 0;
            this.btnPeliculas.FlatStyle = btnFlat;
            this.btnPeliculas.Font = btnFont;
            this.btnPeliculas.ForeColor = System.Drawing.Color.White;
            this.btnPeliculas.Margin = btnMargin;
            this.btnPeliculas.Size = new System.Drawing.Size(130, 36);
            this.btnPeliculas.Text = "🎞️ PELÍCULAS";
            this.btnPeliculas.Visible = false;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);

            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = btnFlat;
            this.btnUsuarios.Font = btnFont;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Margin = btnMargin;
            this.btnUsuarios.Size = new System.Drawing.Size(120, 36);
            this.btnUsuarios.Text = "👥 USUARIOS";
            this.btnUsuarios.Visible = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);

            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = btnFlat;
            this.btnReportes.Font = btnFont;
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Margin = btnMargin;
            this.btnReportes.Size = new System.Drawing.Size(130, 36);
            this.btnReportes.Text = "📊 REPORTES";
            this.btnReportes.Visible = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);

            // ==========================================
            // LAYOUT PRINCIPAL (50% / 50%)
            // ==========================================
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.pnlPeliculas, 0, 0);
            this.tlpMain.Controls.Add(this.pnlFunciones, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 70);
            this.tlpMain.Padding = new System.Windows.Forms.Padding(15);

            // ==========================================
            // PANEL PELÍCULAS
            // ==========================================
            this.pnlPeliculas.BackColor = System.Drawing.Color.White;
            this.pnlPeliculas.Controls.Add(this.tlpPeliculas);
            this.pnlPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPeliculas.Padding = new System.Windows.Forms.Padding(15);

            this.tlpPeliculas.ColumnCount = 1;
            this.tlpPeliculas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPeliculas.RowCount = 3;
            this.tlpPeliculas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPeliculas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPeliculas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblTitPeliculas.AutoSize = true;
            this.lblTitPeliculas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitPeliculas.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTitPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitPeliculas.Text = "PELÍCULAS EN CARTELERA";

            this.lblInfoPeliculas.AutoSize = true;
            this.lblInfoPeliculas.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblInfoPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfoPeliculas.Text = "Haga clic en una película para ver sus funciones";

            this.dgvPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPeliculas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvPeliculas.SelectionChanged += new System.EventHandler(this.dgvPeliculas_SelectionChanged);

            this.tlpPeliculas.Controls.Add(this.lblTitPeliculas, 0, 0);
            this.tlpPeliculas.Controls.Add(this.lblInfoPeliculas, 0, 1);
            this.tlpPeliculas.Controls.Add(this.dgvPeliculas, 0, 2);

            // ==========================================
            // PANEL FUNCIONES
            // ==========================================
            this.pnlFunciones.BackColor = System.Drawing.Color.White;
            this.pnlFunciones.Controls.Add(this.tlpFunciones);
            this.pnlFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFunciones.Padding = new System.Windows.Forms.Padding(15);

            this.tlpFunciones.ColumnCount = 1;
            this.tlpFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFunciones.RowCount = 3;
            this.tlpFunciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFunciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFunciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFunciones.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblTitFunciones.AutoSize = true;
            this.lblTitFunciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitFunciones.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTitFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitFunciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitFunciones.Text = "FUNCIONES DISPONIBLES";

            this.lblInfoFunciones.AutoSize = true;
            this.lblInfoFunciones.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblInfoFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoFunciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfoFunciones.Text = "Seleccione una película para ver sus funciones disponibles";

            this.dgvFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFunciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFunciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvFunciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunciones_CellClick);

            this.tlpFunciones.Controls.Add(this.lblTitFunciones, 0, 0);
            this.tlpFunciones.Controls.Add(this.lblInfoFunciones, 0, 1);
            this.tlpFunciones.Controls.Add(this.dgvFunciones, 0, 2);

            // ==========================================
            // FOOTER
            // ==========================================
            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Controls.Add(this.tlpFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Height = 60;

            this.tlpFooter.ColumnCount = 7;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooter.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);

            System.Drawing.Font pasoFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color pasoColor = System.Drawing.Color.FromArgb(37, 99, 235);

            this.lblPaso1.AutoSize = true;
            this.lblPaso1.Font = pasoFont;
            this.lblPaso1.ForeColor = pasoColor;
            this.lblPaso1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPaso1.Text = "① Elija película";

            this.lblFlecha.AutoSize = true;
            this.lblFlecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFlecha.Text = "→";

            this.lblPaso2.AutoSize = true;
            this.lblPaso2.Font = pasoFont;
            this.lblPaso2.ForeColor = pasoColor;
            this.lblPaso2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPaso2.Text = "② Elija función";

            this.lblFlecha2.AutoSize = true;
            this.lblFlecha2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFlecha2.Text = "→";

            this.lblPaso3.AutoSize = true;
            this.lblPaso3.Font = pasoFont;
            this.lblPaso3.ForeColor = pasoColor;
            this.lblPaso3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPaso3.Text = "③ Seleccione butacas";

            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.AutoSize = true;
            this.btnComprar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnComprar.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnComprar.Text = "SELECCIONAR BUTACAS →";
            this.btnComprar.Enabled = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);

            this.tlpFooter.Controls.Add(this.lblPaso1, 0, 0);
            this.tlpFooter.Controls.Add(this.lblFlecha, 1, 0);
            this.tlpFooter.Controls.Add(this.lblPaso2, 2, 0);
            this.tlpFooter.Controls.Add(this.lblFlecha2, 3, 0);
            this.tlpFooter.Controls.Add(this.lblPaso3, 4, 0);
            this.tlpFooter.Controls.Add(this.btnComprar, 6, 0);

            // ==========================================
            // ENSAMBLAJE FINAL
            // ==========================================
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);

            this.panelHeader.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.flpHeaderButtons.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.pnlPeliculas.ResumeLayout(false);
            this.tlpPeliculas.ResumeLayout(false);
            this.tlpPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.pnlFunciones.ResumeLayout(false);
            this.tlpFunciones.ResumeLayout(false);
            this.tlpFunciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.tlpFooter.ResumeLayout(false);
            this.tlpFooter.PerformLayout();
            this.ResumeLayout(false);
        }

        // ==========================================
        // DECLARACIÓN DE CONTROLES
        // ==========================================
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TableLayoutPanel tlpHeader; 
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.FlowLayoutPanel flpHeaderButtons;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCambiarPass;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnReportes;

        private System.Windows.Forms.TableLayoutPanel tlpMain;

        private System.Windows.Forms.Panel pnlPeliculas;
        private System.Windows.Forms.TableLayoutPanel tlpPeliculas;
        private System.Windows.Forms.Label lblTitPeliculas;
        private System.Windows.Forms.Label lblInfoPeliculas;
        private System.Windows.Forms.DataGridView dgvPeliculas;

        private System.Windows.Forms.Panel pnlFunciones;
        private System.Windows.Forms.TableLayoutPanel tlpFunciones;
        private System.Windows.Forms.Label lblTitFunciones;
        private System.Windows.Forms.Label lblInfoFunciones;
        private System.Windows.Forms.DataGridView dgvFunciones;

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.Label lblPaso1;
        private System.Windows.Forms.Label lblFlecha;
        private System.Windows.Forms.Label lblPaso2;
        private System.Windows.Forms.Label lblFlecha2;
        private System.Windows.Forms.Label lblPaso3;
        private System.Windows.Forms.Button btnComprar;
    }
}