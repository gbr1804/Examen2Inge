using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoExamen2GBR.Models
{
    public class OrdenModel
    {
        public double calculaPrecio(string tamano, int cantidadIngTradicionales, int cantidadIngSecundarios)
        {
            double porcentajeIva = 13;
            double precioExpress = 500;
            double precioIngTradicional = 200;
            double precioIngSecundario = 400;
            double precioTamano = 0;
            switch (tamano)
            {
                case "pequena":
                    precioTamano = 2000;
                    break;
                case "mediana":
                    precioTamano = 4000;
                    break;
                case "grande":
                    precioTamano = 6000;
                    break;
                default:
                    break;
            }
            double precioSinImpuesto = precioTamano + cantidadIngTradicionales * precioIngTradicional + cantidadIngSecundarios * precioIngSecundario;
            double precioConImpuesto = (precioSinImpuesto/100) * (100+porcentajeIva);
            precioConImpuesto = precioConImpuesto + precioExpress;
            return precioConImpuesto;
        }
    }
}
