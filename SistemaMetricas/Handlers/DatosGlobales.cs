


using Newtonsoft.Json;
using PruebaRedis;
using System.Collections.Generic;

namespace SistemaMetricas.Handlers
{
    public class DatosGlobales
    {
        RedisHandler redisHandler = new RedisHandler();
        public static string UsuarioLogeado = string.Empty;
        public static string AreaUsuario = string.Empty;
        public static string RolUsuario = string.Empty;
        public static List<string> VistasPermitidas { get; set; } = new List<string>();
        public void SetRedis(string usuario, string area,string rol, List<string> vistas)
        {
            redisHandler.Set("usuario",usuario);
            redisHandler.Set("area",area);
            redisHandler.Set("rol",rol);
            string vistasJson = JsonConvert.SerializeObject(vistas);
            redisHandler.Set("vistas", vistasJson);

            UsuarioLogeado = redisHandler.Get("usuario");
            AreaUsuario = redisHandler.Get("area");
            RolUsuario = redisHandler.Get("rol");
            string vistasFromRedis = redisHandler.Get("vistas");
            VistasPermitidas = JsonConvert.DeserializeObject<List<string>>(vistasFromRedis);

        }

    }
}
