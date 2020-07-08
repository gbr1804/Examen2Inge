using ProyectoExamen2GBR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoExamen2GBR.Controllers
{
    public class OrdenController
    {
        public OrdenModel orden { get; set; }
        public double calculaPrecio(string tamano, int cantidadIngTradicionales, int cantidadIngSecundarios)
        {
            orden = new OrdenModel();
            double precio = orden.calculaPrecio(tamano, cantidadIngTradicionales, cantidadIngSecundarios);
            return precio;
        }
    }
}
