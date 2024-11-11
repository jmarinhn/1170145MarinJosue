using Form1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1170145MarinJosue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Producto ProductoActual { get; set; }
        public void buscar_Click(object sender, EventArgs e)
        {
            BuscarProd buscar = new BuscarProd();
            buscar.ShowDialog();

            if (buscar.ProductoSeleccionado != null)
            {
                ProductoActual = buscar.ProductoSeleccionado;
                cod_producto.Text = Convert.ToString(buscar.ProductoSeleccionado.cod_producto);

                ////bloqueo de la caja de texto
                cod_producto.Enabled = false;
                cod_producto.Text = buscar.ProductoSeleccionado.cod_producto;
                fecha.Text = Convert.ToString(buscar.ProductoSeleccionado.fecha);
                descrip.Text = buscar.ProductoSeleccionado.descrip;
                precio_uni.Text = Convert.ToString(buscar.ProductoSeleccionado.precio_uni);
                cantidad.Text = Convert.ToString(buscar.ProductoSeleccionado.cantidad);
                total.Text = Convert.ToString(buscar.ProductoSeleccionado.total);
                label4.Visible = true;
                total.Visible = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            total.Visible = false;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Producto pProducto = new Producto();

            pProducto.cod_producto = Convert.ToString(cod_producto.Text.Trim());
            pProducto.fecha = Convert.ToDateTime(fecha.Text.Trim());
            pProducto.descrip = descrip.Text.Trim();
            pProducto.precio_uni = Convert.ToDouble(precio_uni.Text.Trim());
            pProducto.cantidad = Convert.ToInt16(cantidad.Text.Trim());
            pProducto.total = Convert.ToDouble(precio_uni.Text.Trim()) * Convert.ToInt16(cantidad.Text.Trim());


            int resultado = ProductoDAL.Agregar(pProducto);
            if (resultado > 0)
            {
                MessageBox.Show("Producto Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo guardar el producto", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cod_producto.Text = "";
            fecha.Text = "";
            descrip.Text = "";
            precio_uni.Text = "";
            cantidad.Text = "";
            total.Text = "";
            label4.Visible = false;
            total.Visible = false;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            ////////Esta parte es para validar que no se almacenen campos en vacio.
            if (string.IsNullOrWhiteSpace(fecha.Text) || string.IsNullOrWhiteSpace(descrip.Text) || string.IsNullOrWhiteSpace(precio_uni.Text) || string.IsNullOrWhiteSpace(cantidad.Text))
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {

                Producto pProducto = new Producto();
                pProducto.cod_producto = Convert.ToString(cod_producto.Text.Trim());
                pProducto.fecha = Convert.ToDateTime(fecha.Text.Trim());
                pProducto.descrip = descrip.Text.Trim();
                pProducto.precio_uni = Convert.ToDouble(precio_uni.Text.Trim());
                pProducto.cantidad = Convert.ToInt16(cantidad.Text.Trim());
                pProducto.total = Convert.ToDouble(precio_uni.Text.Trim()) * Convert.ToInt16(cantidad.Text.Trim());
                if (ProductoDAL.Actualizar(pProducto) > 0)
                {
                    MessageBox.Show("Los datos del producto se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                cod_producto.Text = "";
                cod_producto.Enabled = true;
                fecha.Text = "";
                descrip.Text = "";
                precio_uni.Text = "";
                cantidad.Text = "";
                total.Text = "";
                label4.Visible = false;
                total.Visible = false;
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            Producto pProducto = new Producto();
            pProducto.cod_producto = Convert.ToString(cod_producto.Text);


            int resultado = ProductoDAL.Eliminar(pProducto);
            if (resultado > 0)
            {
                MessageBox.Show("Producto eliminado Con Exito!!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cod_producto.Text = "";
                cod_producto.Enabled = true;
                fecha.Text = "";
                descrip.Text = "";
                precio_uni.Text = "";
                cantidad.Text = "";
                total.Text = "";
                label4.Visible = false;
                total.Visible = false;
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el producto", "Falló!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void descrip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
