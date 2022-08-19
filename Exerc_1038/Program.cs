using System;
using System.Globalization;

namespace Exerc_1038 {
    class Program {
        static void Main(string[] args) {


            String[] esp = Console.ReadLine().Split(' ');

            int cod = int.Parse(esp[0],CultureInfo.InvariantCulture);
            int qtd = int.Parse(esp[1],CultureInfo.InvariantCulture);
            double preco = 0;

            if (cod == 1)
                preco = 4;
            else if (cod == 2)
                 preco = 4.5;
            else if (cod == 3)
                preco = 5;
            else if (cod == 4)
                preco  = 2;
            else if (cod == 5)
                preco = 1.5;
            double k = preco * qtd;


            Console.WriteLine("Total: R$ " + k.ToString("0.00"),(CultureInfo.InvariantCulture));


            Console.ReadKey();

        }
    }
}
