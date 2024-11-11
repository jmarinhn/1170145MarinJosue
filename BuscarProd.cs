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

namespace Form1
{
    public partial class BuscarProd : Form
    {
        public BuscarProd()
        {
            InitializeComponent();
        }

        public Producto ProductoSeleccionado
        {
            get; set;
        }
        private void BuscarProd_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (dataGridBuscar.SelectedRows.Count == 1)
            {
                string linea = Convert.ToString(dataGridBuscar.CurrentRow.Cells[0].Value);
                ProductoSeleccionado = ProductoDAL.ObtenerProducto(linea);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            dataGridBuscar.DataSource = ProductoDAL.Buscar(nombreb.Text);
        }
    }
}
