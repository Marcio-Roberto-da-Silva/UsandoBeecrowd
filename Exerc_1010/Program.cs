using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_1010 {
    class Program {
        static void Main(string[] args) {

            
            string [] Peca1 = Console.ReadLine().Split(' ');
            int NumeroPeca1 = Convert.ToInt32(Peca1[1], CultureInfo.InvariantCulture);
            double ValorPeca1 = Convert.ToDouble(Peca1[2], CultureInfo.InvariantCulture);

            
            string [] Peca2 = Console.ReadLine().Split(' ');
            int NumeroPeca2 = Convert.ToInt32(Peca2[1], CultureInfo.InvariantCulture);
            double ValorPeca2 = Convert.ToDouble(Peca2[2], CultureInfo.InvariantCulture);

            
            double ValorAPagar = (NumeroPeca1 * ValorPeca1) + (NumeroPeca2 * ValorPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + ValorAPagar.ToString("f2",CultureInfo.InvariantCulture ));
            
            Console.ReadKey();
        }
    }
}
