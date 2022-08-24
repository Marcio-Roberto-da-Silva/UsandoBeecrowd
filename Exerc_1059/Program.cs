using System;


namespace Exerc_1059 {
    class Program {
        static void Main(string[] args) {

            int[] vetor = new int[101];

            for (int i = 1; i < vetor.Length; i++) {
                vetor[i] = i;
            }

            for (int j = 1; j < vetor.Length; j++) {

                int x = vetor[j] % 2;

                if (x == 0) {

                    Console.WriteLine(vetor[j]);

                }
            }
            Console.ReadKey();
        }
    }
}
