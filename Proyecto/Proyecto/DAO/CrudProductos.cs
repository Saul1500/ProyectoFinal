using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DAO
{
    public class CrudProductos
    {

        public void TablaProductos(Producto ParamentrosProducto)
        {

            using (ProyectoContext db =
                new ProyectoContext())
            {
                Producto proyecto = new Producto();
                proyecto.NombreDelProducto = ParamentrosProducto.NombreDelProducto;
                proyecto.DescripcionDelProducto = ParamentrosProducto.DescripcionDelProducto;
                proyecto.IdClientes = ParamentrosProducto.IdClientes;
                db.Add(proyecto);
                db.SaveChanges();
            }
        }

        public Producto UsuarioIndividual(int id)
        {
            using (ProyectoContext bd = new ProyectoContext())
            {

                var buscar = bd.Productos.FirstOrDefault(x => x.Id == id);

                return buscar;
            }
        }
        public void ActualizarUsuario(Producto ParamentrosUsuario, int Lector)
        {
            using (ProyectoContext db =
                new ProyectoContext())
            {

                var buscar = UsuarioIndividual(ParamentrosUsuario.Id);
                if (buscar == null)
                {
                    Console.WriteLine("El id no existe");
                }
                else
                {
                    if (Lector == 1)
                    {
                        buscar.NombreDelProducto = ParamentrosUsuario.NombreDelProducto;
                        buscar.DescripcionDelProducto = ParamentrosUsuario.DescripcionDelProducto;
                    }
                    else
                    {
                        buscar.Id = ParamentrosUsuario.Id;
                    }

                    buscar.NombreDelProducto = ParamentrosUsuario.NombreDelProducto;
                    db.Update(buscar);
                    db.SaveChanges();

                }

            }
        }

        public string EliminarUsuario(int id)
        {
            using (ProyectoContext db =
                    new ProyectoContext())
            {
                var buscar = UsuarioIndividual(id);
                if (buscar == null)
                {
                    return "El usuario no existe";
                }
                else
                {
                    db.Productos.Remove(buscar);
                    db.SaveChanges();
                    return "El usuario se elimino";
                }
            }
        }
    }
}
