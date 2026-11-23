namespace CineGest.UI
{
    partial class FormVenta
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
            this.panelPantalla = new System.Windows.Forms.Panel();
            this.lblPantalla = new System.Windows.Forms.Label();
            this.tableLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelIzquierda = new System.Windows.Forms.TableLayoutPanel();
            this.panelCentro = new System.Windows.Forms.TableLayoutPanel();
            this.panelDerecha = new System.Windows.Forms.TableLayoutPanel();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnVolverCartelera = new System.Windows.Forms.Button();
            this.btnContinuarCompra = new System.Windows.Forms.Button();

            this.panelHeader.SuspendLayout();
            this.panelPantalla.SuspendLayout();
            this.tableLayoutPanelPrincipal.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CineGest - Selección de Butacas";

            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 60);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(270, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "SELECCIÓN DE BUTACAS";

            this.panelPantalla.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelPantalla.Controls.Add(this.lblPantalla);
            this.panelPantalla.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPantalla.Location = new System.Drawing.Point(0, 60);
            this.panelPantalla.Name = "panelPantalla";
            this.panelPantalla.Size = new System.Drawing.Size(800, 40);

            this.lblPantalla.AutoSize = true;
            this.lblPantalla.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantalla.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblPantalla.Location = new System.Drawing.Point(360, 10);
            this.lblPantalla.Name = "lblPantalla";
            this.lblPantalla.Text = "PANTALLA";

            this.tableLayoutPanelPrincipal.ColumnCount = 3;
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelIzquierda, 0, 0);
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelCentro, 1, 0);
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelDerecha, 2, 0);
            this.tableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            this.tableLayoutPanelPrincipal.RowCount = 1;
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrincipal.Size = new System.Drawing.Size(800, 400);
            this.tableLayoutPanelPrincipal.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);

            this.panelIzquierda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIzquierda.Location = new System.Drawing.Point(23, 13);
            this.panelIzquierda.Name = "panelIzquierda";
            this.panelIzquierda.Size = new System.Drawing.Size(116, 377);

            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(163, 13);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(476, 377);

            this.panelDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerecha.Location = new System.Drawing.Point(663, 13);
            this.panelDerecha.Name = "panelDerecha";
            this.panelDerecha.Size = new System.Drawing.Size(116, 377);

            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelInferior.Controls.Add(this.lblResumen);
            this.panelInferior.Controls.Add(this.btnVolverCartelera);
            this.panelInferior.Controls.Add(this.btnContinuarCompra);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 500);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(800, 100);

            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblResumen.Location = new System.Drawing.Point(30, 20);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Text = "Ninguna butaca seleccionada";

            this.btnVolverCartelera.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnVolverCartelera.FlatAppearance.BorderSize = 0;
            this.btnVolverCartelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverCartelera.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCartelera.ForeColor = System.Drawing.Color.White;
            this.btnVolverCartelera.Location = new System.Drawing.Point(400, 50);
            this.btnVolverCartelera.Name = "btnVolverCartelera";
            this.btnVolverCartelera.Size = new System.Drawing.Size(160, 35);
            this.btnVolverCartelera.Text = "VOLVER";
            this.btnVolverCartelera.UseVisualStyleBackColor = false;
            this.btnVolverCartelera.Click += new System.EventHandler(this.btnVolverCartelera_Click);

            this.btnContinuarCompra.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnContinuarCompra.FlatAppearance.BorderSize = 0;
            this.btnContinuarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuarCompra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarCompra.ForeColor = System.Drawing.Color.White;
            this.btnContinuarCompra.Location = new System.Drawing.Point(580, 50);
            this.btnContinuarCompra.Name = "btnContinuarCompra";
            this.btnContinuarCompra.Size = new System.Drawing.Size(190, 35);
            this.btnContinuarCompra.Text = "CONTINUAR COMPRA";
            this.btnContinuarCompra.UseVisualStyleBackColor = false;
            this.btnContinuarCompra.Click += new System.EventHandler(this.btnContinuarCompra_Click);

            this.Controls.Add(this.tableLayoutPanelPrincipal);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelPantalla);
            this.Controls.Add(this.panelHeader);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelPantalla.ResumeLayout(false);
            this.panelPantalla.PerformLayout();
            this.tableLayoutPanelPrincipal.ResumeLayout(false);
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelPantalla;
        private System.Windows.Forms.Label lblPantalla;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal;
        private System.Windows.Forms.TableLayoutPanel panelIzquierda;
        private System.Windows.Forms.TableLayoutPanel panelCentro;
        private System.Windows.Forms.TableLayoutPanel panelDerecha;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnVolverCartelera;
        private System.Windows.Forms.Button btnContinuarCompra;
    }
}