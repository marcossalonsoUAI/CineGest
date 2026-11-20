using System;
using System.Windows.Forms;

namespace CineGest.UI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            using (FormLogin login = new FormLogin())
            {
                if (login.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }
            }

            using (FormAdministracion admin = new FormAdministracion())
            {
                admin.ShowDialog(this);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            using (FormVenta venta = new FormVenta())
            {
                venta.ShowDialog(this);
            }
        }
    }
}