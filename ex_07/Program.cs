using System;
using System.Globalization;

namespace ex_07;
class Program {
    static void Main(string[] args) {

        Conta cc;

        Console.Write("Entre o número da conta: ");
        int conta = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n)? ");
        string opcaoDep = Console.ReadLine();

        if ( opcaoDep == "s") {

            Console.Write("Entre o valor de depósito inicial: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cc = new Conta(conta, titular, valor);

        } else {           

             cc = new Conta(conta, titular);

        }
        
            Console.WriteLine(); 
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cc);   


            Console.Write("Entre com um valor para depósito: ");
            double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            cc.Deposito(valorDep);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cc);

            Console.Write("Entre com um valor para saque: ");
            double valorSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            cc.Saque(valorSaq);            

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cc);
    }
}