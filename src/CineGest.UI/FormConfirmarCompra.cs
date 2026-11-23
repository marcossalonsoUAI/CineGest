using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CineGest.UI
{
    public partial class FormConfirmarCompra : Form
    {
        // ===== MONEDA ARGENTINA =====
        private static readonly CultureInfo _culturaAR = CultureInfo.GetCultureInfo("es-AR");
        // Devuelve "$ 15,00" (coma como separador decimal, símbolo $)
        private static string Moneda(decimal valor) => "$ " + valor.ToString("N2", _culturaAR);

        // Datos de la venta
        private List<string> butacasSeleccionadas;
        private string pelicula;
        private string horario;
        private decimal precioEntrada;

        // Productos adicionales (en pesos)
        private Dictionary<string, decimal> productosAdicionales = new Dictionary<string, decimal>
        {
            { "Pochoclo", 3.50m },
            { "Caramelo", 4.00m },
            { "Helados", 4.00m },
            { "Gaseosa 500ml", 2.50m },
            { "Gaseosa 1.5L", 4.00m },
            { "Jugo natural", 3.00m },
            { "Agua mineral", 2.00m },
            { "Panchos", 5.00m },
            { "Hamburguesa", 7.50m },
            { "Nachos con queso", 6.00m },
            { "Combo familiar (4 entradas + 2 gaseosas + 2 canchas)", 25.00m }
        };

        private List<string> productosSeleccionados = new List<string>();

        public FormConfirmarCompra(List<string> butacas, string pelicula, string horario, decimal precioEntrada)
        {
            InitializeComponent();

            this.butacasSeleccionadas = butacas;
            this.pelicula = pelicula;
            this.horario = horario;
            this.precioEntrada = precioEntrada;

            CargarResumen();
            CargarProductosAdicionales();
            CalcularTotal();
        }

        private void CargarResumen()
        {
            lblPelicula.Text = pelicula;
            lblHorario.Text = horario;
            lblButacas.Text = string.Join(", ", butacasSeleccionadas);
            lblCantidadEntradas.Text = $"{butacasSeleccionadas.Count} entrada(s)";
            lblPrecioUnitario.Text = $"x {Moneda(precioEntrada)} c/u";
            lblSubtotalEntradas.Text = "= " + Moneda(precioEntrada * butacasSeleccionadas.Count);
        }

        private void CargarProductosAdicionales()
        {
            flowLayoutPanelProductos.Controls.Clear();

            foreach (var producto in productosAdicionales)
            {
                Panel panelProducto = new Panel
                {
                    Size = new Size(480, 42),
                    BackColor = Color.FromArgb(248, 250, 252),
                    Margin = new Padding(0, 4, 0, 4)
                };

                // Texto a la IZQUIERDA, con puntos suspensivos si es muy largo
                CheckBox chkProducto = new CheckBox
                {
                    Text = producto.Key,
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(15, 23, 42),
                    Dock = DockStyle.Left,
                    Width = 340,
                    AutoEllipsis = true,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Tag = producto.Key
                };

                // Precio SIEMPRE a la DERECHA, alineado
                Label lblPrecio = new Label
                {
                    Text = Moneda(producto.Value),
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(37, 99, 235),
                    Dock = DockStyle.Right,
                    Width = 130,
                    TextAlign = ContentAlignment.MiddleRight
                };

                chkProducto.CheckedChanged += (s, e) =>
                {
                    if (chkProducto.Checked)
                    {
                        if (!productosSeleccionados.Contains(producto.Key))
                            productosSeleccionados.Add(producto.Key);
                    }
                    else
                    {
                        productosSeleccionados.Remove(producto.Key);
                    }
                    CalcularTotal();
                };

                panelProducto.Controls.Add(chkProducto);
                panelProducto.Controls.Add(lblPrecio);
                flowLayoutPanelProductos.Controls.Add(panelProducto);
            }
        }

        private void CalcularTotal()
        {
            decimal subtotalEntradas = precioEntrada * butacasSeleccionadas.Count;
            decimal subtotalAdicionales = 0;

            foreach (var producto in productosSeleccionados)
                if (productosAdicionales.ContainsKey(producto))
                    subtotalAdicionales += productosAdicionales[producto];

            decimal total = subtotalEntradas + subtotalAdicionales;

            lblValorSubtotalEntradas.Text = Moneda(subtotalEntradas);
            lblSubtotalAdicionales.Text = Moneda(subtotalAdicionales);
            lblTotal.Text = Moneda(total);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // TODO: Aquí va tu lógica para guardar la venta en la base de datos
            string mensaje = $"✅ Compra confirmada!\n\n" +
                           $"Película: {pelicula}\n" +
                           $"Horario: {horario}\n" +
                           $"Butacas: {string.Join(", ", butacasSeleccionadas)}\n" +
                           $"Entradas: {butacasSeleccionadas.Count} x {Moneda(precioEntrada)}\n";

            if (productosSeleccionados.Count > 0)
            {
                mensaje += $"\nAdicionales:\n";
                foreach (var prod in productosSeleccionados)
                    mensaje += $"  - {prod}: {Moneda(productosAdicionales[prod])}\n";
            }

            mensaje += $"\n💰 Total: {lblTotal.Text}";

            MessageBox.Show(mensaje, "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}