using System;
using System.Globalization;

namespace Exerc_1043 {
    class Program {
        static void Main(string[] args) {

            double A, B, C;
            
            string[] leitura = Console.ReadLine().Split(' ');

            A = double.Parse(leitura[0], CultureInfo.InvariantCulture);
            B = double.Parse(leitura[1], CultureInfo.InvariantCulture);
            C = double.Parse(leitura[2], CultureInfo.InvariantCulture);

            if (A < (B + C) && C < (A + B) && B < (A + C)) {
                Console.WriteLine("Perimetro = " + (A + B + C).ToString("0.0"),CultureInfo.InvariantCulture);
            } else {
                Console.WriteLine("Area = " + (((A + B) * C) / 2).ToString("0.0"),CultureInfo.InvariantCulture);
            }
            Console.ReadKey();


        }
    }
}
