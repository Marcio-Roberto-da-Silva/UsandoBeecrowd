using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_1008 {
    class Program {
        static void Main(string[] args) {

            int NumeroFuncionario = Convert.ToInt32(Console.ReadLine());
            int NumeroHoras = Convert.ToInt32(Console.ReadLine());
            double ValorHora = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Salario = (NumeroHoras * ValorHora);

            Console.WriteLine("NUMBER = " + NumeroFuncionario);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("f2",CultureInfo.InvariantCulture));

            Console.ReadKey();


           

        }
    }
}
