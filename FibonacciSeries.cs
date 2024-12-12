using data_type_and_methods;
using System.Diagnostics.CodeAnalysis;

public class Program
{
    public static void Main(string[] args)
    {
        var input = 10;
        var firstNumber = 0;
        var secondNumber = 1;
        int nextNumber;

        Console.WriteLine("Fibonacci Series");

        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);

        for (int i = 2; i < input; i++)
        {
            nextNumber = firstNumber + secondNumber;
            Console.WriteLine(nextNumber);
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }



    }

}
