using System;
using System.Globalization;

namespace Exerc_1041 {
    class Program {
        static void Main(string[] args) {

            float x, y;

            string[] leitura = Console.ReadLine().Split(' ');

            x = float.Parse(leitura[0], CultureInfo.InvariantCulture);
            y = float.Parse(leitura[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0) {

                Console.WriteLine("Origem");

            } else if (x == 0 && y!= 0) {

                Console.WriteLine("Eixo Y");

            } else if (x!= 0 && y == 0) {

                Console.WriteLine("Eixo X");
            } else if (x > 0 && y > 0) {

                Console.WriteLine("Q1");
            } else if (x < 0 && y > 0) {

                Console.WriteLine("Q2");
            } else if (x < 0 && y < 0) {

                Console.WriteLine("Q3");
            } else if (x > 0 && y < 0) {

                Console.WriteLine("Q4");

            }
            Console.ReadKey();
        }
    }
}

