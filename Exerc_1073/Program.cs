using System;


namespace Exerc_1073 {
    class Program {
        static void Main(string[] args) {

            int x, y = 2;

            x = int.Parse(Console.ReadLine());

            for(int i =1; i<=x; i++) {
                
                if(i % 2 == 0) {

                    Console.WriteLine("{0}^{1} = {2}",i,y,Math.Pow(i,2));
                }
            }

            Console.ReadKey();
        }
    }
}
