using System;
using System.Globalization;

namespace Ex_05;

    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double NF = aluno.NotaFinal();

            if (NF >= 60.00)
            {
                Console.WriteLine("NOTA FINAL = " + NF.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + NF.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + ( 60.00 - NF).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

        }
    }
