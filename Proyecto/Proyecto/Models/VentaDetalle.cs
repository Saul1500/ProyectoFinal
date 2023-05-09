using System;
using System.Collections.Generic;

namespace Proyecto.Models;

public partial class VentaDetalle
{
    public int Id { get; set; }

    public int? Id_Productos { get; set; }

    public int? Id_Ventas { get; set; }

    public decimal CantidadDeLaCompra { get; set; }

    public decimal PrecioDeLaCompra { get; set; }

    public decimal PrecioTotal { get; set; }

    public virtual Venta? IdVentasNavigation { get; set; }
}
