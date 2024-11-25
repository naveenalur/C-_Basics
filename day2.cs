using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {

        //user input 




        /*
        Methods/Function
             Methods are reusable code blocks that perform a specific task.
        Synctax : 
             <Access Specifier> <Return Type> <Method Name> (Parameter)

           1. Method with no return type and no parameter
               
           2. Method with no return type and with parameter
                
        *Call By value ANd Call by reffernce - Last Priority.
        *
        */

        Console.WriteLine("Calling Addition() method Started...");
        //Addition();
        //Multiplication();
        Console.WriteLine("Enter your First Number ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your Second Number ");
        int secondsNumber = int.Parse(Console.ReadLine());

        //Addition(10, 20);
        //Addition(firstNumber, secondsNumber);
        //Multiplication(firstNumber, secondsNumber);

        
        int dataFormMethod= AdditionWithReturnType(firstNumber, secondsNumber);

        int finalValue = dataFormMethod + 1000;


        Console.WriteLine("Calling Addition() method Ended...");

    }

    //Method with no return type and no parameter
    private static void Addition()
    {
        Console.WriteLine("Enter your First Number ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your Second Number ");
        int secondsNumber = int.Parse(Console.ReadLine());

        int sum = firstNumber + secondsNumber;
        Console.WriteLine("Sum of two number is : " + sum);
    }

    private static void Multiplication()
    {
        Console.WriteLine("Enter your First Number ");
        int firstNumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter your Second Number ");
        int secondsNumber = int.Parse(Console.ReadLine());

        int Multiplication = firstNumber * secondsNumber;
        Console.WriteLine("Multiplication of two number is : " + Multiplication);
    }

    //Method with no return type and with parameter
    public static void Addition(int firstNumber, int secondsNumber)
    {
        Console.WriteLine("I am From Addition(int firstNumber, int secondsNumber)");
        int sum = firstNumber + secondsNumber;
        Console.WriteLine("Sum of two number is : " + sum);
    }

    public static void Multiplication(int firstNumber, int secondsNumber)
    {
        Console.WriteLine("I am From Multiplication(int firstNumber, int secondsNumber)");
        int mul = firstNumber * secondsNumber;
        Console.WriteLine("Multiplication of two number is : " + mul);
    }

    //Method with return type and with parameter

    public static int AdditionWithReturnType(int firstNumber, int secondsNumber)
    {
        Console.WriteLine("I am From AdditionWithReturnType(int firstNumber, int secondsNumber)");
        int sum = firstNumber + secondsNumber;
        Console.WriteLine("Sum of two number is : " + sum);
        return sum;
    }


}
