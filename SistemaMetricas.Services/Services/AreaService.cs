using SistemaMetricas.Models;
using SistemaMetricas.Models.DTO;
using SistemaMetricas.Services.Handlers;
using System;
using System.Data;


namespace SistemaMetricas.Services.Services
{
    public class AreaService
    {
        public DataTable GetAreas()
        {
            return SqliteHandler.GetDt("select * from areas");
        }
        public string GetAreasByLogin(string login)
        {
            return SqliteHandler.GetScalar($"select Area from Login where Usuario = '{login}'");
        }

        public bool CreateArea(AreaDTO nuevaArea)
        {
            string query = $"insert into Areas values (null," +
                $"'{nuevaArea.Area}'," +
                $"'{nuevaArea.Descripcion}'," +
                $"'{DateTime.Now.ToString()}','V');";
            return SqliteHandler.Exec(query);
        }

        public bool EditarArea(Areas area)
        {
            string query = $"update Areas set Area = " +
                $"'{area.Area}', Descripcion = " +
                $"'{area.Descripcion}', Estado = " +
                $"'{area.Estado}', " +
                $"FechaAlta = '{DateTime.Now.ToString()}' where Id = " + area.Id;
            return SqliteHandler.Exec(query);
        }

        public bool DeleteArea(string id) 
        {
            string query = "delete from Areas where Id = " + id;
            return SqliteHandler.Exec(query);
        }

    }
}
