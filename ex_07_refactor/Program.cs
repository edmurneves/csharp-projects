using System;
using System.Globalization;

namespace course;

class Program {
    public static void Main() {

        ContaBancaria conta;

        Console.Write("Entre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n)? ");
        char inicialDep = char.Parse(Console.ReadLine());

        if (inicialDep == 's') {

            Console.Write("Entre o valor de deposito inicial: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta = new ContaBancaria(numero, titular, quantia);                         

        } else {
            conta = new ContaBancaria(numero, titular);
        }

        Console.WriteLine("Dados da Conta:");
        Console.WriteLine(conta);
        Console.WriteLine();

        Console.Write("Entre um valor de deposito: ");
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(valor);
        Console.Write("Dados da conta atualizados: ");
        Console.WriteLine(conta);
     
        Console.Write("Entre um valor para saque: ");
        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(valor);
        Console.Write("Dados da conta atualizados: ");
        Console.WriteLine(conta);

    }
}

