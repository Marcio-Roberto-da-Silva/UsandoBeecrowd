using System;
using System.Globalization;

namespace Exerc_1044 {
    class Program {
        static void Main(string[] args) {

            int A, B;
            int divisao;
            string[] leitura = Console.ReadLine().Split(' ');

            A = int.Parse(leitura[0], CultureInfo.InvariantCulture);
            B = int.Parse(leitura[1], CultureInfo.InvariantCulture);

            if (A < B) {

                divisao = B % A;
            } 
            else {
                divisao = A % B;
            }
            if (divisao == 0) {

                Console.WriteLine("Sao Multiplos");
            } 
            else {
                Console.WriteLine("Nao sao Multiplos");

            }
            Console.ReadKey();
        }  
    }
}
