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
    internal class CompraConsulta
    {
        private ConexionMysql conexionMysql;
        private List<Compra> mCompras;
        public CompraConsulta()
        {
            conexionMysql = new ConexionMysql();
            mCompras = new List<Compra>();

        }
        public List<Compra> getCompra(string filtro)
        {
            String QUERY = "SELECT * FROM compra ";
            MySqlCommand mComando = new MySqlCommand(QUERY);
            mComando.Connection = conexionMysql.GetConnection();
            MySqlDataReader mReader;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "CorrelativoCompra LIKE'%" + filtro + "%' OR" +
                        "Fecha LIKE '%" + filtro + "%'OR" +
                        "Cantidad LIKE '%" + filtro + "%'OR" +
                        "Proveedor_Codigo LIKE '%" + filtro + "%' OR" +
                        "Usuario_IdUsuario LIKE '%" + filtro + "%' OR" +
                        "Proveedor_Codigo LIKE'%" + filtro + "%';";

                }
                mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    var mCompra = new Compra();
                    mCompra.CorrelativoCompra = mReader.GetInt16("CorrelativoCompra");
                    mCompra.Fecha = mReader.GetString("Fecha");
                    mCompra.Cantidad = mReader.GetString("Cantidad");
                    mCompra.Proveedor = mReader.GetString("Proveedor_Codigo");
                    mCompra.Usuario = mReader.GetString("Usuario_IdUsuario");
                    mCompra.Producto = mReader.GetString("Producto_Codigo");

                    mCompras.Add(mCompra);


                }
                mReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return mCompras;
        }
        internal bool agregarCompra(Compra CompraNueva)
        {
            string INSERT = "INSERT INTO compra(fecha,cantidad,proveedor_codigo,usuario_idusuario,producto_codigo)VALUES(@fecha,@cantidad,@proveedor_codigo,@usuario_idusuario,@producto_codigo);";
            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@fecha", CompraNueva.Fecha));
            mCommand.Parameters.Add(new MySqlParameter("@cantidad", CompraNueva.Cantidad));
            mCommand.Parameters.Add(new MySqlParameter("@proveedor_codigo", CompraNueva.Proveedor));
            mCommand.Parameters.Add(new MySqlParameter("@usuario_idusuario",CompraNueva.Usuario));
            mCommand.Parameters.Add(new MySqlParameter("@producto_codigo", CompraNueva.Producto));
            return mCommand.ExecuteNonQuery() > 0;

        }
        internal bool eliminarCompra(Compra CompraNueva)
        {
            string DELETE = "DELETE FROM compra WHERE correlativocompra=@correlativocompra;";
            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@correlativocompra", CompraNueva.CorrelativoCompra));
            return mCommand.ExecuteNonQuery() > 0;
        }
        internal bool modificarCompra(Compra CompraNueva)
        {
            string UPDATE = "UPDATE compra SET " +

                "fecha=@fecha, " +
                "cantidad=@cantidad, " +
                "proveedor_codigo=@proveedor_codigo, " +
               "usuario_idusuario=@usuario_idusuario, " +
               
                "producto_codigo=@producto_codigo " +
                "WHERE correlativocompra=@correlativocompra;";
            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@fecha", CompraNueva.Fecha));
            mCommand.Parameters.Add(new MySqlParameter("@cantidad", CompraNueva.Cantidad));
            mCommand.Parameters.Add(new MySqlParameter("@proveedor_codigo", CompraNueva.Proveedor));
            mCommand.Parameters.Add(new MySqlParameter("@usuario_idusuario", CompraNueva.Usuario));
            mCommand.Parameters.Add(new MySqlParameter("@producto_codigo", CompraNueva.Producto));
            mCommand.Parameters.Add(new MySqlParameter("@correlativocompra", CompraNueva.CorrelativoCompra));
            return mCommand.ExecuteNonQuery() > 0;
        }

    }


}
