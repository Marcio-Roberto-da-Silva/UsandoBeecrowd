using System;
using System.Globalization;

namespace Exerc_1019 {
    class Program {
        static void Main(string[] args) {

            int N = Convert.ToInt32(Console.ReadLine()); 
            int horas;
            int minutos ;
            int segundos ;
            int resto;

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;



            
            Console.WriteLine($"{horas}:{minutos}:{segundos}");

            Console.ReadKey();






        }
    }
}
