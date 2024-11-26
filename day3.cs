public class Program
{
    public static void Main(string[] args)
    {
        //float a = 1f / 3; //0.33333334
        //double c = 1d / 3; //0.3333333333333333
        //decimal b = 1m / 3;//0.3333333333333333333333333333


        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);

        float pi1 = 22f/ 7f ;

        Console.WriteLine("Pi "+pi1);
        
        double pi2 = 22d/ 7d ;

     Console.WriteLine("Pi "+pi2);

        decimal pi3 = 22m/ 7m ;
        Console.WriteLine("pi3 " + pi2);

        int radius = 5;

        float area1 = pi1 * radius * radius;

        Console.WriteLine("Area of Circle : " + area1);

        double area2 = pi2 * radius * radius;

        Console.WriteLine("Area of Circle : " + area2);

        decimal area3 = pi3 * radius * radius;

        Console.WriteLine("Area of Circle : " + area3);

        char phonePay = 'P';
        char gPay = 'G';
        char aPay = 'A';

        Console.WriteLine(" "+phonePay);
        Console.WriteLine(" "+gPay);
        Console.WriteLine(" "+aPay);

        bool isTrue = true;

        Console.WriteLine(isTrue);
        int number = 15;

        

        bool isEven= (number % 2 == 0);

        Console.WriteLine(isEven);
    }
}
