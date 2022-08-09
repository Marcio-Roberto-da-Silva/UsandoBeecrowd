using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_1009 {
    class Program {
        static void Main(string[] args) {

            string NomeVendedor = Console.ReadLine();
            double Salario = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            double TotalVendas = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            double SalarioTotal = (0.15 * TotalVendas);

            Console.WriteLine("TOTAL = R$ " + SalarioTotal.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
