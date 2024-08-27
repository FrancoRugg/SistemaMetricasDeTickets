using SistemaMetricas.Handlers;
using SistemaMetricas.Models;
using SistemaMetricas.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMetricas
{
    public partial class frmReportes : Form
    {
        DashboardService dashboardService = new DashboardService();

        public frmReportes()
        {
            InitializeComponent();
        }

        
        private void GetDashboard()
        {
            Dashboard dashboard =  dashboardService.GetDashboard(DatosGlobales.AreaUsuario);
            btnPendientes.Text = $"Pendientes ({dashboard.Pendientes})";
            btnTermindos.Text = $"Termindos ({dashboard.Terminados})";
            btnRechazados.Text = $"Rechazados ({dashboard.Rechazados})";
            btnEn_Curso.Text = $"En Curso ({dashboard.En_Curso})";
            lblTotal.Text = $"Total ({dashboard.Total})";
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            GetDashboard();
            btnEn_Curso.PerformClick();//Simula un click
            cmbFiltro.SelectedIndex = 0;
        }

        private void btnRechazados_Click(object sender, EventArgs e)
        {
            grdDatos.DataSource = dashboardService.GetDashboardData("Rechazado",DatosGlobales.AreaUsuario);
        }

        private void btnTermindos_Click(object sender, EventArgs e)
        {
            grdDatos.DataSource = dashboardService.GetDashboardData("Terminado", DatosGlobales.AreaUsuario);

        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            grdDatos.DataSource = dashboardService.GetDashboardData("Pendiente", DatosGlobales.AreaUsuario);

        }

        private void btnEn_Curso_Click(object sender, EventArgs e)
        {
            grdDatos.DataSource = dashboardService.GetDashboardData("En Curso", DatosGlobales.AreaUsuario);

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

            string clave = cmbFiltro.Text;
            string valor = txtFiltro.Text;
            if (cmbFiltro.Text != "Todos")
            {
                grdDatos.DataSource = dashboardService.BuscarPorFiltro(clave, valor);
            }

        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.Text == "Todos")
            {
                txtFiltro.Text = string.Empty;
                btnEn_Curso.PerformClick();//Simula un click
            }
        }

       
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            string deskPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//captura la ruta del escritorio
            string archivo = Path.Combine(deskPath, "Reporte.html");

            ExportarHTML(grdDatos, archivo);

        }

        public static void ExportarHTML(DataGridView datagrid, string path)
        {
            StringBuilder sb = new StringBuilder();//Clase a utilizar si quiero generar un objeto con texto

            sb.Append("<html>");
            sb.Append("<head>");
            sb.Append("<style>");
            sb.Append("table {width 100%; border-collapse: collapse; }");
            sb.Append("th, td {border: solid 1px black; padding: 8px; text-align: left; }");
            sb.Append("th {background-color: #f2f2f2; }");
            sb.Append("</style>");
            sb.Append("</head>");
            sb.Append("<body>");

            sb.Append("<table>");

            sb.Append("<tr>");
            foreach(DataGridViewColumn column in datagrid.Columns)
            {
                sb.AppendFormat("<td>{0}</th>", column.HeaderText);
            }
            sb.Append("</tr>");

            foreach (DataGridViewRow row in datagrid.Rows)
            {
                if (row.IsNewRow) continue;
                    sb.Append("<tr>");

                foreach (DataGridViewCell cell in row.Cells)
                {

                    sb.AppendFormat("<td>{0}</th>", cell.Value?.ToString() ?? string.Empty);
                }

                    sb.Append("</tr>");
            }


            sb.Append("</table>");

            sb.Append("</body>");
            sb.Append("</html>");

            File.WriteAllText(path, sb.ToString());//Te pega todo el contenido agregado

            MessageBox.Show("Reporte Exportado Correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
