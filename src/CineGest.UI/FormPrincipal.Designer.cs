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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPeliculas = new System.Windows.Forms.Panel();
            this.lblTitPeliculas = new System.Windows.Forms.Label();
            this.lblInfoPeliculas = new System.Windows.Forms.Label();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.pnlFunciones = new System.Windows.Forms.Panel();
            this.lblTitFunciones = new System.Windows.Forms.Label();
            this.lblInfoFunciones = new System.Windows.Forms.Label();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblPaso1 = new System.Windows.Forms.Label();
            this.lblFlecha = new System.Windows.Forms.Label();
            this.lblPaso2 = new System.Windows.Forms.Label();
            this.lblFlecha2 = new System.Windows.Forms.Label();
            this.lblPaso3 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();

            this.panelHeader.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pnlPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.pnlFunciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineGest - Cartelera";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);

            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.btnAdministracion);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 90);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(30, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "🎬 CineGest";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSubtitulo.Location = new System.Drawing.Point(32, 55);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Cartelera de funciones disponibles";

            this.btnAdministracion.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdministracion.ForeColor = System.Drawing.Color.White;
            this.btnAdministracion.Location = new System.Drawing.Point(1020, 28);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(160, 38);
            this.btnAdministracion.Text = "ADMINISTRACIÓN";
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);

            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.pnlPeliculas, 0, 0);
            this.tlpMain.Controls.Add(this.pnlFunciones, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 90);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(20);
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1200, 550);

            this.pnlPeliculas.BackColor = System.Drawing.Color.White;
            this.pnlPeliculas.Controls.Add(this.lblTitPeliculas);
            this.pnlPeliculas.Controls.Add(this.lblInfoPeliculas);
            this.pnlPeliculas.Controls.Add(this.dgvPeliculas);
            this.pnlPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPeliculas.Name = "pnlPeliculas";
            this.pnlPeliculas.Padding = new System.Windows.Forms.Padding(20);
            this.pnlPeliculas.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);

            this.lblTitPeliculas.AutoSize = true;
            this.lblTitPeliculas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitPeliculas.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTitPeliculas.Location = new System.Drawing.Point(20, 20);
            this.lblTitPeliculas.Name = "lblTitPeliculas";
            this.lblTitPeliculas.Text = "PELÍCULAS EN CARTELERA";

            this.lblInfoPeliculas.AutoSize = true;
            this.lblInfoPeliculas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblInfoPeliculas.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblInfoPeliculas.Location = new System.Drawing.Point(20, 45);
            this.lblInfoPeliculas.Name = "lblInfoPeliculas";
            this.lblInfoPeliculas.Text = "Haga clic en una película para ver sus funciones";

            this.dgvPeliculas.Location = new System.Drawing.Point(20, 75);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.Size = new System.Drawing.Size(540, 440);
            this.dgvPeliculas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeliculas.SelectionChanged += new System.EventHandler(this.dgvPeliculas_SelectionChanged);

            this.pnlFunciones.BackColor = System.Drawing.Color.White;
            this.pnlFunciones.Controls.Add(this.lblTitFunciones);
            this.pnlFunciones.Controls.Add(this.lblInfoFunciones);
            this.pnlFunciones.Controls.Add(this.dgvFunciones);
            this.pnlFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFunciones.Name = "pnlFunciones";
            this.pnlFunciones.Padding = new System.Windows.Forms.Padding(20);
            this.pnlFunciones.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);

            this.lblTitFunciones.AutoSize = true;
            this.lblTitFunciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitFunciones.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTitFunciones.Location = new System.Drawing.Point(20, 20);
            this.lblTitFunciones.Name = "lblTitFunciones";
            this.lblTitFunciones.Text = "FUNCIONES DISPONIBLES";

            this.lblInfoFunciones.AutoSize = true;
            this.lblInfoFunciones.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblInfoFunciones.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblInfoFunciones.Location = new System.Drawing.Point(20, 45);
            this.lblInfoFunciones.Name = "lblInfoFunciones";
            this.lblInfoFunciones.Text = "Seleccione una película para ver sus funciones disponibles";

            this.dgvFunciones.Location = new System.Drawing.Point(20, 75);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.Size = new System.Drawing.Size(540, 440);
            this.dgvFunciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFunciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunciones_CellClick);

            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Controls.Add(this.lblPaso1);
            this.panelFooter.Controls.Add(this.lblFlecha);
            this.panelFooter.Controls.Add(this.lblPaso2);
            this.panelFooter.Controls.Add(this.lblFlecha2);
            this.panelFooter.Controls.Add(this.lblPaso3);
            this.panelFooter.Controls.Add(this.btnComprar);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 640);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1200, 60);

            this.lblPaso1.AutoSize = true;
            this.lblPaso1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaso1.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblPaso1.Location = new System.Drawing.Point(30, 20);
            this.lblPaso1.Name = "lblPaso1";
            this.lblPaso1.Text = "① Elija película";

            this.lblFlecha.AutoSize = true;
            this.lblFlecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFlecha.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblFlecha.Location = new System.Drawing.Point(160, 18);
            this.lblFlecha.Name = "lblFlecha";
            this.lblFlecha.Text = "→";

            this.lblPaso2.AutoSize = true;
            this.lblPaso2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaso2.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblPaso2.Location = new System.Drawing.Point(195, 20);
            this.lblPaso2.Name = "lblPaso2";
            this.lblPaso2.Text = "② Elija función";

            this.lblFlecha2.AutoSize = true;
            this.lblFlecha2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFlecha2.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblFlecha2.Location = new System.Drawing.Point(325, 18);
            this.lblFlecha2.Name = "lblFlecha2";
            this.lblFlecha2.Text = "→";

            this.lblPaso3.AutoSize = true;
            this.lblPaso3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaso3.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblPaso3.Location = new System.Drawing.Point(360, 20);
            this.lblPaso3.Name = "lblPaso3";
            this.lblPaso3.Text = "③ Seleccione butacas";

            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(990, 12);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(190, 40);
            this.btnComprar.Text = "SELECCIONAR BUTACAS →";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Enabled = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);

            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.pnlPeliculas.ResumeLayout(false);
            this.pnlPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.pnlFunciones.ResumeLayout(false);
            this.pnlFunciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlPeliculas;
        private System.Windows.Forms.Label lblTitPeliculas;
        private System.Windows.Forms.Label lblInfoPeliculas;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Panel pnlFunciones;
        private System.Windows.Forms.Label lblTitFunciones;
        private System.Windows.Forms.Label lblInfoFunciones;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblPaso1;
        private System.Windows.Forms.Label lblFlecha;
        private System.Windows.Forms.Label lblPaso2;
        private System.Windows.Forms.Label lblFlecha2;
        private System.Windows.Forms.Label lblPaso3;
        private System.Windows.Forms.Button btnComprar;
    }
}