using System;
using System.Windows.Forms;

namespace CineGest.UI
{
    public partial class FormLogin : Form
    {
        public event EventHandler LoginCorrecto;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (LoginCorrecto != null)
            {
                LoginCorrecto(this, EventArgs.Empty);
            }
        }
    }
}