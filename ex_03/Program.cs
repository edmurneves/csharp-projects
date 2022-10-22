using System;
using System.Globalization;

namespace ex_03;
class Program
{   
    static void Main(string[] args)
    {
        Retangulo ret = new Retangulo();
        
        Console.WriteLine("Entre a largura e altura do retângulo: ");
        ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double area = ret.Area();
        double perimetro = ret.Perimetro();
        double diagonal = ret.Diagonal();

        Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
                    
    }


}
