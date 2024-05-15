using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P1_Ejercicios_RazorPage.Pages
{
	public class Programa4Model : PageModel
    {
        public int[] numeros { get; set; }
        public int suma { get; set; }
        public double promedio { get; set; }
        public int moda { get; set; }
        public int mediana { get; set; }

        public void OnGet()
        {
            
            Random rnd = new Random();
            numeros = Enumerable.Range(1, 20).Select(_ => rnd.Next(0, 101)).ToArray();

            suma = numeros.Sum();

            promedio = numeros.Average();

            moda = numeros.GroupBy(x => x)
                          .OrderByDescending(g => g.Count())
                          .First().Key;

            Array.Sort(numeros);
            if (numeros.Length % 2 == 0)
            {
                mediana = (numeros[numeros.Length / 2 - 1] + numeros[numeros.Length / 2]) / 2;
            }
            else
            {
                mediana = numeros[numeros.Length / 2];
            }
        }
    }
}
