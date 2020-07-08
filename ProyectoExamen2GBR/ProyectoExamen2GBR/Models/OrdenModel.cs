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
            double porcentajeIva = 13; //Hay que usarlo
            double precioIngTradicional = 500;
            double precioIngSecundario = 600;
            double precioTamano = 0;
            switch (tamano)
            {
                case "pequeno":
                    precioTamano = 2000;
                    break;
                case "mediano":
                    precioTamano = 4000;
                    break;
                case "grande":
                    precioTamano = 6000;
                    break;
                default:
                    break;

            }
            double precioSinImpuesto = precioTamano + cantidadIngTradicionales * precioIngTradicional + cantidadIngSecundarios * precioIngSecundario;
            double precioConImpuesto = precioSinImpuesto * 1.13;
            return precioConImpuesto;
        }
    }
}
