using System;
using System.Globalization;

namespace Exerc_1005 {
    class Program {
        static void Main(string[] args) {

            double nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (nota1 * 3.5 + nota2 * 7.5) / 11;

            Console.WriteLine($"MEDIA = { Media.ToString("F5", CultureInfo.InvariantCulture)}");

            Console.ReadKey();




        }
    }
}
