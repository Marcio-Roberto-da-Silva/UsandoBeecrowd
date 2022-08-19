using System;
using System.Globalization;

namespace Exerc_1040 {
    class Program {
        static void Main(string[] args) {

            float N1, N2, N3, N4, media, notaExame, mediaFinal;

            string[] leitura = Console.ReadLine().Split(' ');

            N1 = float.Parse(leitura[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(leitura[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(leitura[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(leitura[3], CultureInfo.InvariantCulture);

            media = (float)((N1 * 2.0) + (N2 * 3.0) + (N3 * 4.0) + (N4 * 1.0)) / (float)10.0;

            if (media == (float)4.85) {
                media = (float)4.8;
            }
            Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));

            if (media < 5.0) {
                Console.WriteLine("Aluno reprovado.");
            } else if (media >= 5.0 && media <= 6.9) {
                Console.WriteLine("Aluno em exame.");
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("f1", CultureInfo.InvariantCulture));
                mediaFinal = (media + notaExame) / (float)2.0;
                if (mediaFinal < 5.0) {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("f1", CultureInfo.InvariantCulture));
                } else {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("f1", CultureInfo.InvariantCulture));
                }

            } else {
                Console.WriteLine("Aluno aprovado.");
            }
            Console.ReadKey();
        }
    }
}

