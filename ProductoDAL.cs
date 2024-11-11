using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Form1
{
    public class ProductoDAL
    {
    
        public static int Agregar(Producto pProducto)
        {

            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into producto (cod_producto,fecha,descrip,precio_uni,cantidad,total) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}')",
                pProducto.cod_producto, pProducto.fecha.ToString("yyyy-MM-dd H:mm:ss"), pProducto.descrip, pProducto.precio_uni, pProducto.cantidad, pProducto.total ), BDComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }

        public static List<Producto> Buscar(string pcod_producto)
        {
            List<Producto> _lista = new List<Producto>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM producto where cod_producto='{0}'", pcod_producto), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Producto pProducto = new Producto();
                pProducto.cod_producto = _reader.GetString(0);
                pProducto.fecha = _reader.GetDateTime(1);
                pProducto.descrip = _reader.GetString(2);
                pProducto.precio_uni = _reader.GetDouble(3);
                pProducto.cantidad = _reader.GetInt16(4);
                pProducto.total = _reader.GetDouble(5);
                _lista.Add(pProducto);

            }

            return _lista;
        }




        public static List<Producto> Buscar2()
        {
            List<Producto> _lista = new List<Producto>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM producto"), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Producto pProducto = new Producto();
                pProducto.cod_producto = _reader.GetString(0);
                pProducto.fecha = _reader.GetDateTime(1);
                pProducto.descrip = _reader.GetString(2);
                pProducto.precio_uni = _reader.GetDouble(3);
                pProducto.cantidad = _reader.GetInt16(4);
                pProducto.total = _reader.GetDouble(5);
                _lista.Add(pProducto);
            }

            return _lista;
        }


        public static Producto ObtenerProducto(string pcod_producto)
        {

            Producto pProducto = new Producto();
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM producto where cod_producto='{0}'", pcod_producto), conexion);
                MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pProducto.cod_producto = _reader.GetString(0);
                pProducto.fecha = _reader.GetDateTime(1);
                pProducto.descrip = _reader.GetString(2);
                pProducto.precio_uni = _reader.GetDouble(3);
                pProducto.cantidad = _reader.GetInt16(4);
                pProducto.total = _reader.GetDouble(5);
            }

            conexion.Close();
            return pProducto;

        }


        public static int Actualizar(Producto pProducto)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("update producto set fecha='{1}', descrip='{2}', precio_uni='{3}', cantidad='{4}', total='{5}' where cod_producto='{0}'",
                pProducto.cod_producto, pProducto.fecha.ToString("yyyy-MM-dd H:mm:ss"), pProducto.descrip, pProducto.precio_uni, pProducto.cantidad, pProducto.total), conexion);


            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        public static int Eliminar(Producto pProducto)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM producto where cod_producto='{0}'",
                pProducto.cod_producto), conexion);


            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }



    }
}
