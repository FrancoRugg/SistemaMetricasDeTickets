using SistemaMetricas.Models;
using SistemaMetricas.Models.DTO;
using SistemaMetricas.Services.Handlers;
using System;
using System.CodeDom;
using System.Data;
using System.Net.Http.Headers;

namespace SistemaMetricas.Services.Services
{
    public class LoginService
    {
        public bool Login(LoginDTO login)
        {
            string query = $"select count (*) as Total from Login where Usuario = " +
                $"'{login.Usuario}' and Clave = " +
                $"'{login.Clave}' and Estado = 'V'";

            string result = SqliteHandler.GetScalar(query);

            if (result == "0")
            {
                return false;
            }
            else
            {
                return true;
            }     
        }
        public string GetUserRol(string User)
        {
            string query = $"select Rol from Login where Usuario = '{User}'";
            string result = SqliteHandler.GetScalar(query);

            return result;
        }
        public bool EliminarUsuario(string id)
        {
            return SqliteHandler.Exec($"delete from Login where Id ="+id);
        }
        public DataTable TraerUsuarios()
        {
            return SqliteHandler.GetDt("SELECT * from Login WHERE Estado = 'V';");
        }

        public bool EditarUsuario(Login login)
        {
            string query = $"update Login set Usuario = '{login.Usuario}', Clave = '{login.Clave}',Nombre = '{login.Nombre}',Apellido='{login.Apellido}', Email='{login.Email}',Dni= '{login.Dni}',Area='{login.Area}',FechaAlta='{DateTime.Now.ToString()}',Estado = '{login.Estado}' WHERE id = {login.Id};";
            return SqliteHandler.Exec(query);
        }
        public bool CrearUsuario(Login nuevoUsuario)
        {
            LoginDTO loginDTO = new LoginDTO();
            loginDTO.Usuario = nuevoUsuario.Usuario;
            loginDTO.Clave = nuevoUsuario.Clave;

            bool existe = Login(loginDTO);

            if (!existe)
            {
                string query = $"insert into Login values (null," +
                    $"'{nuevoUsuario.Usuario}'," +
                    $"'{EncriptHandler.Base64Encode(nuevoUsuario.Clave)}'," +
                    $"'{nuevoUsuario.Nombre}'," +
                    $"'{nuevoUsuario.Apellido}'," +
                    $"'{nuevoUsuario.Email}'," +
                    $"'{nuevoUsuario.Dni}'," +
                    $"'{nuevoUsuario.Area}'," +
                    $"'{DateTime.Now.ToString()}','V')";

                bool result = SqliteHandler.Exec(query);

                if (!result)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
