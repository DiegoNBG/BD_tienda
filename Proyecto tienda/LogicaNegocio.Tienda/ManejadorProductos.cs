using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Tienda;
using Entidades.Tienda;

namespace LogicaNegocio.Tienda
{
    public class ManejadorProductos
    {
        private ProductosAccesoDatos _productosaccesodatos;
        public ManejadorProductos()
        {
            _productosaccesodatos = new ProductosAccesoDatos();
        }
        public List<Productos> ObtenerProductos()
        {
            return _productosaccesodatos.ObtenerProductos();
        }
        public List<Productos> BuscarProductos(string valor)
        {
            return _productosaccesodatos.BuscarProductos(valor);
        }
        public void GuardarProductos(Productos nuevoproducto)
        {
            _productosaccesodatos.GuardarProductos(nuevoproducto);
        }
        public void ActualizarProductos(Productos productos)
        {
            _productosaccesodatos.ActualizarProductos(productos);
        }
        public void EliminarUsuarios(int idproducto)
        {
            _productosaccesodatos.EliminarProductos(idproducto);
        }
        public Tuple<bool, string> ValidarProducto(Productos nuevoproducto)
        {
            string mensaje = "";
            bool valida = true;
            if (nuevoproducto.Nombre == "")
            {
                mensaje = mensaje + "El Campo nombre es Reqerido \n";
                valida = false;
            }

            if (nuevoproducto.Descripcion == "")
            {
                mensaje = mensaje + "El Campo Descripcion es Reqerido \n";
                valida = false;
            }

            if (nuevoproducto.Precio.ToString() == "")
            {
                mensaje = mensaje + "El Campo Precio es Reqerido \n";
                valida = false;
            }

            var validar = new Tuple<bool, string>(valida, mensaje);
            return validar;
        }
    }
}
