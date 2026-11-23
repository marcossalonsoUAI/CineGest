namespace CineGest.UI
{
    partial class FormConfirmarCompra
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
            this.panelResumen = new System.Windows.Forms.Panel();
            this.lblSubtituloResumen = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblHorarioLabel = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblButacasLabel = new System.Windows.Forms.Label();
            this.lblButacas = new System.Windows.Forms.Label();
            this.panelDetalleEntradas = new System.Windows.Forms.Panel();
            this.lblDetalleEntradas = new System.Windows.Forms.Label();
            this.lblCantidadEntradas = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblSubtotalEntradas = new System.Windows.Forms.Label();
            this.panelAdicionales = new System.Windows.Forms.Panel();
            this.lblSubtituloAdicionales = new System.Windows.Forms.Label();
            this.flowLayoutPanelProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblSubtotalEntradasLabel = new System.Windows.Forms.Label();
            this.lblValorSubtotalEntradas = new System.Windows.Forms.Label();
            this.lblSubtotalAdicionalesLabel = new System.Windows.Forms.Label();
            this.lblSubtotalAdicionales = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Panel();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();

            this.panelHeader.SuspendLayout();
            this.panelResumen.SuspendLayout();
            this.panelDetalleEntradas.SuspendLayout();
            this.panelAdicionales.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();

            // ==========================================
            // FORMULARIO (más ancho para dar aire)
            // ==========================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 740);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmar Compra - CineGest";

            // ==========================================
            // HEADER (título centrado con Dock=Fill)
            // ==========================================
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(540, 70);

            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "RESUMEN DE COMPRA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ==========================================
            // PANEL RESUMEN (Película, Horario, Butacas)
            // ==========================================
            this.panelResumen.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelResumen.Controls.Add(this.lblSubtituloResumen);
            this.panelResumen.Controls.Add(this.lblPelicula);
            this.panelResumen.Controls.Add(this.lblHorarioLabel);
            this.panelResumen.Controls.Add(this.lblHorario);
            this.panelResumen.Controls.Add(this.lblButacasLabel);
            this.panelResumen.Controls.Add(this.lblButacas);
            this.panelResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Size = new System.Drawing.Size(540, 150);

            this.lblSubtituloResumen.AutoSize = true;
            this.lblSubtituloResumen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtituloResumen.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblSubtituloResumen.Location = new System.Drawing.Point(20, 18);
            this.lblSubtituloResumen.Name = "lblSubtituloResumen";
            this.lblSubtituloResumen.Text = "DETALLES DE LA FUNCIÓN";

            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPelicula.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblPelicula.Location = new System.Drawing.Point(20, 45);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Text = "[Película]";

            this.lblHorarioLabel.AutoSize = true;
            this.lblHorarioLabel.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHorarioLabel.Location = new System.Drawing.Point(20, 78);
            this.lblHorarioLabel.Name = "lblHorarioLabel";
            this.lblHorarioLabel.Text = "Horario:";

            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHorario.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblHorario.Location = new System.Drawing.Point(85, 78);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Text = "[Horario]";

            this.lblButacasLabel.AutoSize = true;
            this.lblButacasLabel.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblButacasLabel.Location = new System.Drawing.Point(20, 103);
            this.lblButacasLabel.Name = "lblButacasLabel";
            this.lblButacasLabel.Text = "Butacas:";

            this.lblButacas.AutoSize = true;
            this.lblButacas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblButacas.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblButacas.Location = new System.Drawing.Point(85, 103);
            this.lblButacas.Name = "lblButacas";
            this.lblButacas.Text = "[Butacas]";

            // ==========================================
            // PANEL DETALLE ENTRADAS (operación)
            // ==========================================
            this.panelDetalleEntradas.BackColor = System.Drawing.Color.White;
            this.panelDetalleEntradas.Controls.Add(this.lblDetalleEntradas);
            this.panelDetalleEntradas.Controls.Add(this.lblCantidadEntradas);
            this.panelDetalleEntradas.Controls.Add(this.lblPrecioUnitario);
            this.panelDetalleEntradas.Controls.Add(this.lblSubtotalEntradas);
            this.panelDetalleEntradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetalleEntradas.Name = "panelDetalleEntradas";
            this.panelDetalleEntradas.Size = new System.Drawing.Size(540, 65);

            this.lblDetalleEntradas.AutoSize = true;
            this.lblDetalleEntradas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetalleEntradas.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblDetalleEntradas.Location = new System.Drawing.Point(20, 12);
            this.lblDetalleEntradas.Name = "lblDetalleEntradas";
            this.lblDetalleEntradas.Text = "ENTRADAS";

            this.lblCantidadEntradas.AutoSize = true;
            this.lblCantidadEntradas.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblCantidadEntradas.Location = new System.Drawing.Point(20, 38);
            this.lblCantidadEntradas.Name = "lblCantidadEntradas";
            this.lblCantidadEntradas.Text = "0 entrada(s)";

            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblPrecioUnitario.Location = new System.Drawing.Point(160, 38);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Text = "x $ 0,00 c/u";

            this.lblSubtotalEntradas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalEntradas.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblSubtotalEntradas.Location = new System.Drawing.Point(390, 38);
            this.lblSubtotalEntradas.Name = "lblSubtotalEntradas";
            this.lblSubtotalEntradas.Size = new System.Drawing.Size(130, 17);
            this.lblSubtotalEntradas.Text = "= $ 0,00";
            this.lblSubtotalEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ==========================================
            // PANEL ADICIONALES
            // ==========================================
            this.panelAdicionales.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelAdicionales.Controls.Add(this.flowLayoutPanelProductos);
            this.panelAdicionales.Controls.Add(this.lblSubtituloAdicionales);
            this.panelAdicionales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdicionales.Name = "panelAdicionales";
            this.panelAdicionales.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);

            this.lblSubtituloAdicionales.AutoSize = true;
            this.lblSubtituloAdicionales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtituloAdicionales.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblSubtituloAdicionales.Location = new System.Drawing.Point(20, 12);
            this.lblSubtituloAdicionales.Name = "lblSubtituloAdicionales";
            this.lblSubtituloAdicionales.Text = "PRODUCTOS ADICIONALES";

            this.flowLayoutPanelProductos.AutoScroll = true;
            this.flowLayoutPanelProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProductos.Location = new System.Drawing.Point(20, 40);
            this.flowLayoutPanelProductos.Name = "flowLayoutPanelProductos";
            this.flowLayoutPanelProductos.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);

            // ==========================================
            // PANEL TOTAL (fondo oscuro, valores a la derecha)
            // ==========================================
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelTotal.Controls.Add(this.lblSubtotalEntradasLabel);
            this.panelTotal.Controls.Add(this.lblValorSubtotalEntradas);
            this.panelTotal.Controls.Add(this.lblSubtotalAdicionalesLabel);
            this.panelTotal.Controls.Add(this.lblSubtotalAdicionales);
            this.panelTotal.Controls.Add(this.lblLinea);
            this.panelTotal.Controls.Add(this.lblTotalLabel);
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(540, 115);

            this.lblSubtotalEntradasLabel.AutoSize = true;
            this.lblSubtotalEntradasLabel.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSubtotalEntradasLabel.Location = new System.Drawing.Point(20, 15);
            this.lblSubtotalEntradasLabel.Name = "lblSubtotalEntradasLabel";
            this.lblSubtotalEntradasLabel.Text = "Subtotal Entradas:";

            this.lblValorSubtotalEntradas.ForeColor = System.Drawing.Color.White;
            this.lblValorSubtotalEntradas.Location = new System.Drawing.Point(390, 15);
            this.lblValorSubtotalEntradas.Name = "lblValorSubtotalEntradas";
            this.lblValorSubtotalEntradas.Size = new System.Drawing.Size(130, 17);
            this.lblValorSubtotalEntradas.Text = "$ 0,00";
            this.lblValorSubtotalEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblSubtotalAdicionalesLabel.AutoSize = true;
            this.lblSubtotalAdicionalesLabel.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSubtotalAdicionalesLabel.Location = new System.Drawing.Point(20, 40);
            this.lblSubtotalAdicionalesLabel.Name = "lblSubtotalAdicionalesLabel";
            this.lblSubtotalAdicionalesLabel.Text = "Subtotal Adicionales:";

            this.lblSubtotalAdicionales.ForeColor = System.Drawing.Color.White;
            this.lblSubtotalAdicionales.Location = new System.Drawing.Point(390, 40);
            this.lblSubtotalAdicionales.Name = "lblSubtotalAdicionales";
            this.lblSubtotalAdicionales.Size = new System.Drawing.Size(130, 17);
            this.lblSubtotalAdicionales.Text = "$ 0,00";
            this.lblSubtotalAdicionales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblLinea.Location = new System.Drawing.Point(20, 65);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(500, 1);

            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.White;
            this.lblTotalLabel.Location = new System.Drawing.Point(20, 78);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Text = "TOTAL:";

            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblTotal.Location = new System.Drawing.Point(370, 75);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(150, 28);
            this.lblTotal.Text = "$ 0,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ==========================================
            // PANEL BOTONES
            // ==========================================
            this.panelBotones.BackColor = System.Drawing.Color.White;
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.btnConfirmar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelBotones.Size = new System.Drawing.Size(540, 60);

            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(20, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 38);
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(390, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(130, 38);
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);

            // ==========================================
            // ENSAMBLAJE (orden de Dock importa)
            // ==========================================
            this.Controls.Add(this.panelAdicionales);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelDetalleEntradas);
            this.Controls.Add(this.panelResumen);
            this.Controls.Add(this.panelHeader);

            this.panelHeader.ResumeLayout(false);
            this.panelResumen.ResumeLayout(false);
            this.panelResumen.PerformLayout();
            this.panelDetalleEntradas.ResumeLayout(false);
            this.panelDetalleEntradas.PerformLayout();
            this.panelAdicionales.ResumeLayout(false);
            this.panelAdicionales.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelResumen;
        private System.Windows.Forms.Label lblSubtituloResumen;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label lblHorarioLabel;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblButacasLabel;
        private System.Windows.Forms.Label lblButacas;
        private System.Windows.Forms.Panel panelDetalleEntradas;
        private System.Windows.Forms.Label lblDetalleEntradas;
        private System.Windows.Forms.Label lblCantidadEntradas;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblSubtotalEntradas;
        private System.Windows.Forms.Panel panelAdicionales;
        private System.Windows.Forms.Label lblSubtituloAdicionales;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProductos;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblSubtotalEntradasLabel;
        private System.Windows.Forms.Label lblValorSubtotalEntradas;
        private System.Windows.Forms.Label lblSubtotalAdicionalesLabel;
        private System.Windows.Forms.Label lblSubtotalAdicionales;
        private System.Windows.Forms.Panel lblLinea;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}