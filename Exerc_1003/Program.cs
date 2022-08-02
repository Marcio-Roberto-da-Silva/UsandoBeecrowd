using System;

namespace Exerc_1003 {
 
   class Program {
        static void Main(string[] args) {
            int Soma;
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            Soma = A + B;

            Console.WriteLine("SOMA = " + Soma);
            Console.ReadKey();
        }
    }
}