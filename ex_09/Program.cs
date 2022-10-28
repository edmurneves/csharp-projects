using System;
using System.Globalization;

namespace ex_09;
class Program
{
    static void Main(string[] args)
    {
        List<Employee> list = new List<Employee>(); 

        Console.Write("How many employees wil be registered? ");
        int qtdEmployee = int.Parse(Console.ReadLine());

        for (int i = 1; i <= qtdEmployee; i++) {
            Console.WriteLine("Employee #" + i + ":");
            Console.Write("id: ");
            int idFunc = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string nameFunc = Console.ReadLine();
            Console.Write("Salary: ");
            double salaryFunc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            list.Add(new Employee(idFunc, nameFunc, salaryFunc));
            Console.WriteLine();
        }

        Console.Write("Enter the employee id that will have salary increase: ");
        int id = int.Parse(Console.ReadLine());

        Employee objs = list.Find(item => item.Id == id);

        if (objs == null) {
            Console.WriteLine("This id does not exist!");
        } else {
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            objs.IncreaseSalary(percentage);
        }

        Console.WriteLine();
        Console.WriteLine("Update list of employees:");
        
        foreach (Employee obj in list) {
            Console.WriteLine(obj.Id + ", " + obj.Name + ", " + obj.Salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
