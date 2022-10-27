namespace foreach_ex;
class Program
{
    static void Main(string[] args)
    {
        string[] lista = new string[] {"Maria", "José", "João"};

        for (int i = 0; i < lista.Length; i++) {
            Console.WriteLine(lista[i]);
        }

        Console.WriteLine("--------------------------------------");

        foreach (string item in lista)
            Console.WriteLine("Nome: " + item);
    }
}
