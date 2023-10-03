using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Clases;
using Ventas.Modelos;

namespace Ventas
{
    internal class ProveedorConsultas
    {
        private ConexionMysql conexionMysql;
        private List<Proveedor> mProveedores;
        public ProveedorConsultas()
        {
            conexionMysql = new ConexionMysql();
            mProveedores = new List<Proveedor>();
        }
        public List<Proveedor> getProveedor(string filtro)
        {
            String QUERY = "SELECT * FROM proveedor ";
            MySqlCommand mComando = new MySqlCommand(QUERY);
            mComando.Connection = conexionMysql.GetConnection();
            MySqlDataReader mReader;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "Codigo LIKE'%" + filtro + "%' OR" +
                        "Nombre LIKE '%" + filtro + "%'OR" +
                        "Producto LIKE '%" + filtro + "%'OR" +
                        "Telefono LIKE'%" + filtro + "%';";

                }
                mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    var mProveedor = new Proveedor();
                    mProveedor.Codigo = mReader.GetInt16("Codigo");
                    mProveedor.Nombre = mReader.GetString("Nombre");
                    mProveedor.Producto = mReader.GetString("Producto");
                    mProveedor.Telefono = mReader.GetString("Telefono");
                   

                    mProveedores.Add(mProveedor);


                }
                mReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return mProveedores;
        }
        internal bool agregarProveedor(Proveedor ProveedorNuevo)
        {
            string INSERT = "INSERT INTO proveedor(nombre,producto,telefono)VALUES(@nombre,@producto,@telefono);";
            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@nombre", ProveedorNuevo.Nombre));
            mCommand.Parameters.Add(new MySqlParameter("@producto", ProveedorNuevo.Producto));
            mCommand.Parameters.Add(new MySqlParameter("@telefono", ProveedorNuevo.Telefono));
          
            return mCommand.ExecuteNonQuery() > 0;

        }
        internal bool eliminarProveedor(Proveedor ProveedorNuevo)
        {
            string DELETE = "DELETE FROM proveedor WHERE codigo=@codigo;";
            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@codigo", ProveedorNuevo.Codigo));
            return mCommand.ExecuteNonQuery() > 0;
        }
        internal bool modificarProveedor(Proveedor ProveedorNuevo)
        {
            string UPDATE = "UPDATE proveedor SET " +

                "nombre=@nombre, " +
                "producto=@producto, " +   
                "telefono=@telefono " +
                "WHERE codigo=@codigo;";
            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@nombre", ProveedorNuevo.Nombre));
            mCommand.Parameters.Add(new MySqlParameter("@producto", ProveedorNuevo.Producto));
            mCommand.Parameters.Add(new MySqlParameter("@telefono", ProveedorNuevo.Telefono));
            mCommand.Parameters.Add(new MySqlParameter("@codigo", ProveedorNuevo.Codigo));
            return mCommand.ExecuteNonQuery() > 0;
        }

    }
}
