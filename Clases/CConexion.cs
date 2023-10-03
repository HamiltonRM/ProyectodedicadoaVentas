using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Clases
{
    internal class CConexion
    {
        protected string server = "localhost";
        protected string database = "malu";
        protected string user = "root";
        protected string password = "rouham2002";

        public override string ToString()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                Database = database,
                UserID = user,
                Password = password
            };
            return builder.ToString();
        }
    }
}
