using System;
using System.Drawing;
using System.Windows.Forms;
using CineGest.BLL;

namespace CineGest.UI
{
    public partial class FormCambiarContrasena : Form
    {
        private readonly Color _primaryColor = Color.FromArgb(37, 99, 235);
        private readonly Color _primaryHover = Color.FromArgb(29, 78, 216);

        public FormCambiarContrasena()
        {
            InitializeComponent();
            this.AcceptButton = this.btnGuardar;

            // Ocultar caracteres de contraseña
            txtPassActual.PasswordChar = '●';
            txtNuevaPass.PasswordChar = '●';
            txtConfirmarPass.PasswordChar = '●';

            // Efectos hover en el botón
            btnGuardar.MouseEnter += (s, e) => btnGuardar.BackColor = _primaryHover;
            btnGuardar.MouseLeave += (s, e) => btnGuardar.BackColor = _primaryColor;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassActual.Text))
            {
                MessageBox.Show("Debe ingresar su contraseña actual.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassActual.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNuevaPass.Text) || txtNuevaPass.Text.Length < 4)
            {
                MessageBox.Show("La nueva contraseña debe tener al menos 4 caracteres.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuevaPass.Focus();
                return;
            }

            if (txtNuevaPass.Text != txtConfirmarPass.Text)
            {
                MessageBox.Show("La nueva contraseña y la confirmación no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmarPass.Clear();
                txtConfirmarPass.Focus();
                return;
            }

            try
            {
                var usuario = UsuarioBLL.UsuarioActual;
                if (usuario == null)
                {
                    MessageBox.Show("No hay un usuario logueado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // LLAMADA CORREGIDA: Instanciamos el BLL y usamos usuario.Id
                new UsuarioBLL().CambiarContrasena(usuario.Id, txtPassActual.Text.Trim(), txtNuevaPass.Text.Trim());

                MessageBox.Show("Contraseña actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassActual.Clear();
                txtNuevaPass.Clear();
                txtConfirmarPass.Clear();
                txtPassActual.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}