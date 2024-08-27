using Newtonsoft.Json;
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
    public class TicketService
    {
        public List<Ticket> GetTicketList() //Esto vendría a ser lo mismo que te retorne un JSON
        {
            string json = SqliteHandler.GetJson("Select * from Tickets");
            List<Ticket> lista = JsonConvert.DeserializeObject<List<Ticket>>(json);

            //for (int i = 0; i < lista.Count; i++)
            //{
                
            //}
            return lista;
        }
        public string GetTicketPendientesCount(string area) {
            return SqliteHandler.GetScalar($"Select count(*) from tickets where Estado = 'Pendiente' AND Area = '{area}'; ");
        }
        public DataTable GetTicketDt()
        {
            return SqliteHandler.GetDt("Select * from Tickets");
        }
        public bool CreateTicket(Ticket ticket)
        {
            string insert = $"Insert into Tickets values(null,'{ticket.Titulo}','{ticket.Area}','{ticket.Prioridad}','{ticket.Tipos}','{ticket.Descripcion}','{DateTime.Now.ToString()}','','Pendiente');";

            return SqliteHandler.Exec(insert);
        }
        public bool EditarTicket(Ticket ticket)
        {
            string insert = $"update Tickets set Titulo = '{ticket.Titulo}',Area='{ticket.Area}',Prioridad='{ticket.Prioridad}',Tipos='{ticket.Tipos}',Descripcion='{ticket.Descripcion}',FechaAlta='{DateTime.Now.ToString()}',Estado='{ticket.Estado}' WHERE Id = {ticket.Id};";

            return SqliteHandler.Exec(insert);
        }
        public bool EliminarTicket(string id)
        {
            return SqliteHandler.Exec($"delete from Tickets where Id =" +id);
        }

    }
}
