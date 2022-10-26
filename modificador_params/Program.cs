namespace modificador_params;
class Program
{
    static void Main(string[] args)
    {
      
        
        int result = Calculator.Sum(1, 3, 5);
        int result2 = Calculator.Sum(new int[] {5, 5, 5, 5});

        Console.WriteLine(result);
        Console.WriteLine(result2);
       
    }
}
