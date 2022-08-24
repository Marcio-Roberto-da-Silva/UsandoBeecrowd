using System;
using System.Globalization;

namespace Exerc_1045 {
    class Program {
        static void Main(string[] args) {

            double A, B, C;
            double divisao;
            string[] leitura = Console.ReadLine().Split(' ');

            A = double.Parse(leitura[0], CultureInfo.InvariantCulture);
            B = double.Parse(leitura[1], CultureInfo.InvariantCulture);
            C = double.Parse(leitura[2], CultureInfo.InvariantCulture);

            if (A < B) {
                divisao = A;
                A = B;
                B = divisao;
            }
            if (A < C) {
                divisao = A;
                A = C;
                C = divisao;
            }
            if (B < C) {
                divisao = B;
                B = C;
                C = divisao;
            }
            if (A >= B + C) Console.WriteLine("NAO FORMA TRIANGULO");
            else {
                if (A * A == B * B + C * C) Console.WriteLine("TRIANGULO RETANGULO");
                if (A * A > B * B + C * C) Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (A * A < B * B + C * C) Console.WriteLine("TRIANGULO ACUTANGULO");
                if (A == B && A == C && B == C) Console.WriteLine("TRIANGULO EQUILATERO");
                else {
                    if (A == B || A == C || B == C) Console.WriteLine("TRIANGULO ISOSCELES");
                }
                
            }
            Console.ReadKey();
        }
    }
}
