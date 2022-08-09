using System;


using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_1017 {
    class Program {
        static void Main(string[] args) {


            decimal horas = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
            decimal velocidade = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);


            decimal Resultado  = ( horas * velocidade )/12;

            Console.WriteLine(Resultado.ToString("f3"));

            Console.ReadKey();

        }
    }
}
