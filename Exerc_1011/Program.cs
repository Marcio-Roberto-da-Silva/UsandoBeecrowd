using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_1011 {
    class Program {
        static void Main(string[] args) {

            double Pi = 3.14159;
            double raio = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

            double volume = (4.0 / 3) * Pi * Math.Pow(raio, 3);
            Console.WriteLine("VOLUME = " + volume.ToString("f3", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
