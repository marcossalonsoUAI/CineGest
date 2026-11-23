using System;
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
        }

        #region --- CARGA DE DATOS ---

        private void CargarPeliculas()
        {
            try
            {
                dgvPeliculas.DataSource = null;
                dgvPeliculas.DataSource = new PeliculaBLL().Listar();
                dgvPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                dgvFunciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        #endregion

        #region --- SELECCIÓN EN GRILLAS ---

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

        // ✅ ESTE ES EL MÉTODO QUE FALTABA Y CAUSABA EL ERROR
        private void dgvFunciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Si se hizo clic en una fila válida
            {
                _funcionSeleccionada = dgvFunciones.Rows[e.RowIndex].DataBoundItem as Funcion;

                if (_funcionSeleccionada != null)
                {
                    lblInfoFunciones.Text = $"🕒 {_funcionSeleccionada.FechaHora:dd/MM/yyyy HH:mm} | 🏢 {_funcionSeleccionada.NombreSala} | 💰 ${_funcionSeleccionada.Precio:F2}";
                    btnComprar.Enabled = true; // ✅ Aquí se habilita el botón de comprar
                }
            }
        }

        #endregion

        #region --- BOTONES ---

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

            // Refrescar funciones por si se vendieron butacas
            CargarFuncionesPorPelicula(_peliculaSeleccionada.IdPelicula);
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            using (FormLogin login = new FormLogin())
            {
                if (login.ShowDialog(this) != DialogResult.OK) return;
            }

            using (FormAdministracion admin = new FormAdministracion())
            {
                admin.ShowDialog(this);
            }

            CargarPeliculas();
        }

        #endregion

        #region --- ESTILIZADO ---

        private void EstilizarGrillas()
        {
            EstiloGrilla(dgvPeliculas);
            EstiloGrilla(dgvFunciones);
        }

        private void EstiloGrilla(DataGridView dgv)
        {
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);

            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 8, 0, 8);
            dgv.ColumnHeadersHeight = 35;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.EnableHeadersVisualStyles = false;
        }

        #endregion
    }
}