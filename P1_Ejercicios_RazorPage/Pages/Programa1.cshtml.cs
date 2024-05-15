using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P1_Ejercicios_RazorPage.Pages
{
	public class Programa1Model : PageModel
    {
        public double IMC = 0;
        [BindProperty]
        public string peso { get; set; } = "";
        [BindProperty]
        public string altura { get; set; } = "";
        public void OnPost()
        {
            double pesoo = Convert.ToDouble(peso);
            double alturaa = Convert.ToDouble(altura);

            IMC = pesoo / (alturaa * alturaa);

            ModelState.Clear();
        }
    }
}
