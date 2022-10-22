using System;
using System.Globalization;

namespace Course;

class Program {  
    static void Main(string[] args) {      

       Console.Write("Qual é a cotação do dólar? ");
       double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

       Console.Write("Quantos dólar você vai comprar? ");
       double qteDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

       double valor = ConversorDeMoeda.Conversor(cotacaoDolar, qteDolar);    

       Console.WriteLine("Valor a ser pago em reais: " + valor.ToString("F2", CultureInfo.InvariantCulture));
       
    }
        
}