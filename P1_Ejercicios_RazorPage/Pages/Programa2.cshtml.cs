using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P1_Ejercicios_RazorPage.Pages
{
	public class Programa2Model : PageModel
    {
        public String res = "";
        [BindProperty]
        public string mensaje { get; set; } = "";
        [BindProperty]
        public int n { get; set; } = 0;
        public void OnPost()
        {

            res = CifradoMS(mensaje, n);

            ModelState.Clear();
        }

        private string CifradoMS(string mensaje, int n)
        {
            string resultado = "";
            foreach (char letra in mensaje)
            {
                if (char.IsLetter(letra))
                {
                    char letraCifrada = (char)(letra + n);
                    if ((char.IsLower(letra) && letraCifrada > 'z') || (char.IsUpper(letra) && letraCifrada > 'Z'))
                    {
                        letraCifrada = (char)(letraCifrada - 26);
                    }
                    resultado += letraCifrada;
                }
                else
                {
                    resultado += letra;
                }
            }
            return resultado;
        }
    }
}
