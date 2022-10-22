using System;
using System.Globalization;

namespace ex_04;
class Program
{   
    static void Main(string[] args)
    {
        Funcionario func = new Funcionario();

        Console.Write("Nome: ");
        func.Nome = Console.ReadLine();

        Console.Write("Salário Bruto: ");
        func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Imposto: ");
        func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);        

        Console.WriteLine("Funcionário: " + func);
        
        Console.Write("Digite a Porcentagem para aumentar o salário: ");
        double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        func.AumentarSalario(porcentagem);

        Console.WriteLine("Dados atualizados: " + func);

               
            
    }


}
