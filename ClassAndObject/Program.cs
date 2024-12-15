using data_type_and_methods;
using System.Diagnostics.CodeAnalysis;

public class Program
{
    public static void Main(string[] args)
    {

        Employee empNaveen = new Employee();

        Employee empTeju = new Employee();

        Employee empBhima = new Employee();

        empNaveen.EmpId = 100;
        empNaveen.Name = "Naveen";
        empNaveen.City = "Davanagere";
        empNaveen.Display();
        Console.WriteLine(empNaveen.GetHashCode());

        Console.WriteLine("Employee Teju");
        empTeju.Display();
        Console.WriteLine(empTeju.GetHashCode());

        Console.WriteLine("Employee Bhima");
        empTeju.Display();
        Console.WriteLine(empBhima.GetHashCode());

    }

}