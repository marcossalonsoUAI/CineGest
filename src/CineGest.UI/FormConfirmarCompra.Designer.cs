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

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblSubtituloCliente = new System.Windows.Forms.Label();
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
            this.flowLayoutPanelProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSubtituloAdicionales = new System.Windows.Forms.Label();
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
            this.panelCliente.SuspendLayout();
            this.panelResumen.SuspendLayout();
            this.panelDetalleEntradas.SuspendLayout();
            this.panelAdicionales.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 780);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmar Compra - CineGest";

            // HEADER
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Size = new System.Drawing.Size(560, 60);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Text = "RESUMEN DE COMPRA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // DATOS DEL CLIENTE
            this.panelCliente.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelCliente.Controls.Add(this.txtEmail);
            this.panelCliente.Controls.Add(this.lblEmail);
            this.panelCliente.Controls.Add(this.txtApellido);
            this.panelCliente.Controls.Add(this.lblApellido);
            this.panelCliente.Controls.Add(this.txtNombre);
            this.panelCliente.Controls.Add(this.lblNombre);
            this.panelCliente.Controls.Add(this.txtDni);
            this.panelCliente.Controls.Add(this.lblDni);
            this.panelCliente.Controls.Add(this.lblSubtituloCliente);
            this.panelCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCliente.Size = new System.Drawing.Size(560, 160);
            this.panelCliente.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);

            this.lblSubtituloCliente.AutoSize = true;
            this.lblSubtituloCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtituloCliente.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblSubtituloCliente.Location = new System.Drawing.Point(20, 15);
            this.lblSubtituloCliente.Text = "DATOS DEL CLIENTE";

            this.lblDni.AutoSize = true; this.lblDni.Location = new System.Drawing.Point(20, 45); this.lblDni.Text = "DNI *:";
            this.txtDni.Location = new System.Drawing.Point(80, 42); this.txtDni.Size = new System.Drawing.Size(120, 25);

            this.lblNombre.AutoSize = true; this.lblNombre.Location = new System.Drawing.Point(220, 45); this.lblNombre.Text = "Nombre *:";
            this.txtNombre.Location = new System.Drawing.Point(280, 42); this.txtNombre.Size = new System.Drawing.Size(250, 25);

            this.lblApellido.AutoSize = true; this.lblApellido.Location = new System.Drawing.Point(20, 85); this.lblApellido.Text = "Apellido:";
            this.txtApellido.Location = new System.Drawing.Point(80, 82); this.txtApellido.Size = new System.Drawing.Size(250, 25);

            this.lblEmail.AutoSize = true; this.lblEmail.Location = new System.Drawing.Point(350, 85); this.lblEmail.Text = "Email:";
            this.txtEmail.Location = new System.Drawing.Point(390, 82); this.txtEmail.Size = new System.Drawing.Size(140, 25);

            // RESUMEN
            this.panelResumen.BackColor = System.Drawing.Color.White;
            this.panelResumen.Controls.Add(this.lblSubtituloResumen);
            this.panelResumen.Controls.Add(this.lblPelicula);
            this.panelResumen.Controls.Add(this.lblHorarioLabel);
            this.panelResumen.Controls.Add(this.lblHorario);
            this.panelResumen.Controls.Add(this.lblButacasLabel);
            this.panelResumen.Controls.Add(this.lblButacas);
            this.panelResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResumen.Size = new System.Drawing.Size(560, 130);
            this.panelResumen.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);

            this.lblSubtituloResumen.AutoSize = true; this.lblSubtituloResumen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtituloResumen.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105); this.lblSubtituloResumen.Location = new System.Drawing.Point(20, 15); this.lblSubtituloResumen.Text = "DETALLES DE LA FUNCIÓN";
            this.lblPelicula.AutoSize = true; this.lblPelicula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblPelicula.Location = new System.Drawing.Point(20, 40); this.lblPelicula.Text = "[Película]";
            this.lblHorarioLabel.AutoSize = true; this.lblHorarioLabel.Location = new System.Drawing.Point(20, 70); this.lblHorarioLabel.Text = "Horario:";
            this.lblHorario.AutoSize = true; this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold); this.lblHorario.Location = new System.Drawing.Point(80, 70); this.lblHorario.Text = "[Horario]";
            this.lblButacasLabel.AutoSize = true; this.lblButacasLabel.Location = new System.Drawing.Point(20, 95); this.lblButacasLabel.Text = "Butacas:";
            this.lblButacas.AutoSize = true; this.lblButacas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold); this.lblButacas.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235); this.lblButacas.Location = new System.Drawing.Point(80, 95); this.lblButacas.Text = "[Butacas]";

            // DETALLE ENTRADAS
            this.panelDetalleEntradas.BackColor = System.Drawing.Color.White;
            this.panelDetalleEntradas.Controls.Add(this.lblDetalleEntradas);
            this.panelDetalleEntradas.Controls.Add(this.lblCantidadEntradas);
            this.panelDetalleEntradas.Controls.Add(this.lblPrecioUnitario);
            this.panelDetalleEntradas.Controls.Add(this.lblSubtotalEntradas);
            this.panelDetalleEntradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetalleEntradas.Size = new System.Drawing.Size(560, 60);
            this.panelDetalleEntradas.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);

            this.lblDetalleEntradas.AutoSize = true; this.lblDetalleEntradas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.lblDetalleEntradas.Location = new System.Drawing.Point(20, 10); this.lblDetalleEntradas.Text = "ENTRADAS";
            this.lblCantidadEntradas.AutoSize = true; this.lblCantidadEntradas.Location = new System.Drawing.Point(20, 35); this.lblCantidadEntradas.Text = "0 entrada(s)";
            this.lblPrecioUnitario.AutoSize = true; this.lblPrecioUnitario.Location = new System.Drawing.Point(160, 35); this.lblPrecioUnitario.Text = "x $ 0,00 c/u";
            this.lblSubtotalEntradas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold); this.lblSubtotalEntradas.Location = new System.Drawing.Point(410, 35); this.lblSubtotalEntradas.Size = new System.Drawing.Size(130, 17); this.lblSubtotalEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight; this.lblSubtotalEntradas.Text = "= $ 0,00";

            // ADICIONALES
            this.panelAdicionales.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelAdicionales.Controls.Add(this.flowLayoutPanelProductos);
            this.panelAdicionales.Controls.Add(this.lblSubtituloAdicionales);
            this.panelAdicionales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdicionales.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);

            this.lblSubtituloAdicionales.AutoSize = true; this.lblSubtituloAdicionales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold); this.lblSubtituloAdicionales.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105); this.lblSubtituloAdicionales.Location = new System.Drawing.Point(20, 12); this.lblSubtituloAdicionales.Text = "PRODUCTOS ADICIONALES";
            this.flowLayoutPanelProductos.AutoScroll = true; this.flowLayoutPanelProductos.Dock = System.Windows.Forms.DockStyle.Fill; this.flowLayoutPanelProductos.Location = new System.Drawing.Point(20, 40); this.flowLayoutPanelProductos.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);

            // TOTAL
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelTotal.Controls.Add(this.lblSubtotalEntradasLabel);
            this.panelTotal.Controls.Add(this.lblValorSubtotalEntradas);
            this.panelTotal.Controls.Add(this.lblSubtotalAdicionalesLabel);
            this.panelTotal.Controls.Add(this.lblSubtotalAdicionales);
            this.panelTotal.Controls.Add(this.lblLinea);
            this.panelTotal.Controls.Add(this.lblTotalLabel);
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotal.Size = new System.Drawing.Size(560, 115);

            this.lblSubtotalEntradasLabel.AutoSize = true; this.lblSubtotalEntradasLabel.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184); this.lblSubtotalEntradasLabel.Location = new System.Drawing.Point(20, 15); this.lblSubtotalEntradasLabel.Text = "Subtotal Entradas:";
            this.lblValorSubtotalEntradas.ForeColor = System.Drawing.Color.White; this.lblValorSubtotalEntradas.Location = new System.Drawing.Point(410, 15); this.lblValorSubtotalEntradas.Size = new System.Drawing.Size(130, 17); this.lblValorSubtotalEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight; this.lblValorSubtotalEntradas.Text = "$ 0,00";
            this.lblSubtotalAdicionalesLabel.AutoSize = true; this.lblSubtotalAdicionalesLabel.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184); this.lblSubtotalAdicionalesLabel.Location = new System.Drawing.Point(20, 40); this.lblSubtotalAdicionalesLabel.Text = "Subtotal Adicionales:";
            this.lblSubtotalAdicionales.ForeColor = System.Drawing.Color.White; this.lblSubtotalAdicionales.Location = new System.Drawing.Point(410, 40); this.lblSubtotalAdicionales.Size = new System.Drawing.Size(130, 17); this.lblSubtotalAdicionales.TextAlign = System.Drawing.ContentAlignment.MiddleRight; this.lblSubtotalAdicionales.Text = "$ 0,00";
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(71, 85, 105); this.lblLinea.Location = new System.Drawing.Point(20, 65); this.lblLinea.Size = new System.Drawing.Size(520, 1);
            this.lblTotalLabel.AutoSize = true; this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblTotalLabel.ForeColor = System.Drawing.Color.White; this.lblTotalLabel.Location = new System.Drawing.Point(20, 78); this.lblTotalLabel.Text = "TOTAL:";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold); this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94); this.lblTotal.Location = new System.Drawing.Point(390, 75); this.lblTotal.Size = new System.Drawing.Size(150, 28); this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight; this.lblTotal.Text = "$ 0,00";

            // BOTONES
            this.panelBotones.BackColor = System.Drawing.Color.White;
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.btnConfirmar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Size = new System.Drawing.Size(560, 60);
            this.panelBotones.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);

            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(220, 38, 38); this.btnCancelar.FlatAppearance.BorderSize = 0; this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnCancelar.ForeColor = System.Drawing.Color.White; this.btnCancelar.Location = new System.Drawing.Point(20, 12); this.btnCancelar.Size = new System.Drawing.Size(130, 38); this.btnCancelar.Text = "CANCELAR"; this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(34, 197, 94); this.btnConfirmar.FlatAppearance.BorderSize = 0; this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnConfirmar.ForeColor = System.Drawing.Color.White; this.btnConfirmar.Location = new System.Drawing.Point(410, 12); this.btnConfirmar.Size = new System.Drawing.Size(130, 38); this.btnConfirmar.Text = "CONFIRMAR"; this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);

            this.Controls.Add(this.panelAdicionales);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelDetalleEntradas);
            this.Controls.Add(this.panelResumen);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.panelHeader);

            this.panelHeader.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
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

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblSubtituloCliente;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProductos;
        private System.Windows.Forms.Label lblSubtituloAdicionales;
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