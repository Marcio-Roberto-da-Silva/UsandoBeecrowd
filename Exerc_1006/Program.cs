using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_1006 {
    class Program {
        static void Main(string[] args) {

            double nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;

            Console.WriteLine($"MEDIA = { Media.ToString("F1", CultureInfo.InvariantCulture)}");

            Console.ReadKey();

        }
    }
}
