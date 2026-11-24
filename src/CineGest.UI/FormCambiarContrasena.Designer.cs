namespace CineGest.UI
{
    partial class FormCambiarContrasena
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtConfirmarPass = new System.Windows.Forms.TextBox();
            this.lblConfirmarPass = new System.Windows.Forms.Label();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.lblNuevaPass = new System.Windows.Forms.Label();
            this.txtPassActual = new System.Windows.Forms.TextBox();
            this.lblPassActual = new System.Windows.Forms.Label();

            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();

            // CONFIGURACIÓN DEL FORMULARIO
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 480);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar Contraseña";

            // PANEL SUPERIOR
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.panelTop.Controls.Add(this.lblSubtitulo);
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(450, 140);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(95, 35);
            this.lblTitulo.Text = "Seguridad";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(191, 219, 254);
            this.lblSubtitulo.Location = new System.Drawing.Point(105, 85);
            this.lblSubtitulo.Text = "Actualiza tu clave de acceso";

            // PANEL DEL FORMULARIO
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.btnCancelar);
            this.panelForm.Controls.Add(this.btnGuardar);
            this.panelForm.Controls.Add(this.txtConfirmarPass);
            this.panelForm.Controls.Add(this.lblConfirmarPass);
            this.panelForm.Controls.Add(this.txtNuevaPass);
            this.panelForm.Controls.Add(this.lblNuevaPass);
            this.panelForm.Controls.Add(this.txtPassActual);
            this.panelForm.Controls.Add(this.lblPassActual);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Padding = new System.Windows.Forms.Padding(40, 30, 40, 40);

            System.Drawing.Color bgColor = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color textColor = System.Drawing.Color.FromArgb(15, 23, 42);
            System.Drawing.Font fontInput = new System.Drawing.Font("Segoe UI", 11F);
            System.Drawing.Font fontLabel = new System.Drawing.Font("Segoe UI", 9.5F);
            System.Drawing.Color labelColor = System.Drawing.Color.FromArgb(71, 85, 105);

            // Contraseña Actual
            this.lblPassActual.AutoSize = true;
            this.lblPassActual.Font = fontLabel;
            this.lblPassActual.ForeColor = labelColor;
            this.lblPassActual.Location = new System.Drawing.Point(43, 30);
            this.lblPassActual.Text = "Contraseña actual";

            this.txtPassActual.BackColor = bgColor;
            this.txtPassActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassActual.Font = fontInput;
            this.txtPassActual.ForeColor = textColor;
            this.txtPassActual.Location = new System.Drawing.Point(46, 55);
            this.txtPassActual.Size = new System.Drawing.Size(358, 27);

            // Nueva Contraseña
            this.lblNuevaPass.AutoSize = true;
            this.lblNuevaPass.Font = fontLabel;
            this.lblNuevaPass.ForeColor = labelColor;
            this.lblNuevaPass.Location = new System.Drawing.Point(43, 110);
            this.lblNuevaPass.Text = "Nueva contraseña";

            this.txtNuevaPass.BackColor = bgColor;
            this.txtNuevaPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuevaPass.Font = fontInput;
            this.txtNuevaPass.ForeColor = textColor;
            this.txtNuevaPass.Location = new System.Drawing.Point(46, 135);
            this.txtNuevaPass.Size = new System.Drawing.Size(358, 27);

            // Confirmar Contraseña
            this.lblConfirmarPass.AutoSize = true;
            this.lblConfirmarPass.Font = fontLabel;
            this.lblConfirmarPass.ForeColor = labelColor;
            this.lblConfirmarPass.Location = new System.Drawing.Point(43, 190);
            this.lblConfirmarPass.Text = "Confirmar nueva contraseña";

            this.txtConfirmarPass.BackColor = bgColor;
            this.txtConfirmarPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarPass.Font = fontInput;
            this.txtConfirmarPass.ForeColor = textColor;
            this.txtConfirmarPass.Location = new System.Drawing.Point(46, 215);
            this.txtConfirmarPass.Size = new System.Drawing.Size(358, 27);

            // Botón Guardar
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(46, 280);
            this.btnGuardar.Size = new System.Drawing.Size(358, 45);
            this.btnGuardar.Text = "GUARDAR CAMBIOS";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // Botón Cancelar
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnCancelar.Location = new System.Drawing.Point(46, 335);
            this.btnCancelar.Size = new System.Drawing.Size(358, 40);
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // ENSAMBLAJE
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtConfirmarPass;
        private System.Windows.Forms.Label lblConfirmarPass;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.Label lblNuevaPass;
        private System.Windows.Forms.TextBox txtPassActual;
        private System.Windows.Forms.Label lblPassActual;
    }
}