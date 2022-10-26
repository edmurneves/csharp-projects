using System;
using System.Globalization;

namespace ex_08;
class Program
{
    static void Main(string[] args)
    {
        Aluno[] roons = new Aluno[10];

        Console.Write("How many roons will be rented? ");
        int qteRented = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= qteRented; i++) {
            Console.WriteLine("Rent #" + i + ":");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Room: ");
            int room = int.Parse(Console.ReadLine());
            Console.WriteLine();

            roons[room] = new Aluno(name, email, room);

        }
        Console.WriteLine();
        Console.WriteLine("Busy rooms:");
        Console.WriteLine();

        for (int i = 0; i < roons.Length; i++) {
            if (roons[i] != null)
            Console.WriteLine(roons[i].Room + ": " + roons[i].Name + ", " + roons[i].Email);
        }
    }
}
