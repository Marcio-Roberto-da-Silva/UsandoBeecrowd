using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_1020 {
    class Program {
        static void Main(string[] args) {

            int N; 
            int resto;
            int ano365;
            int mes30;
            int dia;


            N = int.Parse(Console.ReadLine());

            ano365 = N / 365;
            resto = N % 365;
            Console.WriteLine(ano365 + " ano(s)");

            mes30 = resto / 30;
            dia = resto % 30;
            Console.WriteLine(mes30 + " mes(es)");

            Console.WriteLine(dia + " dia(s)");

            Console.ReadLine();
        }
    }
}
