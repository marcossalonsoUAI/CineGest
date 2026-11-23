using System;
using System.Drawing;
using System.Windows.Forms;

namespace CineGest.UI
{
    public partial class FormPrincipal : Form
    {
        private Panel panelContenido;
        private Button btnVolver;
        private Form hijoActual;

        public FormPrincipal()
        {
            InitializeComponent();


            #region CONTROLES PARA ANIDAR FORMULARIOS DENTRO DE OTROS PARTE I
            panelContenido = new Panel();
            panelContenido.Location = new Point(12, dgvPeliculas.Top);
            panelContenido.Size = new Size(ClientSize.Width - 24, ClientSize.Height - dgvPeliculas.Top - 12);
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.BackColor = Color.Black;
            panelContenido.Visible = false;
            Controls.Add(panelContenido);
            btnVolver = new Button();
            btnVolver.Location = new Point(12, 26);
            btnVolver.Size = new Size(120, 30);
            btnVolver.Text = "VOLVER";
            btnVolver.Font = new Font(Font, FontStyle.Bold);
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Visible = false;
            btnVolver.Click += btnVolver_Click;
            Controls.Add(btnVolver);
            btnVolver.BringToFront();
            #endregion
        }


        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.LoginCorrecto += login_LoginCorrecto;
            MostrarDentro(login);
        }

        private void login_LoginCorrecto(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => MostrarDentro(new FormAdministracion())));
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MostrarDentro(new FormVenta());
        }

        #region CONTROLES PARA ANIDAR FORMULARIOS DENTRO DE OTROS II
        private void btnVolver_Click(object sender, EventArgs e)
        {
            CerrarHijo();
        }

        private void MostrarDentro(Form hijo)
        {
            CerrarHijo();
            OcultarCartelera(true);

            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            hijo.AutoScroll = true;
            panelContenido.Controls.Add(hijo);
            hijoActual = hijo;
            hijo.Show();

            panelContenido.Visible = true;
            panelContenido.BringToFront();
            btnVolver.Visible = true;
            btnVolver.BringToFront();
        }

        private void CerrarHijo()
        {
            if (hijoActual != null && !hijoActual.IsDisposed)
            {
                panelContenido.Controls.Remove(hijoActual);
                hijoActual.Dispose();
            }

            hijoActual = null;
            panelContenido.Visible = false;
            btnVolver.Visible = false;
            OcultarCartelera(false);
        }

        private void OcultarCartelera(bool ocultar)
        {
            dgvPeliculas.Visible = !ocultar;
            dgvFunciones.Visible = !ocultar;
            label3.Visible = !ocultar;
            label4.Visible = !ocultar;
            btnComprar.Visible = !ocultar;
        }

        #endregion
    }
}