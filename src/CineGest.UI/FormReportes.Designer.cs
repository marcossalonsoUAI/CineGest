namespace CineGest.UI
{
    partial class FormReportes
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblFechas = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CineGest - Reportes";

            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Size = new System.Drawing.Size(900, 60);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(30, 15);
            this.lblTitulo.Text = "📊 GENERADOR DE REPORTES";

            this.panelFiltros.BackColor = System.Drawing.Color.White;
            this.panelFiltros.Controls.Add(this.cmbTipoReporte);
            this.panelFiltros.Controls.Add(this.lblTipo);
            this.panelFiltros.Controls.Add(this.lblIdCliente);
            this.panelFiltros.Controls.Add(this.txtIdCliente);
            this.panelFiltros.Controls.Add(this.lblFechas);
            this.panelFiltros.Controls.Add(this.dtpDesde);
            this.panelFiltros.Controls.Add(this.dtpHasta);
            this.panelFiltros.Controls.Add(this.btnGenerar);
            this.panelFiltros.Controls.Add(this.btnExportar);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Padding = new System.Windows.Forms.Padding(20);
            this.panelFiltros.Size = new System.Drawing.Size(900, 90);

            this.lblTipo.AutoSize = true; this.lblTipo.Location = new System.Drawing.Point(20, 25); this.lblTipo.Text = "Tipo de Reporte:";
            this.cmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoReporte.Items.AddRange(new object[] { "Recaudación por Película", "Ocupación por Función", "Ventas por Cliente" });
            this.cmbTipoReporte.Location = new System.Drawing.Point(120, 22); this.cmbTipoReporte.Size = new System.Drawing.Size(200, 25);
            this.cmbTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cmbTipoReporte_SelectedIndexChanged);

            this.lblIdCliente.AutoSize = true; this.lblIdCliente.Location = new System.Drawing.Point(340, 25); this.lblIdCliente.Text = "ID Cliente:";
            this.txtIdCliente.Location = new System.Drawing.Point(410, 22); this.txtIdCliente.Size = new System.Drawing.Size(100, 25);

            this.lblFechas.AutoSize = true; this.lblFechas.Location = new System.Drawing.Point(340, 25); this.lblFechas.Text = "Desde:";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(390, 22); this.dtpDesde.Size = new System.Drawing.Size(110, 25);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(510, 22); this.dtpHasta.Size = new System.Drawing.Size(110, 25);

            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnGenerar.FlatAppearance.BorderSize = 0; this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(650, 20); this.btnGenerar.Size = new System.Drawing.Size(100, 30);
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);

            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnExportar.FlatAppearance.BorderSize = 0; this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(760, 20); this.btnExportar.Size = new System.Drawing.Size(110, 30);
            this.btnExportar.Text = "EXPORTAR CSV";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);

            this.dgvReporte.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporte.AllowUserToAddRows = false; this.dgvReporte.ReadOnly = true;
            this.dgvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Controls.Add(this.lblEstado);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Size = new System.Drawing.Size(900, 40);
            this.lblEstado.AutoSize = true; this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblEstado.Location = new System.Drawing.Point(20, 12); this.lblEstado.Text = "Seleccione un tipo de reporte y presione Generar.";

            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelHeader);

            this.panelHeader.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblEstado;
    }
}