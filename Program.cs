public class Program
{
    public static void Main(string[] args)
    {

        //user input 

        Console.WriteLine("ENTER YOUR NAME");
        string name=Console.ReadLine();
        Console.WriteLine(name);
        // <DataType> <VariableName> = <Value>;

        /*
         Integer 
         Declare a variable of type int and assign it a value of 42
         Syntax: int variableName = value;
        */
        int integrevariable; //declaration 
        integrevariable = 54; // initialization of an integer variable

        //int maxiMumValue = int.MaxValue;
        //int minValue = int.MinValue;
        Console.WriteLine("this is my integer variable: " + integrevariable);
        Console.WriteLine($"Max value of integer {int.MaxValue} Min value of Interger {int.MinValue} ");
        Console.WriteLine("Teju "+ "AV");

        //Calcuation Oprations 

        //Addition
        int a = 10;
        int b = 45;
        int sum;
        sum = a + b;
        Console.WriteLine("Sum is " + sum);

        int sub;
        sub = a - b;
        Console.WriteLine("Substarction is " + sub); // Concatenation
 
        int multipliction;
        multipliction = a * b;
        Console.WriteLine(multipliction);

        int division;
        division = a / b;
        Console.WriteLine(division);

    }
}