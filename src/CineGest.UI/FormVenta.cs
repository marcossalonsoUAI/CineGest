using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CineGest.BE;

namespace CineGest.UI
{
    public partial class FormVenta : Form
    {
        private const int FILAS = 8;
        private const int COLS_IZQ = 2;
        private const int COLS_CEN = 6;
        private const int COLS_DER = 2;

        private Pelicula _pelicula;
        private Funcion _funcion;

        private List<string> butacasSeleccionadas = new List<string>();
        private List<string> butacasOcupadas = new List<string> { "B5", "C7", "D3" }; // Simulado, luego vendrá de la DB

        private readonly Color _colorDisponible = Color.FromArgb(248, 250, 252);
        private readonly Color _colorSeleccionada = Color.FromArgb(37, 99, 235);
        private readonly Color _colorOcupada = Color.FromArgb(220, 38, 38);

        //  NUEVO CONSTRUCTOR que recibe los datos seleccionados
        public FormVenta(Pelicula pelicula, Funcion funcion)
        {
            InitializeComponent();
            _pelicula = pelicula;
            _funcion = funcion;

            GenerarButacas();
            ActualizarInfoFuncion();
        }

        private void ActualizarInfoFuncion()
        {
            if (_pelicula != null && _funcion != null)
            {
                lblResumen.Text = $"🎬 {_pelicula.Titulo} | 🕒 {_funcion.FechaHora:dd/MM/yyyy HH:mm} | 🏢 Sala: {_funcion.NombreSala} | 💰 ${_funcion.Precio:F2}";
            }
        }

        private void GenerarButacas()
        {
            panelIzquierda.Controls.Clear();
            panelCentro.Controls.Clear();
            panelDerecha.Controls.Clear();

            ConfigurarPanel(panelIzquierda, COLS_IZQ, FILAS);
            ConfigurarPanel(panelCentro, COLS_CEN, FILAS);
            ConfigurarPanel(panelDerecha, COLS_DER, FILAS);

            for (int fila = 0; fila < FILAS; fila++)
            {
                char letraFila = (char)('A' + fila);
                int colGlobal = 1;

                for (int col = 0; col < COLS_IZQ; col++) { CrearButaca(panelIzquierda, $"{letraFila}{colGlobal}", fila, col); colGlobal++; }
                for (int col = 0; col < COLS_CEN; col++) { CrearButaca(panelCentro, $"{letraFila}{colGlobal}", fila, col); colGlobal++; }
                for (int col = 0; col < COLS_DER; col++) { CrearButaca(panelDerecha, $"{letraFila}{colGlobal}", fila, col); colGlobal++; }
            }
        }

        private void ConfigurarPanel(TableLayoutPanel panel, int columnas, int filas)
        {
            panel.ColumnCount = columnas;
            panel.RowCount = filas;
            panel.ColumnStyles.Clear();
            panel.RowStyles.Clear();
            for (int i = 0; i < columnas; i++) panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnas));
            for (int i = 0; i < filas; i++) panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / filas));
            panel.Dock = DockStyle.Fill;
            panel.Padding = new Padding(5);
        }

        private void CrearButaca(TableLayoutPanel panel, string nombre, int fila, int col)
        {
            Button btn = new Button
            {
                Text = nombre,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                BackColor = _colorDisponible,
                ForeColor = Color.FromArgb(15, 23, 42),
                Dock = DockStyle.Fill,
                Margin = new Padding(3),
                Tag = nombre
            };
            btn.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);

            if (butacasOcupadas.Contains(nombre))
            {
                btn.BackColor = _colorOcupada;
                btn.ForeColor = Color.White;
                btn.Enabled = false;
            }
            else
            {
                btn.Click += BtnButaca_Click;
            }
            panel.Controls.Add(btn, col, fila);
        }

        private void BtnButaca_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string nombre = btn.Tag.ToString();

            if (butacasSeleccionadas.Contains(nombre))
            {
                butacasSeleccionadas.Remove(nombre);
                btn.BackColor = _colorDisponible;
                btn.ForeColor = Color.FromArgb(15, 23, 42);
            }
            else
            {
                butacasSeleccionadas.Add(nombre);
                btn.BackColor = _colorSeleccionada;
                btn.ForeColor = Color.White;
            }

            lblResumen.Text = butacasSeleccionadas.Count > 0
                ? $"✅ Butacas: {string.Join(", ", butacasSeleccionadas)} |  {_pelicula?.Titulo} |  Total: ${(_funcion?.Precio * butacasSeleccionadas.Count):F2}"
                : $" {_pelicula?.Titulo} | 🕒 {_funcion?.FechaHora:dd/MM/yyyy HH:mm}";
        }

        private void btnContinuarCompra_Click(object sender, EventArgs e)
        {
            if (butacasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos una butaca.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string peliculaNombre = _pelicula?.Titulo ?? "Película no especificada";
            string horarioStr = _funcion?.FechaHora.ToString("dd/MM/yyyy HH:mm") ?? "Sin horario";
            decimal precio = _funcion?.Precio ?? 0m;

            using (FormConfirmarCompra frm = new FormConfirmarCompra(butacasSeleccionadas, peliculaNombre, horarioStr, precio))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    // TODO: Aquí iría la llamada a VentaBLL.RegistrarVenta(...)
                    this.Close();
                }
            }
        }

        private void btnVolverCartelera_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}