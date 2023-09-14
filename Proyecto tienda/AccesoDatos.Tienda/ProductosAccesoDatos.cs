using AccesoDatos.Restaurante;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Tienda;
using Entidades.Tienda;


namespace AccesoDatos.Tienda
{
    public class ProductosAccesoDatos
    {
        Conexion conexion;
        public ProductosAccesoDatos()
        {
            conexion = new Conexion("localhost", "root", "", "Tienda", 3306);
        }
        public List<Productos> ObtenerProductos()
        {
            var ListaProducto = new List<Productos>();
            var dt = new DataTable();
            dt = conexion.ObtenerDatos("Select * from Productos");
            foreach (DataRow renglon in dt.Rows)
            {
                var Productos = new Productos
                {
                    IdProductos = Convert.ToInt32(renglon["idproducto"]),
                    Nombre = renglon["nombre"].ToString(),
                    Descripcion = renglon["descripcion"].ToString(),
                    Precio = Convert.ToDouble(renglon["precio"])
                };
                ListaProducto.Add(Productos);
            }
            return ListaProducto;
        }
        public void GuardarProductos(Productos nuevoproducto)
        {
            string Consulta = string.Format("Insert Into productos values(null,'{0}','{1}','{2}');",
            nuevoproducto.Nombre, nuevoproducto.Descripcion, nuevoproducto.Precio);
            conexion.EjecutarConsulta(Consulta);
        }
        public List<Productos> BuscarProductos(string valor)
        {
            var ListaProductos = new List<Productos>();
            var dt = new DataTable();
            var consulta = string.Format("Select * from usuarios where nombre like '%{0}%'", valor);
            dt = conexion.ObtenerDatos(consulta);
            foreach (DataRow renglon in dt.Rows)
            {
                var Productos = new Productos
                {
                    IdProductos = Convert.ToInt32(renglon["idproducto"]),
                    Nombre = renglon["nombre"].ToString(),
                    Descripcion = renglon["descripcion"].ToString(),
                    Precio = Convert.ToDouble(renglon["precio"])

                };

                ListaProductos.Add(Productos);
            }
            return ListaProductos;
        }
        public void EliminarProductos(int idproductos)
        {
            string consulta = string.Format("delete from productos where idproducto ='{0}';", idproductos);
            conexion.EjecutarConsulta(consulta);
        }
        public void ActualizarProductos(Productos nuevoproducto)
        {
            string consulta = string.Format("update productos set nombre='{0}',descripcion='{1}',precio='{2}' where idproducto='{3}';",
                                nuevoproducto.Nombre, nuevoproducto.Descripcion, nuevoproducto.Precio,nuevoproducto.IdProductos);
            conexion.EjecutarConsulta(consulta);
        }
    }
}

