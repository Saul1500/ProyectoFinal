using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DAO
{
    public class CrudVentaDetalle
    {
        decimal Cantidad;
        decimal Precio;
        decimal PrecioTotal;

        public decimal OperacionMatematica(VentaDetalle operacion)
        {
            PrecioTotal = operacion.CantidadDeLaCompra * operacion.PrecioDeLaCompra;
            return operacion.PrecioTotal = operacion.CantidadDeLaCompra * operacion.PrecioDeLaCompra;
        }

        public void TablaVentaDetalle(VentaDetalle ParamentrosProducto)
        {

            using (ProyectoContext db =
                new ProyectoContext())
            {
                VentaDetalle ventaDetalle = new VentaDetalle();
                ventaDetalle.Id_Productos = ParamentrosProducto.Id_Productos;
                ventaDetalle.Id_Ventas = ParamentrosProducto.Id_Ventas;
                ventaDetalle.CantidadDeLaCompra = ParamentrosProducto.CantidadDeLaCompra;
                ventaDetalle.PrecioDeLaCompra = ParamentrosProducto.PrecioDeLaCompra;
                ventaDetalle.PrecioTotal = ParamentrosProducto.PrecioTotal;
                db.Add(ventaDetalle);
                db.SaveChanges();
            }
        }

        public VentaDetalle UsuarioIndividual(int id)
        {
            using (ProyectoContext bd = new ProyectoContext())
            {

                var buscar = bd.VentaDetalles.FirstOrDefault(x => x.Id == id);

                return buscar;
            }
        }
        public void ActualizarUsuario(VentaDetalle ParamentrosUsuario, int Lector)
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
                        buscar.Id_Productos = ParamentrosUsuario.Id_Productos;
                        buscar.Id_Ventas = ParamentrosUsuario.Id_Ventas;
                        buscar.CantidadDeLaCompra = ParamentrosUsuario.CantidadDeLaCompra;
                        buscar.PrecioDeLaCompra = ParamentrosUsuario.PrecioDeLaCompra;                     
                    }
                    else
                    {
                        buscar.Id = ParamentrosUsuario.Id;
                    }

                    buscar.Id_Productos = ParamentrosUsuario.Id_Productos;
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
                    db.VentaDetalles.Remove(buscar);
                    db.SaveChanges();
                    return "El usuario se elimino";
                }
            }
        }
    }
}
