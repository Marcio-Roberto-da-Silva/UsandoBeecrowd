using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

namespace Exerc_1004 {
    class Program {
        static void Main(string[] args) {

            int PROD;
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            PROD = A * B;

            Console.WriteLine("PROD = " + PROD);

            Console.ReadKey();

        }
    }
}
