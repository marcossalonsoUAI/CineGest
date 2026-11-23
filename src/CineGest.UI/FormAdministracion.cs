using CineGest.BE;
using CineGest.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineGest.UI
{
    public partial class FormAdministracion : Form
    {
        public FormAdministracion()
        {
            InitializeComponent();
        }

        private void btnPelGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula p = new Pelicula();

                p.Titulo = txtTitulo.Text;
                p.Genero = txtGenero.Text;
                p.Duracion = Convert.ToInt32(txtDuracion.Text);
                p.Director = txtDirector.Text;
                p.Estado = chkEstado.Checked;

                new PeliculaBLL().Alta(p);
                ActualizarGrillaYCombosPeliculas();
                MessageBox.Show("Pelicula guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPelEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula p = new Pelicula();

                p.IdPelicula = Convert.ToInt32(cmbPelicula.SelectedValue);
                p.Titulo = txtTitulo.Text;
                p.Genero = txtGenero.Text;
                p.Duracion = Convert.ToInt32(txtDuracion.Text);
                p.Director = txtDirector.Text;
                p.Estado = chkEstado.Checked;

                new PeliculaBLL().Modificar(p);
                ActualizarGrillaYCombosPeliculas();
                MessageBox.Show("Pelicula modificada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPelBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdPelicula = Convert.ToInt32(cmbPelicula.SelectedValue);

                new PeliculaBLL().Baja(IdPelicula);
                ActualizarGrillaYCombosPeliculas();
                MessageBox.Show("Pelicula eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormAdministracion_Load(object sender, EventArgs e)
        {
            ActualizarGrillaYCombosPeliculas();
            ActualizarGrillaYCombosSalas();
        }

        private void ActualizarGrillaYCombosPeliculas()
        {
            dgvPeliculas.DataSource = null;
            dgvPeliculas.DataSource = new PeliculaBLL().Listar();

            cmbPelicula.DataSource = new PeliculaBLL().Listar();
            cmbPelicula.DisplayMember = "Titulo";
            cmbPelicula.ValueMember = "IdPelicula";
        }

        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPelicula.SelectedItem != null)
            {
                Pelicula peliculaSeleccionada = (Pelicula)cmbPelicula.SelectedItem;

                txtTitulo.Text = peliculaSeleccionada.Titulo;
                txtDuracion.Text = peliculaSeleccionada.Duracion.ToString();
                txtGenero.Text = peliculaSeleccionada.Genero;
                txtDirector.Text = peliculaSeleccionada.Director;
                chkEstado.Checked = peliculaSeleccionada.Estado;
            }
        }

        private void btnSalaGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Sala s = new Sala();

                s.Nombre = txtNomSala.Text;
                s.Capacidad = Convert.ToInt32(txtCapacidadSala.Text);
                s.Tipo = txtTipoSala.Text;

                new SalaBLL().Alta(s);
                ActualizarGrillaYCombosSalas();
                MessageBox.Show("Sala guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalaEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Sala s = new Sala();

                s.IdSala = Convert.ToInt32(cmbSalas.SelectedValue);
                s.Nombre = txtNomSala.Text;
                s.Capacidad = Convert.ToInt32(txtCapacidadSala.Text);
                s.Tipo = txtTipoSala.Text;

                new SalaBLL().Modificar(s);
                ActualizarGrillaYCombosSalas();
                MessageBox.Show("Sala modificada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalaBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdSala = Convert.ToInt32(cmbSalas.SelectedValue);

                new SalaBLL().Baja(IdSala);
                ActualizarGrillaYCombosSalas();
                MessageBox.Show("Sala eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarGrillaYCombosSalas()
        {
            dgvSalas.DataSource = null;
            dgvSalas.DataSource = new SalaBLL().Listar();

            cmbSalas.DataSource = new SalaBLL().Listar();
            cmbSalas.DisplayMember = "Nombre";
            cmbSalas.ValueMember = "IdSala";
        }

        private void cmbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSalas.SelectedItem != null)
            {
                Sala salaSeleccionada = (Sala)cmbSalas.SelectedItem;

                txtNomSala.Text = salaSeleccionada.Nombre;
                txtCapacidadSala.Text = salaSeleccionada.Capacidad.ToString();
                txtTipoSala.Text = salaSeleccionada.Tipo;
            }
        }
    }
}
