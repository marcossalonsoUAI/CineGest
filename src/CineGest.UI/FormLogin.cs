using System;
using System.Drawing;
using System.Windows.Forms;

namespace CineGest.UI
{
    public partial class FormLogin : Form
    {
        // Paleta de colores profesional (Inspirada en Tailwind CSS)
        private readonly Color _primaryColor = Color.FromArgb(37, 99, 235);   // Azul moderno
        private readonly Color _primaryHover = Color.FromArgb(29, 78, 216);   // Azul más oscuro para hover
        private readonly Color _bgColor = Color.FromArgb(248, 250, 252);      // Fondo gris muy claro

        public FormLogin()
        {
            InitializeComponent();

            // UX: Permitir iniciar sesión presionando "Enter"
            this.AcceptButton = this.btnIngresar;

            // Seguridad: Ocultar contraseña
            txtPass.PasswordChar = '●'; // Punto moderno en lugar de asterisco

            // Eventos para efecto hover profesional en el botón
            btnIngresar.MouseEnter += (s, e) => btnIngresar.BackColor = _primaryHover;
            btnIngresar.MouseLeave += (s, e) => btnIngresar.BackColor = _primaryColor;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // 1. Validación profesional con feedback visual
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

            // 2. Simulación de proceso de carga (UX profesional)
            btnIngresar.Text = "Verificando...";
            btnIngresar.Enabled = false;

            // TODO: Aquí va tu lógica real de BLL/DAL
            // bool esValido = UsuarioBLL.Validar(txtUsuario.Text, txtPass.Text);
            bool esValido = true; // Simulado para que pruebes el diseño

            if (esValido)
            {
                using (FormAdministracion admin = new FormAdministracion())
                {
                    this.Hide();
                    admin.ShowDialog(this);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Restaurar botón
                btnIngresar.Text = "INICIAR SESIÓN";
                btnIngresar.Enabled = true;
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        // Método auxiliar para enfocar y marcar el error visualmente
        private void MostrarError(string mensaje, Control control)
        {
            MessageBox.Show(mensaje, "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            control.BackColor = Color.FromArgb(254, 242, 242); // Rojo muy suave
            System.Threading.Tasks.Task.Delay(1500).ContinueWith(_ =>
                this.Invoke(new Action(() => control.BackColor = Color.White))
            );
        }

        // Botón para cerrar la aplicación (si usas el diseño personalizado)
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}