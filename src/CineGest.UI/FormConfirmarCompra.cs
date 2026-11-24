using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CineGest.BE;
using CineGest.BLL;

namespace CineGest.UI
{
    public partial class FormConfirmarCompra : Form
    {
        private static readonly CultureInfo _culturaAR = CultureInfo.GetCultureInfo("es-AR");
        private static string Moneda(decimal valor) => "$ " + valor.ToString("N2", _culturaAR);

        private List<string> butacasSeleccionadas;
        private string pelicula;
        private string horario;
        private decimal precioEntrada;
        private int idFuncion;

        private Dictionary<string, decimal> productosAdicionales = new Dictionary<string, decimal>
        {
            { "Pochoclo", 3500m }, { "Gaseosa 500ml", 2500m }, { "Agua mineral", 2000m },
            { "Panchos", 5000m }, { "Hamburguesa", 7500m }, { "Combo Familiar", 25000m }
        };

        private List<string> productosSeleccionados = new List<string>();

        public FormConfirmarCompra(List<string> butacas, string pelicula, string horario, decimal precioEntrada, int idFuncion)
        {
            InitializeComponent();
            this.butacasSeleccionadas = butacas;
            this.pelicula = pelicula;
            this.horario = horario;
            this.precioEntrada = precioEntrada;
            this.idFuncion = idFuncion;

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
                Panel panelProducto = new Panel { Size = new Size(480, 42), BackColor = Color.FromArgb(248, 250, 252), Margin = new Padding(0, 4, 0, 4) };

                CheckBox chkProducto = new CheckBox { Text = producto.Key, Font = new Font("Segoe UI", 9.5F), Dock = DockStyle.Left, Width = 340, AutoEllipsis = true, Tag = producto.Key };
                Label lblPrecio = new Label { Text = Moneda(producto.Value), Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), ForeColor = Color.FromArgb(37, 99, 235), Dock = DockStyle.Right, Width = 130, TextAlign = ContentAlignment.MiddleRight };

                chkProducto.CheckedChanged += (s, e) => {
                    if (chkProducto.Checked) { if (!productosSeleccionados.Contains(producto.Key)) productosSeleccionados.Add(producto.Key); }
                    else { productosSeleccionados.Remove(producto.Key); }
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
                if (productosAdicionales.ContainsKey(producto)) subtotalAdicionales += productosAdicionales[producto];

            lblValorSubtotalEntradas.Text = Moneda(subtotalEntradas);
            lblSubtotalAdicionales.Text = Moneda(subtotalAdicionales);
            lblTotal.Text = Moneda(subtotalEntradas + subtotalAdicionales);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, complete al menos el DNI y Nombre del cliente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Gestionar Cliente (Busca o crea)
                int idCliente;

                // CORRECCIÓN 1: Usamos el nuevo método ObtenerPorDni
                var clienteExistente = new ClienteBLL().ObtenerPorDni(txtDni.Text.Trim());

                if (clienteExistente != null)
                {
                    idCliente = clienteExistente.Id;
                }
                else
                {
                    var nuevoCliente = new Cliente
                    {
                        Dni = txtDni.Text.Trim(),
                        Nombre = txtNombre.Text.Trim(),
                        Apellido = txtApellido.Text.Trim(),
                        Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim()
                    };
                    idCliente = new ClienteBLL().Alta(nuevoCliente);
                }

                // 2. Preparar Venta
                var venta = new Venta
                {
                    IdCliente = idCliente,
                    // CORRECCIÓN 2: Eliminamos IdFuncion de aquí, va en la Entrada
                    MedioPago = "Efectivo",
                    Entradas = new List<Entrada>()
                };

                // 3. Agregar Entradas
                foreach (var butaca in butacasSeleccionadas)
                {
                    venta.Entradas.Add(new Entrada
                    {
                        IdFuncion = this.idFuncion, // CORRECCIÓN 3: IdFuncion va en cada entrada
                        Asiento = butaca,
                        Precio = precioEntrada
                    });
                }

                // 4. Registrar en Base de Datos
                int idVentaGenerada = new VentaBLL().Registrar(venta);

                MessageBox.Show($"✅ ¡Compra confirmada!\nNro. de Venta: {idVentaGenerada}\nTotal: {lblTotal.Text}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}