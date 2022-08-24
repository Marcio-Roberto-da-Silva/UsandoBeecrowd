using System;
using System.Globalization;

namespace Exerc_1046 {
    class Program {
        static void Main(string[] args) 
        {

            int horaInicio, horaFim;

            var temp = 0;
            
            string[] leitura = Console.ReadLine().Split(' ');

            horaInicio = int.Parse(leitura[0], CultureInfo.InvariantCulture);
            horaFim = int.Parse(leitura[1], CultureInfo.InvariantCulture);

            if (horaInicio > horaFim) { temp = (24 - horaInicio) + horaFim; }

            if (horaInicio < horaFim) { temp = horaFim - horaInicio; }

            if (horaInicio == horaFim) {temp = 24;
            }
            Console.WriteLine($"O JOGO DUROU {temp} HORA(S)", (CultureInfo.InvariantCulture));
            
            Console.ReadKey();
          
        }
        
    }
}
