using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoExamen2GBR.Controllers;

namespace ProyectoExamen2GBR.Pages
{
    public class PersonalizarPizzaModel : PageModel
    {
        OrdenController ordenControl { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            ordenControl = new OrdenController();
            string[] tamano = Request.Form["Tamano"];
            string[] ingTradicionales = Request.Form["Ing1"];
            string[] ingSecundarios = Request.Form["Ing2"];
            int numIngTradicionales = ingTradicionales.Length;
            int numIngSecundarios = ingTradicionales.Length;
            //double precio = ordenControl.calculaPrecio(tamano, numIngTradicionales, numIngSecundarios);
            double precio = ordenControl.calculaPrecio("mediano", numIngTradicionales, numIngSecundarios);
            return RedirectToPage("Precio");
        }
    }
}