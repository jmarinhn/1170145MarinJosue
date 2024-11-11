using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    public class Producto
    {

        public string cod_producto { get; set; }
        public string descrip { get; set; }
        public double precio_uni { get; set; }
        public int cantidad { get; set; }
        public double total { get; set; }
        public DateTime fecha { get; set; }

        public Producto()
        {
        }
        public void DataSource() { }

        public Producto(string pcod_producto, string pdescrip, double pprecio_uni, int pcantidad, double ptotal, DateTime pfecha)
        {
            this.cod_producto = pcod_producto;
            this.descrip = pdescrip;
            this.precio_uni = pprecio_uni;
            this.cantidad = pcantidad;
            this.total = ptotal;
            this.fecha = pfecha;
        }
    }
}
