using System;
using System.Globalization;

namespace Exerc_1042 {
    class Program {
        static void Main(string[] args) {

            int A, B, C;
            int X, Y, Z;
            int conv;
            string[] leitura = Console.ReadLine().Split(' ');

            A = int.Parse(leitura[0], CultureInfo.InvariantCulture);
            B = int.Parse(leitura[1], CultureInfo.InvariantCulture);
            C = int.Parse(leitura[2], CultureInfo.InvariantCulture);

            X = A;
            Y = B;
            Z = C;

            if (X > Y) {
                conv = X;
                X = Y;
                Y = conv;
            }
            if (X > Z) {
                conv = X;
                X = Z;
                Z = conv;

            }
            if (Y > Z) {
                conv = Y;
                Y = Z;
                Z = conv;

            }
            Console.WriteLine(X);
            Console.WriteLine(Y);
            Console.WriteLine(Z);
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);


            Console.ReadKey();
        } 
        
    }
}
