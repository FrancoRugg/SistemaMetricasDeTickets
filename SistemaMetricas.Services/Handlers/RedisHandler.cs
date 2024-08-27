using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRedis
{
    public class RedisHandler
    {
        private RedisClient cliente;
        public RedisHandler()
        {
            this.cliente = new RedisClient();

        }

        public void Set(string clave, string valor)
        {
            this.cliente.Set<string>(clave, valor);
        }
        public string Get(string clave)
        {
            return this.cliente.Get<string>(clave);
        }
        public void Del(string clave)
        {
            this.cliente.Del(clave);
        }
    }
}
