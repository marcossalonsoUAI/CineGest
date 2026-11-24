using System;
using System.Windows.Forms;
using CineGest.BLL;

namespace CineGest.UI
{
    public partial class FormUsuarios : Form
    {
        private readonly UsuarioBLL _bll = new UsuarioBLL();

        public FormUsuarios()
        {
            InitializeComponent();
            cmbRol.Items.Add("VENDEDOR");
            cmbRol.Items.Add("ADMIN");
            cmbRol.SelectedIndex = 0;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = _bll.Listar();

            if (dgvUsuarios.Columns["Id"] != null) dgvUsuarios.Columns["Id"].Visible = false;
            if (dgvUsuarios.Columns["NombreUsuario"] != null) dgvUsuarios.Columns["NombreUsuario"].HeaderText = "Usuario";
            if (dgvUsuarios.Columns["Rol"] != null) dgvUsuarios.Columns["Rol"].HeaderText = "Rol Asignado";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _bll.Alta(txtUsuario.Text.Trim(), txtPass.Text, cmbRol.Text);
                MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUsuario.Clear();
                txtPass.Clear();
                cmbRol.SelectedIndex = 0;
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtPass.Clear();
            cmbRol.SelectedIndex = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario de la grilla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value);
            string nombre = dgvUsuarios.CurrentRow.Cells["NombreUsuario"].Value?.ToString();

            if (MessageBox.Show($"¿Eliminar el usuario '{nombre}'?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _bll.Baja(id);   // Asegurate de tener este método en UsuarioBLL
                    CargarGrilla();
                    MessageBox.Show("Usuario eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}