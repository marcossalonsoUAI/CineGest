using System;
using System.Windows.Forms;
using CineGest.BE;
using CineGest.BLL;

namespace CineGest.UI
{
    public partial class FormAdministracion : Form
    {
        public FormAdministracion()
        {
            InitializeComponent();
            EstilizarGrillas();
            this.Load += FormAdministracion_Load;
        }

        private void FormAdministracion_Load(object sender, EventArgs e)
        {
            ActualizarGrillaYCombosPeliculas();
            ActualizarGrillaYCombosSalas();
        }

        #region --- LÓGICA DE PELÍCULAS ---

        // ✅ BOTÓN AGREGAR PELÍCULA
        private void btnPelAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula p = new Pelicula
                {
                    Titulo = txtTitulo.Text.Trim(),
                    Genero = txtGenero.Text.Trim(),
                    Duracion = Convert.ToInt32(txtDuracion.Text),
                    Director = txtDirector.Text.Trim(),
                    Estado = chkEstado.Checked
                };

                new PeliculaBLL().Alta(p);
                ActualizarGrillaYCombosPeliculas();
                LimpiarCamposPelicula();
                MessageBox.Show("Película agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPelEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPelicula.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una película del combo para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Pelicula p = new Pelicula
                {
                    IdPelicula = Convert.ToInt32(cmbPelicula.SelectedValue),
                    Titulo = txtTitulo.Text.Trim(),
                    Genero = txtGenero.Text.Trim(),
                    Duracion = Convert.ToInt32(txtDuracion.Text),
                    Director = txtDirector.Text.Trim(),
                    Estado = chkEstado.Checked
                };

                new PeliculaBLL().Modificar(p);
                ActualizarGrillaYCombosPeliculas();
                MessageBox.Show("Película modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPelBorrar_Click(object sender, EventArgs e)
        {
            if (cmbPelicula.SelectedValue == null) return;

            if (MessageBox.Show("¿Está seguro de eliminar esta película?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(cmbPelicula.SelectedValue);
                    new PeliculaBLL().Baja(id);
                    ActualizarGrillaYCombosPeliculas();
                    LimpiarCamposPelicula();
                    MessageBox.Show("Película eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ActualizarGrillaYCombosPeliculas()
        {
            try
            {
                var listaPeliculas = new PeliculaBLL().Listar();

                // Nota: Puedes eliminar este MessageBox de diagnóstico cuando todo funcione bien
                MessageBox.Show($"Se encontraron {listaPeliculas.Count} películas en la base de datos.", "Diagnóstico");

                dgvPeliculas.DataSource = null;
                dgvPeliculas.DataSource = listaPeliculas;

                cmbPelicula.DataSource = null;
                cmbPelicula.DataSource = listaPeliculas;
                cmbPelicula.DisplayMember = "Titulo";
                cmbPelicula.ValueMember = "IdPelicula";
                cmbPelicula.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando películas: " + ex.Message, "Error Crítico");
            }
        }

        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPelicula.SelectedItem is Pelicula pelicula)
            {
                txtTitulo.Text = pelicula.Titulo;
                txtDuracion.Text = pelicula.Duracion.ToString();
                txtGenero.Text = pelicula.Genero;
                txtDirector.Text = pelicula.Director;
                chkEstado.Checked = pelicula.Estado;
            }
        }

        private void LimpiarCamposPelicula()
        {
            txtTitulo.Clear();
            txtGenero.Clear();
            txtDuracion.Clear();
            txtDirector.Clear();
            chkEstado.Checked = true;
            cmbPelicula.SelectedIndex = -1;
        }

        #endregion

        #region --- LÓGICA DE SALAS ---

        private void btnSalaGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Sala s = new Sala
                {
                    Nombre = txtNomSala.Text.Trim(),
                    Capacidad = Convert.ToInt32(txtCapacidadSala.Text),
                    Tipo = txtTipoSala.Text.Trim()
                };

                new SalaBLL().Alta(s);
                ActualizarGrillaYCombosSalas();
                LimpiarCamposSala();
                MessageBox.Show("Sala guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalaEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSalas.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una sala del combo para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Sala s = new Sala
                {
                    IdSala = Convert.ToInt32(cmbSalas.SelectedValue),
                    Nombre = txtNomSala.Text.Trim(),
                    Capacidad = Convert.ToInt32(txtCapacidadSala.Text),
                    Tipo = txtTipoSala.Text.Trim()
                };

                new SalaBLL().Modificar(s);
                ActualizarGrillaYCombosSalas();
                MessageBox.Show("Sala modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalaBorrar_Click(object sender, EventArgs e)
        {
            if (cmbSalas.SelectedValue == null) return;

            if (MessageBox.Show("¿Está seguro de eliminar esta sala?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(cmbSalas.SelectedValue);
                    new SalaBLL().Baja(id);
                    ActualizarGrillaYCombosSalas();
                    LimpiarCamposSala();
                    MessageBox.Show("Sala eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ActualizarGrillaYCombosSalas()
        {
            dgvSalas.DataSource = null;
            dgvSalas.DataSource = new SalaBLL().Listar();

            cmbSalas.DataSource = new SalaBLL().Listar();
            cmbSalas.DisplayMember = "Nombre";
            cmbSalas.ValueMember = "IdSala";
            cmbSalas.SelectedIndex = -1;
        }

        private void cmbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSalas.SelectedItem is Sala sala)
            {
                txtNomSala.Text = sala.Nombre;
                txtCapacidadSala.Text = sala.Capacidad.ToString();
                txtTipoSala.Text = sala.Tipo;
            }
        }

        private void LimpiarCamposSala()
        {
            txtNomSala.Clear();
            txtCapacidadSala.Clear();
            txtTipoSala.Clear();
            cmbSalas.SelectedIndex = -1;
        }

        #endregion

        #region --- ESTILIZADO ---

        private void EstilizarGrillas()
        {
            EstiloGrilla(dgvPeliculas);
            EstiloGrilla(dgvSalas);
        }

        private void EstiloGrilla(DataGridView dgv)
        {
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);

            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            dgv.EnableHeadersVisualStyles = false;
        }

        #endregion
    }
}