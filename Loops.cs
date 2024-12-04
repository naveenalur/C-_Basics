using data_type_and_methods;

public class Program
{
    public static void Main(string[] args)
    {
        //for (initializer; condition; iterator)
        //{
        //    //code
        // }

        //for(int bhima=5;bhima<10;bhima++)
        //{

        //    Console.WriteLine(bhima+ "--> Naveen");
        //}

        // Print 1 to 10 numbers

        //for(int i=1;i<=100;i++)
        //{
        //    Console.WriteLine(i*i);
        //}

        //Need to print cube of 1 to n numbers

        Console.WriteLine("Enter the ending number : ");
        int n = int.Parse(Console.ReadLine());

        //for(int i=1;i<=n;i++)
        //{
        //    Console.WriteLine(i+" -- "+i*i*i);
        //}

        for (int i = 0; i <= 10; i++)
        {
            if(i%2==0)
            {
                Console.WriteLine(i + " is Even Number");
            }
        }

        



    }

}
