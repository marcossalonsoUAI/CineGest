using System;
using System.Drawing;
using System.Windows.Forms;
using CineGest.BLL; // 👈 IMPORTANTE: Agregar esta referencia

namespace CineGest.UI
{
    public partial class FormLogin : Form
    {
        private readonly Color _primaryColor = Color.FromArgb(37, 99, 235);
        private readonly Color _primaryHover = Color.FromArgb(29, 78, 216);
        private readonly Color _bgColor = Color.FromArgb(248, 250, 252);

        public FormLogin()
        {
            InitializeComponent();

            this.AcceptButton = this.btnIngresar;
            txtPass.PasswordChar = '●';

            btnIngresar.MouseEnter += (s, e) => btnIngresar.BackColor = _primaryHover;
            btnIngresar.MouseLeave += (s, e) => btnIngresar.BackColor = _primaryColor;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MostrarError("El campo de usuario es obligatorio.", txtUsuario);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MostrarError("El campo de contraseña es obligatorio.", txtPass);
                return;
            }

            // UX profesional
            btnIngresar.Text = "Verificando...";
            btnIngresar.Enabled = false;
            this.Refresh();

            try
            {
                // 🔑 LÓGICA REAL: Validación contra la BD
                var usuarioLogueado = new UsuarioBLL().Login(txtUsuario.Text.Trim(), txtPass.Text);

                // Si llegamos acá, el login fue exitoso.
                // UsuarioBLL.Login ya seteó UsuarioActual automáticamente.

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Restaurar botón y limpiar
                btnIngresar.Text = "INICIAR SESIÓN";
                btnIngresar.Enabled = true;
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        private void MostrarError(string mensaje, Control control)
        {
            MessageBox.Show(mensaje, "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            control.BackColor = Color.FromArgb(254, 242, 242);

            System.Threading.Tasks.Task.Delay(1500).ContinueWith(_ =>
                this.Invoke(new Action(() => control.BackColor = Color.White))
            );
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}