using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DAO
{
    public class ProyectoFinal
    {
 
        public void TablaCliente(Cliente ParamentrosProducto)
        {

            using (ProyectoContext db =
                new ProyectoContext())
            {
                Cliente proyectoFinal = new Cliente();
                proyectoFinal.NombreDelCliente = ParamentrosProducto.NombreDelCliente;
                proyectoFinal.ApellidoDelCliente = ParamentrosProducto.ApellidoDelCliente;
                proyectoFinal.Telefono = ParamentrosProducto.Telefono;
                db.Add(proyectoFinal);
                db.SaveChanges();
            }
        }

        public Cliente UsuarioIndividual(int id)
        {
            using (ProyectoContext bd = new ProyectoContext())
            {

                var buscar = bd.Clientes.FirstOrDefault(x => x.Id == id);

                return buscar;
            }
        }
        public void ActualizarUsuario(Cliente ParamentrosUsuario, int Lector)
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
                        buscar.NombreDelCliente = ParamentrosUsuario.NombreDelCliente;
                        buscar.ApellidoDelCliente = ParamentrosUsuario.ApellidoDelCliente;
                    }
                    else
                    {
                        buscar.Telefono = ParamentrosUsuario.Telefono;
                    }

                    buscar.NombreDelCliente = ParamentrosUsuario.NombreDelCliente;
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
                    db.Clientes.Remove(buscar);
                    db.SaveChanges();
                    return "El usuario se elimino";
                }
            }
        }
    }
}
