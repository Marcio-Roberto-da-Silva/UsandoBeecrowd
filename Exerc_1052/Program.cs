﻿using System;
using System.Globalization;

namespace Exerc_1052 {
    class Program {
        static void Main(string[] args) {

            int mes = 0;

            mes = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (mes == 1) {
                Console.WriteLine("January");
            }
            if (mes == 2) {
                Console.WriteLine("February");
            }
            if (mes == 3) {
                Console.WriteLine("March");
            }
            if (mes == 4) {
                Console.WriteLine("April");
            }
            if (mes == 5) {
                Console.WriteLine("May");
            }
            if (mes == 6) {
                Console.WriteLine("June");
            }
            if (mes == 7) {
                Console.WriteLine("July");
            }
            if (mes == 8) {
                Console.WriteLine("August");
            }
            if (mes == 9) {
                Console.WriteLine("September");
            }
            if (mes == 10) {
                Console.WriteLine("October");
            }
            if (mes == 11) {
                Console.WriteLine("November");
            }
            if (mes == 12) {
                Console.WriteLine("December");
            }
            Console.ReadKey();
        }
    }
}
