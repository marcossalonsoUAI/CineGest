using System;
using System.Drawing;
using System.Windows.Forms;
using CineGest.BE;
using CineGest.BLL;

namespace CineGest.UI
{
    public partial class FormPrincipal : Form
    {
        private Pelicula _peliculaSeleccionada;
        private Funcion _funcionSeleccionada;

        public FormPrincipal()
        {
            InitializeComponent();
            EstilizarGrillas();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarPeliculas();
            ActualizarInterfazSegunRol();

            this.BeginInvoke(new Action(() =>
            {
                AjustarGrillaResponsive(dgvPeliculas);
                AjustarGrillaResponsive(dgvFunciones);
            }));
        }

        private void ActualizarInterfazSegunRol()
        {
            var usuario = UsuarioBLL.UsuarioActual;

            if (usuario == null)
            {
                lblBienvenida.Text = "🎬 Bienvenido a CineGest - Cartelera Pública";
                btnIngresar.Visible = true;
                btnCambiarPass.Visible = false;
                btnCerrarSesion.Visible = false;
                btnPeliculas.Visible = false;
                btnUsuarios.Visible = false;
                btnReportes.Visible = false;
            }
            else
            {
                lblBienvenida.Text = $"👤 Bienvenido, {usuario.NombreUsuario} ({usuario.Rol})";
                btnIngresar.Visible = false;
                btnCambiarPass.Visible = true;
                btnCerrarSesion.Visible = true;

                string rol = (usuario.Rol ?? "").Trim().ToUpper();
                bool esAdmin = rol == "ADMIN";
                bool esVendedor = rol == "VENDEDOR";

                btnPeliculas.Visible = esAdmin || esVendedor;
                btnUsuarios.Visible = esAdmin;
                btnReportes.Visible = esAdmin || esVendedor;
            }
        }

        private void CargarPeliculas()
        {
            try
            {
                dgvPeliculas.DataSource = null;
                dgvPeliculas.DataSource = new PeliculaBLL().Listar();

                if (dgvPeliculas.Columns["IdPelicula"] != null) dgvPeliculas.Columns["IdPelicula"].Visible = false;

                this.BeginInvoke(new Action(() => AjustarGrillaResponsive(dgvPeliculas)));

                dgvFunciones.DataSource = null;
                lblInfoFunciones.Text = "Seleccione una película para ver sus funciones disponibles";
                btnComprar.Enabled = false;
                _funcionSeleccionada = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar películas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarFuncionesPorPelicula(int idPelicula)
        {
            try
            {
                dgvFunciones.DataSource = null;
                var funciones = new FuncionBLL().ListarPorPelicula(idPelicula);
                dgvFunciones.DataSource = funciones;

                if (dgvFunciones.Columns["Id"] != null) dgvFunciones.Columns["Id"].Visible = false;
                if (dgvFunciones.Columns["IdPelicula"] != null) dgvFunciones.Columns["IdPelicula"].Visible = false;
                if (dgvFunciones.Columns["IdSala"] != null) dgvFunciones.Columns["IdSala"].Visible = false;

                this.BeginInvoke(new Action(() => AjustarGrillaResponsive(dgvFunciones)));

                if (funciones.Count > 0)
                {
                    lblInfoFunciones.Text = "✅ Haga clic en una función para habilitar la compra";
                    btnComprar.Enabled = false;
                    _funcionSeleccionada = null;
                }
                else
                {
                    lblInfoFunciones.Text = "⚠ Esta película no tiene funciones disponibles";
                    btnComprar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar funciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AjustarGrillaResponsive(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.ScrollBars = ScrollBars.Both;
        }

        private void dgvPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPeliculas.CurrentRow != null && dgvPeliculas.CurrentRow.Index >= 0)
            {
                _peliculaSeleccionada = dgvPeliculas.CurrentRow.DataBoundItem as Pelicula;
                if (_peliculaSeleccionada != null)
                {
                    CargarFuncionesPorPelicula(_peliculaSeleccionada.IdPelicula);
                    lblInfoPeliculas.Text = $"🎬 {_peliculaSeleccionada.Titulo} - {_peliculaSeleccionada.Genero} ({_peliculaSeleccionada.Duracion} min)";
                }
            }
        }

        private void dgvFunciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _funcionSeleccionada = dgvFunciones.Rows[e.RowIndex].DataBoundItem as Funcion;
                if (_funcionSeleccionada != null)
                {
                    lblInfoFunciones.Text = $"🕒 {_funcionSeleccionada.FechaHora:dd/MM/yyyy HH:mm} | 🏢 {_funcionSeleccionada.NombreSala} | 💰 ${_funcionSeleccionada.Precio:F2}";
                    btnComprar.Enabled = true;
                }
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (_funcionSeleccionada == null || _peliculaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una función antes de elegir butacas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormVenta venta = new FormVenta(_peliculaSeleccionada, _funcionSeleccionada))
            {
                venta.ShowDialog(this);
            }

            if (_peliculaSeleccionada != null)
                CargarFuncionesPorPelicula(_peliculaSeleccionada.IdPelicula);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (FormLogin login = new FormLogin())
            {
                if (login.ShowDialog(this) == DialogResult.OK)
                    ActualizarInterfazSegunRol();
            }
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            using (FormCambiarContrasena frm = new FormCambiarContrasena())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                    MessageBox.Show("Recuerda que la próxima vez que inicies sesión deberás usar tu nueva contraseña.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new UsuarioBLL().CerrarSesion();
                ActualizarInterfazSegunRol();
                MessageBox.Show("Sesión cerrada correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            using (FormAdministracion frm = new FormAdministracion())
                frm.ShowDialog(this);
            CargarPeliculas();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            using (FormUsuarios frm = new FormUsuarios())
                frm.ShowDialog(this);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            using (FormReportes frm = new FormReportes())
                frm.ShowDialog(this);
        }

        private void EstilizarGrillas()
        {
            EstiloGrilla(dgvPeliculas);
            EstiloGrilla(dgvFunciones);
        }

        private void EstiloGrilla(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(55, 65, 81);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 8, 0, 8);
            dgv.ColumnHeadersHeight = 35;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.EnableHeadersVisualStyles = false;
        }
    }
}