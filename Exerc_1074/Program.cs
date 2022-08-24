using System;


namespace Exerc_1074 {
    class Program {
        static void Main(string[] args) {

            int N, X, i;

            N = int.Parse(Console.ReadLine());

            for (i = 1; i <= N; i++) {

                X = int.Parse(Console.ReadLine());

                if (X == 0) {
                    Console.WriteLine("NULL");
                } else if (X <= 0 && X % 2 == 0) {

                    Console.WriteLine("EVEN NEGATIVE");
                } else if (X <= 0 && X % 2 == -1) {
                    Console.WriteLine("ODD NEGATIVE");
                } 
                else if (X >= 0 && X % 2 == 0) {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (X >= 0 && X % 2 == 1) {
                    Console.WriteLine("ODD POSITIVE");
                }

            }
            Console.ReadKey();

        }
    }
}
