using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_1014 {
    class Program {
        static void Main(string[] args) {

            int X = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Y = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Consumo = (Convert.ToDouble(X) / Y);

            Console.WriteLine($"{Consumo.ToString("f3", CultureInfo.InvariantCulture)} km/l");


            Console.ReadKey();
        }
    }
}
