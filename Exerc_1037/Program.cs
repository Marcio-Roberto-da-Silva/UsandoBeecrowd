using System;
using System.Globalization;

namespace Exerc_1037 {
    class Program {
        static void Main(string[] args) {

            float x = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (x >= 0.00 && x <= 25.00) {
                Console.WriteLine("Intervalo [0,25]");

            } else if (x > 25.00 && x <= 50.00) {
                Console.WriteLine("Intervalo (25,50]");

            } else if (x > 50.00 && x <= 75.00) {
                Console.WriteLine("Intervalo (50,75]");
                ;
            } else if (x > 75.00 && x <= 100.00) {
                Console.WriteLine("Intervalo (75,100]");

            } else {
                Console.WriteLine("Fora de intervalo");
            }
            Console.ReadKey();
        }


    }
    
}
