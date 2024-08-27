using SistemaMetricas.Services.Handlers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMetricas.Services.Services
{
    public class TipoService
    {
        public DataTable GetTipos()
        {
            return SqliteHandler.GetDt("select * from Tipos");
        }
    }
}
