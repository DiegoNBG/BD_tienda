using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.Tienda;
using Entidades.Tienda;
namespace Proyecto_tienda
{
    public partial class Form1 : Form
    {
        private ManejadorProductos _manejadorproductos;
        public Form1()
        {
            InitializeComponent();
            _manejadorproductos = new ManejadorProductos();
        }

        private void Llenardatos()
        {
            dtgtienda.DataSource=_manejadorproductos.ObtenerProductos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Llenardatos();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Productos nuevoproductos = new Productos();
            nuevoproductos.Nombre = txtproducto.Text;
            nuevoproductos.Descripcion = txtdescripcion.Text;
            nuevoproductos.Precio =double.Parse (txtprecio.Text);
            var validar = _manejadorproductos.ValidarProducto(nuevoproductos);
            if (validar.Item1) 
            {
                _manejadorproductos.GuardarProductos(nuevoproductos);
                Llenardatos();
                Limpiartexto();
            }
            else
            MessageBox.Show(validar.Item2,"Error de Campos",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Limpiartexto()
        {
            txtproducto.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
        }
    }
}
