using SistemaMetricas.Services.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMetricas.Services.Services
{
    public class RolesService
    {
        public string GetRolName(string rol)
        {
            string query = $"select RoleName from Roles where Id = {rol}";
            string result = SqliteHandler.GetScalar(query);

            return result;
        }
        
    }
}
