using System;
using System.Globalization;

namespace Exerc_1049 {
    class Program {
        static void Main(string[] args) {

            string a1, b2, c3, total = "";

            a1 = Convert.ToString(Console.ReadLine());
            b2 = Convert.ToString(Console.ReadLine());
            c3 = Convert.ToString(Console.ReadLine());

            if (a1 == "vertebrado") {

                if (b2 == "ave") {


                    if (c3 == "carnivoro") {


                        total = "aguia";


                    } else if (c3 == "onivoro") {
                        total = "pomba";
                    }
                } else if (b2 == "mamifero") {
                    if (c3 == "onivoro") {
                        total = "homem";
                    } else if (c3 == "herbivoro") {
                        total = "vaca";
                    }
                }
            } else if (a1 == "invertebrado") {
                if (b2 == "inseto") {
                    if (c3 == "hematofago") {
                        total = "pulga";
                    } else if (c3 == "herbivoro") {
                        total = "lagarta";
                    }
                } else if (b2 == "anelideo") {
                    if (c3 == "hematofago") {
                        total = "sanguessuga";
                    } else if (c3 == "onivoro") {
                        total = "minhoca";
                    }
                }
            }
            Console.WriteLine(total);

            Console.ReadKey();

        }
    }
}     
