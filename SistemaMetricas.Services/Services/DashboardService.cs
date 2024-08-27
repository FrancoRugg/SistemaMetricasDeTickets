using SistemaMetricas.Models;
using SistemaMetricas.Services.Handlers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMetricas.Services.Services
{
    public class DashboardService
    {
        public Dashboard GetDashboard(string area)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Total = SqliteHandler.GetScalar($"select COUNT(*) from Tickets;"); 
            dashboard.Pendientes = SqliteHandler.GetScalar($"select COUNT(*) from Tickets WHERE Area = '{area}' AND Estado = 'Pendiente';"); 
            dashboard.Rechazados = SqliteHandler.GetScalar($"select COUNT(*) from Tickets WHERE Area = '{area}' AND Estado = 'Rechazado';"); 
            dashboard.En_Curso = SqliteHandler.GetScalar($"select COUNT(*) from Tickets WHERE Area = '{area}' AND Estado = 'En Curso';"); 
            dashboard.Terminados = SqliteHandler.GetScalar($"select COUNT(*) from Tickets WHERE Area = '{area}' AND Estado = 'Terminado';"); 

            return dashboard;
        }
        public DataTable GetDashboardData(string estado,string area)
        {
            return SqliteHandler.GetDt($"SELECT * from Tickets where Estado = '{estado}' AND Area = '{area}';");
        }

        public DataTable BuscarPorFiltro(string clave, string valor)
        {
            string query = $"select * from Tickets where {clave} like '%{valor}%';";
            return SqliteHandler.GetDt(query);
        }
    }
}
