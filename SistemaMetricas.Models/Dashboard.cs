using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMetricas.Models
{
    public class Dashboard
    {
        public string Total { get; set; }
        public string Pendientes { get; set; }
        public string Terminados { get; set; }
        public string En_Curso { get; set; }
        public string Rechazados { get; set; }

    }
}
