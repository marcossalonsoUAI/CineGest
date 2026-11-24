using System;
using System.Drawing;
using System.Windows.Forms;
using CineGest.BE;
using CineGest.BLL;

namespace CineGest.UI
{
    public partial class FormAdministracion : Form
    {
        private bool _esAdmin = false;

        public FormAdministracion()
        {
            InitializeComponent();
            EstilizarGrillas();
            this.Load += FormAdministracion_Load;
        }

        private void FormAdministracion_Load(object sender, EventArgs e)
        {
            AplicarPermisosPorRol();
            ActualizarGrillaYCombosPeliculas();
            ActualizarGrillaYCombosSalas();
            ActualizarGrillaYCombosFunciones();
            ConfigurarControlesFuncion();
        }

        private void AplicarPermisosPorRol()
        {
            var usuario = UsuarioBLL.UsuarioActual;
            string rol = (usuario?.Rol ?? "").Trim().ToUpper();
            _esAdmin = rol == "ADMIN";

            // Películas
            btnPelAgregar.Visible = true;
            btnPelEditar.Visible = _esAdmin;
            btnPelBorrar.Visible = _esAdmin;

            // Pestaña Funciones: solo admin
            if (!_esAdmin && tabControl1.TabPages.Contains(tabPageFunciones))
                tabControl1.TabPages.Remove(tabPageFunciones);

            // Pestaña Salas: solo admin
            if (!_esAdmin && tabControl1.TabPages.Contains(tabPageSalas))
                tabControl1.TabPages.Remove(tabPageSalas);

            // Controles de Sala
            btnSalaGuardar.Visible = _esAdmin;
            btnSalaEditar.Visible = _esAdmin;
            btnSalaBorrar.Visible = _esAdmin;
            cmbSalas.Enabled = _esAdmin;
            txtNomSala.ReadOnly = !_esAdmin;
            txtCapacidadSala.ReadOnly = !_esAdmin;
            txtTipoSala.ReadOnly = !_esAdmin;

            this.Text = _esAdmin ? "CineGest - Panel de Administración (ADMIN)" : "CineGest - Gestión de Películas (VENDEDOR)";
        }

