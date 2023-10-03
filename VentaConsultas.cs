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
    internal class VentaConsultas

    {
        private ConexionMysql conexionMysql;
        private List<Venta> mVentas;
        public VentaConsultas()
        {
            conexionMysql = new ConexionMysql();
            mVentas = new List<Venta>();
        }
        public List<Venta> getVenta(string filtro)
        {
            String QUERY = "SELECT * FROM venta ";
            MySqlCommand mComando = new MySqlCommand(QUERY);
            mComando.Connection = conexionMysql.GetConnection();
            MySqlDataReader mReader;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "CorrelativoVenta LIKE'%" + filtro + "%' OR" +
                        "Cantidad LIKE '%" + filtro + "%'OR" +
                        "Monto LIKE '%" + filtro + "%'OR" +
                        "Usuario_IdUsuario LIKE '%" + filtro + "%' OR" +
                        "Producto_Codigo LIKE '%" + filtro + "%' OR" +
                        "Cliente_idCliente LIKE'%" + filtro + "%';";

                }
                mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    var mVenta = new Venta();
                    mVenta.CorrelativoVenta = mReader.GetInt16("CorrelativoVenta");
                    mVenta.Cantidad = mReader.GetString("Cantidad");
                    mVenta.Monto = mReader.GetString("Monto");
                    mVenta.Usuario_IdUsuario = mReader.GetString("Usuario_IdUsuario");
                    mVenta.Producto_Codigo = mReader.GetString("Producto_Codigo");
                    mVenta.Cliente_idCliente=mReader.GetString("Cliente_idCliente");

                    mVentas.Add(mVenta);


                }
                mReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return mVentas;
        }
        internal bool agregarVenta(Venta VentaNueva)
        {
            string INSERT = "INSERT INTO venta(cantidad,monto,usuario_idusuario,producto_codigo,cliente_idcliente)VALUES(@cantidad,@monto,@usuario_idusuario,@producto_codigo,@cliente_idcliente);";
            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@cantidad", VentaNueva.Cantidad));
            mCommand.Parameters.Add(new MySqlParameter("@monto", VentaNueva.Monto));
            mCommand.Parameters.Add(new MySqlParameter("@usuario_idusuario",VentaNueva.Usuario_IdUsuario)); ;
            mCommand.Parameters.Add(new MySqlParameter("@producto_codigo",VentaNueva.Producto_Codigo));
            mCommand.Parameters.Add(new MySqlParameter("@cliente_idcliente", VentaNueva.Cliente_idCliente));
            return mCommand.ExecuteNonQuery() > 0;

        }
        internal bool eliminarVenta(Venta VentaNueva)
        {
            string DELETE = "DELETE FROM venta WHERE correlativoventa=@correlativoventa;";
            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@correlativoventa", VentaNueva.CorrelativoVenta));
            return mCommand.ExecuteNonQuery() > 0;
        }
        internal bool modificarVenta(Venta VentaNueva)
        {
            string UPDATE = "UPDATE venta SET " +

                "cantidad=@cantidad, " +
                "monto=@monto, " +
                "usuario_idusuario=@usuario_idusuario, " +
                "producto_codigo=@producto_codigo, " +
                "cliente_idcliente=@cliente_idcliente " +
                "WHERE correlativoventa=@correlativoventa;";
            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@cantidad", VentaNueva.Cantidad));
            mCommand.Parameters.Add(new MySqlParameter("@monto", VentaNueva.Monto));
            mCommand.Parameters.Add(new MySqlParameter("@usuario_idusuario", VentaNueva.Usuario_IdUsuario));
            mCommand.Parameters.Add(new MySqlParameter("@producto_codigo", VentaNueva.Producto_Codigo));
            mCommand.Parameters.Add(new MySqlParameter("@cliente_idcliente", VentaNueva.Cliente_idCliente));
            mCommand.Parameters.Add(new MySqlParameter("@correlativoventa", VentaNueva.CorrelativoVenta));
            return mCommand.ExecuteNonQuery() > 0;
        }

    }
}
