namespace CineGest.UI
{
    partial class FormLogin
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();

            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();

            // ==========================================
            // CONFIGURACIÓN DEL FORMULARIO
            // ==========================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 520);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineGest - Acceso";

            // ==========================================
            // PANEL SUPERIOR (HEADER DE COLOR)
            // ==========================================
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(37, 99, 235); // Azul profesional
            this.panelTop.Controls.Add(this.lblSubtitulo);
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(420, 160);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(108, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(204, 45);
            this.lblTitulo.Text = "CineGest";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(191, 219, 254); // Azul muy claro
            this.lblSubtitulo.Location = new System.Drawing.Point(112, 95);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(196, 20);
            this.lblSubtitulo.Text = "Panel de Administración";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ==========================================
            // PANEL DEL FORMULARIO (CUERPO)
            // ==========================================
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.btnIngresar);
            this.panelForm.Controls.Add(this.txtPass);
            this.panelForm.Controls.Add(this.lblPass);
            this.panelForm.Controls.Add(this.txtUsuario);
            this.panelForm.Controls.Add(this.lblUsuario);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 160);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(40, 30, 40, 40);
            this.panelForm.Size = new System.Drawing.Size(420, 360);

            // lblUsuario (CORREGIDO: FontStyle.Regular)
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105); // Gris texto profesional
            this.lblUsuario.Location = new System.Drawing.Point(43, 30);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 17);
            this.lblUsuario.Text = "Usuario";

            // txtUsuario
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(248, 250, 252); // Fondo suave
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtUsuario.Location = new System.Drawing.Point(46, 55);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(328, 27);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += (s, e) => txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Leave += (s, e) => txtUsuario.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);

            // lblPass (CORREGIDO: FontStyle.Regular)
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblPass.Location = new System.Drawing.Point(43, 110);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(77, 17);
            this.lblPass.Text = "Contraseña";

            // txtPass
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtPass.Location = new System.Drawing.Point(46, 135);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(328, 27);
            this.txtPass.TabIndex = 1;
            this.txtPass.Enter += (s, e) => txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Leave += (s, e) => txtPass.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);

            // btnIngresar
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235); // Azul primario
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(46, 210);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(328, 45);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "INICIAR SESIÓN";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);

            // ==========================================
            // ENSAMBLAJE FINAL
            // ==========================================
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
    }
}