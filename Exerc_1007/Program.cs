using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_1007 {
    class Program {
        static void Main(string[] args) {

            int A = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
            int B = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
            int C = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
            int D = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

            int Diferenca = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + Diferenca);
            Console.ReadKey();
        }
    }
}