        // --- PELÍCULAS ---
        private void btnPelAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitulo.Text) || !int.TryParse(txtDuracion.Text, out int duracion) || duracion <= 0)
                {
                    MessageBox.Show("Verifique el Título y que la Duración sea válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var p = new Pelicula
                {
                    Titulo = txtTitulo.Text.Trim(),
                    Genero = txtGenero.Text.Trim(),
                    Duracion = duracion,
                    Director = txtDirector.Text.Trim(),
                    Estado = chkEstado.Checked
                };

                new PeliculaBLL().Alta(p);
                ActualizarGrillaYCombosPeliculas();
                LimpiarCamposPelicula();

                MessageBox.Show("Película agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnPelEditar_Click(object sender, EventArgs e)
        {
            if (!_esAdmin) return;
            try
            {
                if (cmbPelicula.SelectedValue == null || !int.TryParse(txtDuracion.Text, out int duracion) || duracion <= 0)
                {
                    MessageBox.Show("Seleccione una película y verifique la duración.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var p = new Pelicula
                {
                    IdPelicula = Convert.ToInt32(cmbPelicula.SelectedValue),
                    Titulo = txtTitulo.Text.Trim(),
                    Genero = txtGenero.Text.Trim(),
                    Duracion = duracion,
                    Director = txtDirector.Text.Trim(),
                    Estado = chkEstado.Checked
                };

                new PeliculaBLL().Modificar(p);
                ActualizarGrillaYCombosPeliculas();
                MessageBox.Show("Película modificada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnPelBorrar_Click(object sender, EventArgs e)
        {
            if (!_esAdmin || cmbPelicula.SelectedValue == null) return;
            if (MessageBox.Show("¿Eliminar esta película?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    new PeliculaBLL().Baja(Convert.ToInt32(cmbPelicula.SelectedValue));
                    ActualizarGrillaYCombosPeliculas();
                    LimpiarCamposPelicula();
                    MessageBox.Show("Película eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void ActualizarGrillaYCombosPeliculas()
        {
            try
            {
                var lista = new PeliculaBLL().Listar();
                dgvPeliculas.DataSource = null; dgvPeliculas.DataSource = lista;
                if (dgvPeliculas.Columns["IdPelicula"] != null) dgvPeliculas.Columns["IdPelicula"].Visible = false;

                cmbPelicula.DataSource = null; cmbPelicula.DataSource = lista;
                cmbPelicula.DisplayMember = "Titulo"; cmbPelicula.ValueMember = "IdPelicula"; cmbPelicula.SelectedIndex = -1;

                if (_esAdmin)
                {
                    cmbFuncionPelicula.DataSource = null; cmbFuncionPelicula.DataSource = lista;
                    cmbFuncionPelicula.DisplayMember = "Titulo"; cmbFuncionPelicula.ValueMember = "IdPelicula"; cmbFuncionPelicula.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error cargando películas: " + ex.Message, "Error"); }
        }

        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPelicula.SelectedItem is Pelicula p)
            {
                txtTitulo.Text = p.Titulo; txtDuracion.Text = p.Duracion.ToString();
                txtGenero.Text = p.Genero; txtDirector.Text = p.Director; chkEstado.Checked = p.Estado;
            }
        }

        private void LimpiarCamposPelicula()
        {
            txtTitulo.Clear(); txtGenero.Clear(); txtDuracion.Clear(); txtDirector.Clear();
            chkEstado.Checked = true; cmbPelicula.SelectedIndex = -1;
        }

        // --- FUNCIONES ---
        private void ConfigurarControlesFuncion()
        {
            if (!_esAdmin) return;
            cmbFuncionSala.DataSource = new SalaBLL().Listar();
            cmbFuncionSala.DisplayMember = "Nombre"; cmbFuncionSala.ValueMember = "IdSala"; cmbFuncionSala.SelectedIndex = -1;
            chkFuncionEstado.Checked = true; dtpFuncionFecha.Value = DateTime.Now.AddHours(1);
        }

        private void btnFuncionAgregar_Click(object sender, EventArgs e)
        {
            if (!_esAdmin) return;
            try
            {
                if (cmbFuncionPelicula.SelectedValue == null || cmbFuncionSala.SelectedValue == null || !decimal.TryParse(txtFuncionPrecio.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Complete Película, Sala y un Precio válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var f = new Funcion
                {
                    IdPelicula = Convert.ToInt32(cmbFuncionPelicula.SelectedValue),
                    IdSala = Convert.ToInt32(cmbFuncionSala.SelectedValue),
                    FechaHora = dtpFuncionFecha.Value,
                    Precio = precio,
                    Activa = true
                };

                new FuncionBLL().Alta(f);
                ActualizarGrillaYCombosFunciones(); LimpiarCamposFuncion();
                MessageBox.Show("Función agregada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnFuncionEditar_Click(object sender, EventArgs e)
        {
            if (!_esAdmin) return;
            try
            {
                if (cmbFuncionSeleccionar.SelectedValue == null || !decimal.TryParse(txtFuncionPrecio.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Seleccione una función y un Precio válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var f = new Funcion
                {
                    Id = Convert.ToInt32(cmbFuncionSeleccionar.SelectedValue),
                    IdPelicula = Convert.ToInt32(cmbFuncionPelicula.SelectedValue),
                    IdSala = Convert.ToInt32(cmbFuncionSala.SelectedValue),
                    FechaHora = dtpFuncionFecha.Value,
                    Precio = precio,
                    Activa = chkFuncionEstado.Checked
                };

                new FuncionBLL().Modificar(f);
                ActualizarGrillaYCombosFunciones();
                MessageBox.Show("Función modificada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnFuncionBorrar_Click(object sender, EventArgs e)
        {
            if (!_esAdmin || cmbFuncionSeleccionar.SelectedValue == null) return;
            if (MessageBox.Show("¿Desactivar esta función?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    new FuncionBLL().Desactivar(Convert.ToInt32(cmbFuncionSeleccionar.SelectedValue));
                    ActualizarGrillaYCombosFunciones(); LimpiarCamposFuncion();
                    MessageBox.Show("Función desactivada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void ActualizarGrillaYCombosFunciones()
        {
            if (!_esAdmin) return;
            var funciones = new FuncionBLL().Listar();
            dgvFunciones.DataSource = null; dgvFunciones.DataSource = funciones;

            if (dgvFunciones.Columns["Id"] != null) dgvFunciones.Columns["Id"].Visible = false;
            if (dgvFunciones.Columns["IdPelicula"] != null) dgvFunciones.Columns["IdPelicula"].Visible = false;
            if (dgvFunciones.Columns["IdSala"] != null) dgvFunciones.Columns["IdSala"].Visible = false;
            if (dgvFunciones.Columns["DuracionPelicula"] != null) dgvFunciones.Columns["DuracionPelicula"].Visible = false;
            if (dgvFunciones.Columns["HoraFin"] != null) dgvFunciones.Columns["HoraFin"].Visible = false;

            cmbFuncionSeleccionar.DataSource = null; cmbFuncionSeleccionar.DataSource = funciones;
            cmbFuncionSeleccionar.DisplayMember = "Descripcion"; cmbFuncionSeleccionar.ValueMember = "Id"; cmbFuncionSeleccionar.SelectedIndex = -1;
        }

        private void cmbFuncionSeleccionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFuncionSeleccionar.SelectedItem is Funcion f)
            {
                if (f.IdPelicula > 0) cmbFuncionPelicula.SelectedValue = f.IdPelicula;
                if (f.IdSala > 0) cmbFuncionSala.SelectedValue = f.IdSala;
                dtpFuncionFecha.Value = f.FechaHora; txtFuncionPrecio.Text = f.Precio.ToString("F2"); chkFuncionEstado.Checked = f.Activa;
            }
        }

        private void LimpiarCamposFuncion()
        {
            cmbFuncionPelicula.SelectedIndex = -1; cmbFuncionSala.SelectedIndex = -1;
            dtpFuncionFecha.Value = DateTime.Now.AddHours(1); txtFuncionPrecio.Clear(); chkFuncionEstado.Checked = true; cmbFuncionSeleccionar.SelectedIndex = -1;
        }

        // --- SALAS ---
        private void btnSalaGuardar_Click(object sender, EventArgs e)
        {
            if (!_esAdmin) return;
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomSala.Text) || !int.TryParse(txtCapacidadSala.Text, out int cap) || cap <= 0)
                {
                    MessageBox.Show("Complete Nombre y Capacidad válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                new SalaBLL().Alta(new Sala { Nombre = txtNomSala.Text.Trim(), Capacidad = cap, Tipo = txtTipoSala.Text.Trim() });
                ActualizarGrillaYCombosSalas(); LimpiarCamposSala();
                MessageBox.Show("Sala guardada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSalaEditar_Click(object sender, EventArgs e)
        {
            if (!_esAdmin) return;
            try
            {
                if (cmbSalas.SelectedValue == null || !int.TryParse(txtCapacidadSala.Text, out int cap) || cap <= 0)
                {
                    MessageBox.Show("Seleccione una sala y Capacidad válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                new SalaBLL().Modificar(new Sala { IdSala = Convert.ToInt32(cmbSalas.SelectedValue), Nombre = txtNomSala.Text.Trim(), Capacidad = cap, Tipo = txtTipoSala.Text.Trim() });
                ActualizarGrillaYCombosSalas();
                MessageBox.Show("Sala modificada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSalaBorrar_Click(object sender, EventArgs e)
        {
            if (!_esAdmin || cmbSalas.SelectedValue == null) return;
            if (MessageBox.Show("¿Eliminar esta sala?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    new SalaBLL().Baja(Convert.ToInt32(cmbSalas.SelectedValue));
                    ActualizarGrillaYCombosSalas(); LimpiarCamposSala();
                    MessageBox.Show("Sala eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void ActualizarGrillaYCombosSalas()
        {
            var lista = new SalaBLL().Listar();
            dgvSalas.DataSource = null; dgvSalas.DataSource = lista;
            if (dgvSalas.Columns["IdSala"] != null) dgvSalas.Columns["IdSala"].Visible = false;

            cmbSalas.DataSource = null; cmbSalas.DataSource = lista;
            cmbSalas.DisplayMember = "Nombre"; cmbSalas.ValueMember = "IdSala"; cmbSalas.SelectedIndex = -1;

            if (_esAdmin)
            {
                cmbFuncionSala.DataSource = null; cmbFuncionSala.DataSource = lista;
                cmbFuncionSala.DisplayMember = "Nombre"; cmbFuncionSala.ValueMember = "IdSala"; cmbFuncionSala.SelectedIndex = -1;
            }
        }

        private void cmbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSalas.SelectedItem is Sala s)
            {
                txtNomSala.Text = s.Nombre; txtCapacidadSala.Text = s.Capacidad.ToString(); txtTipoSala.Text = s.Tipo;
            }
        }

        private void LimpiarCamposSala()
        {
            txtNomSala.Clear(); txtCapacidadSala.Clear(); txtTipoSala.Clear(); cmbSalas.SelectedIndex = -1;
        }

        // --- ESTILO ---
        private void EstilizarGrillas()
        {
            EstiloGrilla(dgvPeliculas); EstiloGrilla(dgvSalas); EstiloGrilla(dgvFunciones);
        }

        private void EstiloGrilla(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White; dgv.BorderStyle = BorderStyle.None;
            dgv.AllowUserToAddRows = false; dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true; dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(55, 65, 81);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 99, 235);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            dgv.EnableHeadersVisualStyles = false;
        }
    }
}