using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProyectoExamen2GBR.Pages
{
    public class PrecioModel : PageModel
    {
        public string TituloPrecio;
        public string MensajePrecio;
        public string Message;
        public void OnGet(double precio, string tamano, string[] ingTradicionales, string[] ingSecundarios)
        {
            TempData.TryGetValue("mensajeFinalizaExito", out object temp);

            if (temp != null)
            {
                Message = (string)temp;
            }
            else
            {
                TituloPrecio = "Precio a pagar, ya incluyendo el servicio Express y los impuestos";
                MensajePrecio = "El precio que se debe pagar por la pizza " + tamano + ", que contiene los ingredientes tradicionales: ";
                for (int i=0; i<ingTradicionales.Length; i++)
                {
                    MensajePrecio += ingTradicionales[i];
                    if(i < ingTradicionales.Length - 1)
                    {
                        MensajePrecio += ", ";
                    }
                }
                MensajePrecio += " y los ingredientes secundarios: ";
                for (int i = 0; i < ingSecundarios.Length; i++)
                {
                    MensajePrecio += ingSecundarios[i];
                    if (i < ingSecundarios.Length - 1)
                    {
                        MensajePrecio += ", ";
                    }
                }
                MensajePrecio += ", es de ₡" + precio;
            }   
        }

        public IActionResult OnPost()
        {
            TempData["mensajeFinalizaExito"] = "La orden ha sido tomada exitosamente. Espere su llegada. Gracias por su compra.";
            return RedirectToPage("Precio");
        }

    }
}