using CineGest.BLL;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CineGest.UI
{
    public partial class FormReportes : Form
    {
        private readonly ConsultaBLL _consultaBll = new ConsultaBLL();

        public FormReportes()
        {
            InitializeComponent();
            cmbTipoReporte.SelectedIndex = 0;
            CambiarVisibilidadFiltros();
        }

        private void cmbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarVisibilidadFiltros();
        }

        private void CambiarVisibilidadFiltros()
        {
            bool esPorCliente = cmbTipoReporte.Text == "Ventas por Cliente";
            lblIdCliente.Visible = esPorCliente;
            txtIdCliente.Visible = esPorCliente;

            lblFechas.Visible = !esPorCliente;
            dtpDesde.Visible = !esPorCliente;
            dtpHasta.Visible = !esPorCliente;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string tipo = cmbTipoReporte.Text;

                if (tipo == "Recaudación por Película")
                {
                    dt = ConvertirListaATable(_consultaBll.RecaudacionPorPelicula(dtpDesde.Value, dtpHasta.Value));
                }
                else if (tipo == "Ocupación por Función")
                {
                    dt = ConvertirListaATable(_consultaBll.OcupacionPorFuncion(dtpDesde.Value, dtpHasta.Value));
                }
                else if (tipo == "Ventas por Cliente")
                {
                    if (!int.TryParse(txtIdCliente.Text, out int idCliente))
                    {
                        MessageBox.Show("Ingrese un ID de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    dt = ConvertirListaATable(_consultaBll.VentasPorCliente(idCliente));
                }

                dgvReporte.DataSource = dt;
                lblEstado.Text = $"✅ {dt.Rows.Count} registro(s) encontrado(s).";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ConvertirListaATable<T>(System.Collections.Generic.List<T> lista)
        {
            DataTable dt = new DataTable();
            if (lista == null || lista.Count == 0) return dt;

            foreach (var prop in typeof(T).GetProperties())
                dt.Columns.Add(prop.Name, prop.PropertyType);

            foreach (var item in lista)
            {
                DataRow row = dt.NewRow();
                foreach (var prop in typeof(T).GetProperties())
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvReporte.DataSource == null || ((DataTable)dgvReporte.DataSource).Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV (*.csv)|*.csv", FileName = $"Reporte_{DateTime.Now:yyyyMMdd}.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();
                    DataTable dt = (DataTable)dgvReporte.DataSource;
                    sb.AppendLine(string.Join(";", dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));
                    foreach (DataRow row in dt.Rows)
                        sb.AppendLine(string.Join(";", row.ItemArray.Select(v => v?.ToString().Replace(";", ",") ?? "")));

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Reporte exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}