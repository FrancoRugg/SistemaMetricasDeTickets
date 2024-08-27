using SistemaMetricas.Services.Handlers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMetricas.Services.Services
{
    public class FuncionesService
    {
        public List<string> GetRoleViews(string rol)
        {
            string query = $"select f.Vista from Funciones as f inner join Roles as r on r.id = f.RoleNameId where r.RoleName = '{rol}' and r.Active = 1 and f.Active = 1";
            DataTable dt = SqliteHandler.GetDt(query);

            List<string> result = dt.AsEnumerable().Select(row => row.Field<string>("Vista")).ToList();
            return result;
        }
    }
}
