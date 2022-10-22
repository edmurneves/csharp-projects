﻿using System;
using System.Globalization;

namespace Course;

class Program {  
    static void Main(string[] args) {

       Calculadora calc = new Calculadora();

       Console.Write("Entre o valor do raio: ");
       double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

       double circ = calc.Circunferencia(raio);
       double volume = calc.Volume(raio);

       Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
       Console.WriteLine("volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
       Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
    }
        
}