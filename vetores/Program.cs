using System;
using System.Globalization;

namespace vetores;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double[] vect = new double[n];

        for (int i = 0; i < n; i++) {
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double sum = 0;

        for (int i = 0; i < n; i++) {
            sum += vect[i];
        }

        double avg = sum / n;

        Console.WriteLine("Média de altura: " + avg.ToString("F2", CultureInfo.InvariantCulture));

    }
}
