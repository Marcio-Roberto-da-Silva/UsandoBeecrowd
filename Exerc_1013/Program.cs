using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_1013 {
    class Program {
        static void Main(string[] args) {

            string[] Area = Console.ReadLine().Split(' ');

            int Valor1 = Convert.ToInt32(Area[0], CultureInfo.InvariantCulture);
            int Valor2 = Convert.ToInt32(Area[1], CultureInfo.InvariantCulture);
            int Valor3 = Convert.ToInt32(Area[2], CultureInfo.InvariantCulture);

            int MaiorAB = (Valor1 + Valor2 + Math.Abs(Valor1 - Valor2)) / 2;

            if (MaiorAB> Valor3) {
                Console.WriteLine($"{MaiorAB} eh o maior");
            } else {
                Console.WriteLine($"{Valor3} eh o maior");
            }
            
            Console.ReadKey();
        }
    }
}
