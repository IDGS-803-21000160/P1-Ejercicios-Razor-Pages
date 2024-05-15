using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P1_Ejercicios_RazorPage.Pages
{
	public class Programa3Model : PageModel
    {
        
        public List<double> resultados = new List<double>();
        public double res1 = 0;
        [BindProperty]
        public int a { get; set; } = 0;
        [BindProperty]
        public int b { get; set; } = 0;
        [BindProperty]
        public int x { get; set; } = 0;
        [BindProperty]
        public int y { get; set; } = 0;
        [BindProperty]
        public int n { get; set; } = 0;

        public void OnPost()
        {
            res1 = Math.Pow((a * x) + (b * y), n);


            for (int k = 0; k <= n; k++)
            {
                double resultado_k = BinomialCoefficient(n, k) * Math.Pow(a * x, n - k) * Math.Pow(b * y, k);
                resultados.Add(resultado_k);
            }

            ModelState.Clear();
        }
        
        private double BinomialCoefficient(int n, int k)
        {
            double result = Factorial(n) / (Factorial(k) * Factorial(n - k));
            return result;
        }

        
        private double Factorial(int num)
        {
            if (num == 0)
                return 1;
            double result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
