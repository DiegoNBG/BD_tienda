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
        private int idproducto = 0;
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            Llenardatos ();
        }

        private void eliminar()
        {
            if (MessageBox.Show("Estas seguro de eliminar el producto", "Eliminar producto",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var idproducto = int.Parse(dtgtienda.CurrentRow.Cells["IdProductos"].Value.ToString());
                _manejadorproductos.EliminarUsuarios(idproducto);
            }

        }

        private void dtgtienda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtproducto.Focus();
            txtproducto.Text = dtgtienda.CurrentRow.Cells["Nombre"].Value.ToString();
            txtdescripcion.Text = dtgtienda.CurrentRow.Cells["Descripcion"].Value.ToString();
            txtprecio.Text = dtgtienda.CurrentRow.Cells["Precio"].Value.ToString();
            idproducto = int.Parse(dtgtienda.CurrentRow.Cells["IdProductos"].Value.ToString());
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Productos nuevoproducto = new Productos();
            nuevoproducto.IdProductos = idproducto;
            nuevoproducto.Nombre = txtproducto.Text;
            nuevoproducto.Descripcion = txtdescripcion.Text;
            nuevoproducto.Precio = double.Parse (txtprecio.Text);
            var validar = _manejadorproductos.ValidarProducto(nuevoproducto);
            if (validar.Item1)
            {
                _manejadorproductos.ActualizarProductos(nuevoproducto);
                Limpiartexto();
                Llenardatos();
                txtproducto.Focus();
            }
            else
                MessageBox.Show(validar.Item2, "Error de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
