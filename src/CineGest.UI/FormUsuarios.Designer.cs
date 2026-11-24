using System;
using System.Drawing;
using System.Windows.Forms;

namespace CineGest.UI
{
    partial class FormUsuarios
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel mainLayout;
        private Panel panelGrilla;
        private DataGridView dgvUsuarios;
        private Panel panelForm;
        private Label lblTitulo;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblPass;
        private TextBox txtPass;
        private Label lblRol;
        private ComboBox cmbRol;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainLayout = new TableLayoutPanel();
            this.panelGrilla = new Panel();
            this.dgvUsuarios = new DataGridView();
            this.panelForm = new Panel();
            this.lblTitulo = new Label();
            this.lblUsuario = new Label();
            this.txtUsuario = new TextBox();
            this.lblPass = new Label();
            this.txtPass = new TextBox();
            this.lblRol = new Label();
            this.cmbRol = new ComboBox();
            this.btnGuardar = new Button();
            this.btnLimpiar = new Button();
            this.btnEliminar = new Button();

            this.mainLayout.SuspendLayout();
            this.panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();

            // mainLayout
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            this.mainLayout.Controls.Add(this.panelGrilla, 0, 0);
            this.mainLayout.Controls.Add(this.panelForm, 1, 0);
            this.mainLayout.Dock = DockStyle.Fill;
            this.mainLayout.Padding = new Padding(15);

            // panelGrilla
            this.panelGrilla.BackColor = Color.White;
            this.panelGrilla.Controls.Add(this.dgvUsuarios);
            this.panelGrilla.Dock = DockStyle.Fill;
            this.panelGrilla.Padding = new Padding(10);

            // dgvUsuarios
            this.dgvUsuarios.Dock = DockStyle.Fill;
            this.dgvUsuarios.BackgroundColor = Color.White;
            this.dgvUsuarios.BorderStyle = BorderStyle.None;
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;

            // panelForm
            this.panelForm.BackColor = Color.FromArgb(248, 250, 252);
            this.panelForm.BorderStyle = BorderStyle.FixedSingle;
            this.panelForm.Dock = DockStyle.Fill;
            this.panelForm.Padding = new Padding(20);

            this.lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.FromArgb(37, 99, 235);
            this.lblTitulo.Location = new Point(20, 20);
            this.lblTitulo.Size = new Size(250, 30);
            this.lblTitulo.Text = "Nuevo Usuario";

            this.lblUsuario.AutoSize = true; this.lblUsuario.Location = new Point(20, 70); this.lblUsuario.Text = "Nombre de Usuario:";
            this.txtUsuario.Location = new Point(20, 90); this.txtUsuario.Size = new Size(250, 25);

            this.lblPass.AutoSize = true; this.lblPass.Location = new Point(20, 130); this.lblPass.Text = "Contraseña:";
            this.txtPass.Location = new Point(20, 150); this.txtPass.Size = new Size(250, 25);
            this.txtPass.PasswordChar = '●';

            this.lblRol.AutoSize = true; this.lblRol.Location = new Point(20, 190); this.lblRol.Text = "Rol del Sistema:";
            this.cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRol.Location = new Point(20, 210); this.cmbRol.Size = new Size(250, 25);

            this.btnGuardar.BackColor = Color.FromArgb(34, 197, 94);
            this.btnGuardar.FlatAppearance.BorderSize = 0; this.btnGuardar.FlatStyle = FlatStyle.Flat;
            this.btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold); this.btnGuardar.ForeColor = Color.White;
            this.btnGuardar.Location = new Point(20, 260); this.btnGuardar.Size = new Size(250, 40);
            this.btnGuardar.Text = "💾 GUARDAR USUARIO";
            this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);

            this.btnLimpiar.BackColor = Color.FromArgb(148, 163, 184);
            this.btnLimpiar.FlatAppearance.BorderSize = 0; this.btnLimpiar.FlatStyle = FlatStyle.Flat;
            this.btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold); this.btnLimpiar.ForeColor = Color.White;
            this.btnLimpiar.Location = new Point(20, 310); this.btnLimpiar.Size = new Size(250, 40);
            this.btnLimpiar.Text = "🧹 LIMPIAR CAMPOS";
            this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);

            this.btnEliminar.BackColor = Color.FromArgb(239, 68, 68);
            this.btnEliminar.FlatAppearance.BorderSize = 0; this.btnEliminar.FlatStyle = FlatStyle.Flat;
            this.btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold); this.btnEliminar.ForeColor = Color.White;
            this.btnEliminar.Location = new Point(20, 360); this.btnEliminar.Size = new Size(250, 40);
            this.btnEliminar.Text = "🗑️ ELIMINAR SELECCIONADO";
            this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);

            this.panelForm.Controls.AddRange(new Control[] {
                this.lblTitulo, this.lblUsuario, this.txtUsuario,
                this.lblPass, this.txtPass, this.lblRol, this.cmbRol,
                this.btnGuardar, this.btnLimpiar, this.btnEliminar
            });

            // Form
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.BackColor = Color.White;
            this.ClientSize = new Size(900, 540);
            this.Controls.Add(this.mainLayout);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Gestión de Usuarios";

            this.mainLayout.ResumeLayout(false);
            this.panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}