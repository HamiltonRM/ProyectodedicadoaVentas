using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Ventas.Clases
{
    internal class ConexionMysql : CConexion
    {
        private MySqlConnection connection;
        private string cadenaConexion;
        public ConexionMysql()
        {
            //cadenaConexion = "Database=" + database +
            //    "; DataSource=" + server +
            //    "; User Id= " + user +
            //    "; Password= " + password;
            cadenaConexion = base.ToString();
            connection = new MySqlConnection(cadenaConexion);
        }
        public MySqlConnection GetConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open(); 
                }

            }catch (Exception e ) {
                MessageBox.Show(e.ToString());
            }
            return connection;
        }
    }
}
