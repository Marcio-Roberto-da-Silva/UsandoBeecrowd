using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_1016 {
    class Program {
        static void Main(string[] args) {

            int X = Convert.ToInt32(Console.ReadLine(),CultureInfo.InvariantCulture);
            



            int Velocidade = (X * 2 );

            Console.WriteLine($"{Velocidade} minutos");

            Console.ReadKey();
        }
    }
}
