using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DAO
{
    public class CrudVentas
    {

        public void TablaVentas(Venta ParamentrosProducto)
        {

            using (ProyectoContext db =
                new ProyectoContext())
            {
                Venta venta = new Venta();
                venta.IdClientes = ParamentrosProducto.IdClientes;
                venta.IdProductos = ParamentrosProducto.IdProductos;
                db.Add(venta);
                db.SaveChanges();
            }
        }

        public Venta UsuarioIndividual(int id)
        {
            using (ProyectoContext bd = new ProyectoContext())
            {

                var buscar = bd.Ventas.FirstOrDefault(x => x.Id == id);

                return buscar;
            }
        }
        public void ActualizarUsuario(Venta ParamentrosUsuario, int Lector)
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
                        buscar.IdClientes = ParamentrosUsuario.IdClientes;
                        buscar.IdProductos = ParamentrosUsuario.IdProductos;
                    }
                    else
                    {
                        buscar.Id = ParamentrosUsuario.Id;
                    }

                    buscar.IdClientes = ParamentrosUsuario.IdClientes;
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
                    db.Ventas.Remove(buscar);
                    db.SaveChanges();
                    return "El usuario se elimino";
                }
            }
        }
    }
}

