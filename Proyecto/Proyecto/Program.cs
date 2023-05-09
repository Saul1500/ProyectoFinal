using Proyecto.DAO;
using Proyecto.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

Cliente proyectoFinal = new Cliente();
ProyectoFinal cliente = new ProyectoFinal();

Producto CrudProductos = new Producto();
CrudProductos productos = new CrudProductos();

Venta CrudVenta = new Venta();
CrudVentas venta = new CrudVentas();

VentaDetalle crudVentaDetalles = new VentaDetalle();
CrudVentaDetalle ventaDetalle = new CrudVentaDetalle();

bool Continuar = true;
while (Continuar)

{
    Console.WriteLine("======================================");
    Console.WriteLine("BIENVENIDO AL MENU DE LA BASE DE DATOS");
    Console.WriteLine("======================================");

    Console.WriteLine("");

    Console.WriteLine("======================================");
    Console.WriteLine("TABLA DE CLIENTES");
    Console.WriteLine("======================================");

    Console.WriteLine("");

    Console.WriteLine("Precio 1 para Insertar Datos en la Tabla Clientes");

    Console.WriteLine("");

    Console.WriteLine("Precio 2 para Actualizar Nombre del Cliente");

    Console.WriteLine("");

    Console.WriteLine("Precio 3 para Eliminar Cliente");

    Console.WriteLine("");

    Console.WriteLine("======================================");
    Console.WriteLine("TABLA DE PRODUCTOS");
    Console.WriteLine("======================================");

    Console.WriteLine("");

    Console.WriteLine("Precio 4 para Insertar Datos en la Tabla Productos");

    Console.WriteLine("");

    Console.WriteLine("Precio 5 para Actualizar Datos de la tabla Productos");

    Console.WriteLine("");

    Console.WriteLine("Precio 6 para Eliminar Productos");

    Console.WriteLine("");

    Console.WriteLine("======================================");
    Console.WriteLine("TABLA DE VENTAS");
    Console.WriteLine("======================================");

    Console.WriteLine("");

    Console.WriteLine("Precio 7 para Insertar Datos en la Tabla Venta");

    Console.WriteLine("");

    Console.WriteLine("Precio 8 para Actualizar Datos de la tabla  Venta");

    Console.WriteLine("");

    Console.WriteLine("Precio 9 para Eliminar Venta");


    Console.WriteLine("");

    Console.WriteLine("======================================");
    Console.WriteLine("TABLA DE VENTADETALLE");
    Console.WriteLine("======================================");

    Console.WriteLine("");

    Console.WriteLine("Precio 10 para Insertar Datos en la Tabla VentaDetalle");

    Console.WriteLine("");

    Console.WriteLine("Precio 11 para Eliminar VentaDetalle");

    Console.WriteLine("");
    Console.WriteLine("======================================");
    Console.WriteLine("");

    var menu = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");



    switch (menu)
    {
        case 1:
            Console.WriteLine("Ingrese El Nombre del Nombre Del Cliente: ");
            proyectoFinal.NombreDelCliente = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Ingrese el Apellido Del Ciente: ");
            proyectoFinal.ApellidoDelCliente = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Ingrese el Telefono del cliente: ");
            proyectoFinal.Telefono = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            cliente.TablaCliente(proyectoFinal);
            Console.WriteLine("");

            Console.WriteLine("Su Registro Ha Sido Guardado Exitosamente...");
            Console.WriteLine("======================================");
            Console.WriteLine("");
            break;
        case 2:
            Console.WriteLine("Actualizar datos de la tabla Cliente");
            Console.WriteLine("");
            Console.WriteLine("Ingresa el ID del cliente a Actualizar");
            var UsuarioIndividualU = cliente.UsuarioIndividual(Convert.ToInt32(Console.ReadLine()));
            if (UsuarioIndividualU == null)
            {
                Console.WriteLine("El ID no existe");
            }
            else
            {
                Console.WriteLine($"Nombre Del Cliente: {UsuarioIndividualU.NombreDelCliente}, Apellido Del Cliente: {UsuarioIndividualU.ApellidoDelCliente}, Telefono: {UsuarioIndividualU.Telefono}");

                Console.WriteLine("");

                Console.WriteLine("Para Actualizar Nombre del Cliente y Apellido del cliente preciona 1");

                Console.WriteLine("");

                Console.WriteLine("Para Actualizar Telefono preciona 2");

                var Lector = Convert.ToInt32(Console.ReadLine());
                if (Lector == 1)
                {
                    Console.WriteLine("Ingrese el nuevo Nombre: ");
                    UsuarioIndividualU.NombreDelCliente = (Console.ReadLine());

                    Console.WriteLine("");

                    Console.WriteLine("Ingrese el nuevo Apellido: ");
                    UsuarioIndividualU.ApellidoDelCliente = (Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Ingrese el nuevo Telefono del Cliente: ");
                    UsuarioIndividualU.Telefono = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                }
                cliente.ActualizarUsuario(UsuarioIndividualU, Lector);
                Console.WriteLine("");
                Console.WriteLine("Actualizacion Correcta");
            }
            break;
        case 3:
            Console.WriteLine("Ingresa el Id a Eliminar");
            var UsuarioIndividualD = cliente.UsuarioIndividual(Convert.ToInt32(Console.ReadLine()));
            if (UsuarioIndividualD == null)
            {
                Console.WriteLine("Este Usuario no Existe");
            }
            else
            {
                Console.WriteLine("Eliminar usuario");
                Console.WriteLine("");
                Console.WriteLine($"Nombre Del Cliente: {UsuarioIndividualD.NombreDelCliente}, Apellido Del Cliente: {UsuarioIndividualD.ApellidoDelCliente}, Telefono: {UsuarioIndividualD.Telefono}");
                Console.WriteLine("");
                Console.WriteLine("El usuario encontrado es el correcto? Precione 1");
                var Lector = Convert.ToInt32(Console.ReadLine());
                if (Lector == 1)
                {
                    var Id = Convert.ToInt32(UsuarioIndividualD.Id);
                    Console.WriteLine(cliente.EliminarUsuario(Id));
                }
                else
                {
                    Console.WriteLine("Inicia Nuevamente");
                }
            }
            break;

        case 4:
            Console.WriteLine("Ingrese El Nombre Del Producto: ");
            CrudProductos.NombreDelProducto = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Ingrese la descripcion del Producto: ");
            CrudProductos.DescripcionDelProducto = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Ingrese el Id Clientes: ");
            CrudProductos.IdClientes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            productos.TablaProductos(CrudProductos);
            Console.WriteLine("");

            Console.WriteLine("Su Registro Ha Sido Guardado Exitosamente...");
            Console.WriteLine("======================================");
            Console.WriteLine("");
            break;
        case 5:
            Console.WriteLine("Actualizar datos de la tabla Productos");
            Console.WriteLine("");
            Console.WriteLine("Ingresa el ID de Productos para actualizar");
            var UsuarioIndividual = productos.UsuarioIndividual(Convert.ToInt32(Console.ReadLine()));
            if (UsuarioIndividual == null)

            {
                Console.WriteLine("El ID no existe");
            }
            else
            {
                Console.WriteLine($"Nombre Del Producto: {UsuarioIndividual.NombreDelProducto}, Descripcion Del Producto: {UsuarioIndividual.DescripcionDelProducto}, Id_Clientes: {UsuarioIndividual.IdClientes}");

                Console.WriteLine("");

                Console.WriteLine("Para Actualizar Nombre del Producto y Descripcion del Producto preciona 1");

                Console.WriteLine("");

                Console.WriteLine("Para Actualizar Id Clientes preciona 2");

                var Lector = Convert.ToInt32(Console.ReadLine());
                if (Lector == 1)
                {
                    Console.WriteLine("Ingrese el nuevo Nombre: ");
                    UsuarioIndividual.NombreDelProducto = (Console.ReadLine());

                    Console.WriteLine("");

                    Console.WriteLine("Ingrese la nueva Descripcion: ");
                    UsuarioIndividual.DescripcionDelProducto = (Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Ingrese el ID del Cliente: ");
                    UsuarioIndividual.IdClientes = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                }
                productos.ActualizarUsuario(UsuarioIndividual, Lector);
                Console.WriteLine("");
                Console.WriteLine("Actualizacion Correcta");
            }
            break;
        case 6:
            Console.WriteLine("Ingresa el Id a Eliminar");
            var UsuarioIndividualP = productos.UsuarioIndividual(Convert.ToInt32(Console.ReadLine()));
            if (UsuarioIndividualP == null)
            {
                Console.WriteLine("Este Id no Existe");
            }
            else
            {
                Console.WriteLine("Eliminar usuario");
                Console.WriteLine("");
                Console.WriteLine($"Nombre Del Producto: {UsuarioIndividualP.NombreDelProducto}, Descripcion Del Producto: {UsuarioIndividualP.DescripcionDelProducto}, Id_Clientes: {UsuarioIndividualP.Id}");
                Console.WriteLine("");
                Console.WriteLine("El usuario encontrado es el correcto? Precione 1");
                var Lector = Convert.ToInt32(Console.ReadLine());
                if (Lector == 1)
                {
                    var Id = Convert.ToInt32(UsuarioIndividualP.Id);
                    Console.WriteLine(productos.EliminarUsuario(Id));
                }
                else
                {
                    Console.WriteLine("Inicia Nuevamente");
                }
            }
            break;

        case 7:
            Console.WriteLine("Ingrese El Id del Cliente que realizo la Compra: ");
            CrudVenta.IdClientes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el Id del Producto que compro el Cliente: ");
            CrudVenta.IdProductos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            venta.TablaVentas(CrudVenta);
            Console.WriteLine("");

            Console.WriteLine("Su Registro Ha Sido Guardado Exitosamente...");
            Console.WriteLine("======================================");
            Console.WriteLine("");
            break;
        case 8:
            Console.WriteLine("Actualizar datos de la tabla Venta");
            Console.WriteLine("");
            Console.WriteLine("Ingresa el Id de Venta a actualizar");
            var UsuarioIndividualV = venta.UsuarioIndividual(Convert.ToInt32(Console.ReadLine()));
            if (UsuarioIndividualV == null)

            {
                Console.WriteLine("El Usuario no existe");
            }
            else
            {
                Console.WriteLine($"Id del Cliente: {UsuarioIndividualV.IdClientes}, Id de Producto: {UsuarioIndividualV.IdProductos}");

                Console.WriteLine("");

                Console.WriteLine("Para Actualizar Id del Cliente preciona 1");

                Console.WriteLine("");

                Console.WriteLine("Para Actualizar Id de Producto preciona 2");

                var Lector = Convert.ToInt32(Console.ReadLine());
                if (Lector == 1)
                {
                    Console.WriteLine("Ingrese el nuevo ID del Cliente: ");
                    UsuarioIndividualV.IdClientes = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Ingrese el nuevo ID del Producto: ");
                    UsuarioIndividualV.IdProductos = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                }
                venta.ActualizarUsuario(UsuarioIndividualV, Lector);
                Console.WriteLine("");
                Console.WriteLine("Actualizacion Correcta");
            }
            break;
        case 9:
            Console.WriteLine("Ingresa el Id a Eliminar");
            var UsuarioIndividualVE = venta.UsuarioIndividual(Convert.ToInt32(Console.ReadLine()));
            if (UsuarioIndividualVE == null)
            {
                Console.WriteLine("Este Usuario no Existe");
            }
            else
            {
                Console.WriteLine("Eliminar usuario");
                Console.WriteLine("");
                Console.WriteLine($"Id del Cliente: {UsuarioIndividualVE.IdClientes}, Id de Producto: {UsuarioIndividualVE.IdProductos}");
                Console.WriteLine("");
                Console.WriteLine("El usuario encontrado es el correcto? Preciona 1");
                var Lector = Convert.ToInt32(Console.ReadLine());
                if (Lector == 1)
                {
                    var Id = Convert.ToInt32(UsuarioIndividualVE.Id);
                    Console.WriteLine(venta.EliminarUsuario(Id));
                }
                else
                {
                    Console.WriteLine("Inicia Nuevamente");
                }
            }
            break;


        case 10:
            Console.WriteLine("Ingrese El Id del Producto que se compro: ");
            crudVentaDetalles.Id_Productos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el Id de Ventas que se compro: ");
            crudVentaDetalles.Id_Ventas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese la Cantidad de la Compra: ");
            crudVentaDetalles.CantidadDeLaCompra = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el Precio de la Compra: ");
            crudVentaDetalles.PrecioDeLaCompra = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("El Precio de la Compra es $: " + ventaDetalle.OperacionMatematica(crudVentaDetalles));

            ventaDetalle.TablaVentaDetalle(crudVentaDetalles);
            Console.WriteLine("");

            Console.WriteLine("Su Registro Ha Sido Guardado Exitosamente...");
            Console.WriteLine("======================================");
            Console.WriteLine("");
            break;
        case 11:
            Console.WriteLine("Ingresa el Id a Eliminar");
            var UsuarioIndividualVDT = ventaDetalle.UsuarioIndividual(Convert.ToInt32(Console.ReadLine()));
            if (UsuarioIndividualVDT == null)
            {
                Console.WriteLine("Este Usuario no Existe");
            }
            else
            {
                Console.WriteLine("Eliminar usuario");
                Console.WriteLine("");
                Console.WriteLine($"Id del Producto: {UsuarioIndividualVDT.Id_Productos}, Id de Ventas: {UsuarioIndividualVDT.Id_Ventas}, Cantidad de la Compra: {UsuarioIndividualVDT.CantidadDeLaCompra}, Precio de la Compra: {UsuarioIndividualVDT.PrecioDeLaCompra}, Precio Total: {UsuarioIndividualVDT.PrecioTotal}");
                Console.WriteLine("");
                Console.WriteLine("El usuario encontrado es el correcto? Preciona 1");
                var Lector = Convert.ToInt32(Console.ReadLine());
                if (Lector == 1)
                {
                    var Id = Convert.ToInt32(UsuarioIndividualVDT.Id);
                    Console.WriteLine(ventaDetalle.EliminarUsuario(Id));
                }
                else
                {
                    Console.WriteLine("Inicia Nuevamente");
                }
            }
            break;
    }
    Console.WriteLine("");
    Console.WriteLine("Desea continuar ? Precione S/N");
    var cont = Console.ReadLine();
    if (cont.Equals("N"))
    {
        Continuar = false;
    }
}


    

