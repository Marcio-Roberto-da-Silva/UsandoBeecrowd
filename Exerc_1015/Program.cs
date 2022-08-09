using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_1015 {
    class Program {
        static void Main(string[] args) {

            string [] Area1 = Console.ReadLine().Split(' ');

            double X1 = double.Parse(Area1[0], CultureInfo.InvariantCulture);
            double Y1 = double.Parse(Area1[1], CultureInfo.InvariantCulture);

            string[] Area2 = Console.ReadLine().Split(' ');
            double X2 = double.Parse(Area2[0], CultureInfo.InvariantCulture);
            double Y2 = double.Parse(Area2[1], CultureInfo.InvariantCulture);

            

            

            double Distancia =  Math.Sqrt((Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)));

            Console.WriteLine(Distancia.ToString("f4",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
