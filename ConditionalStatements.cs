using data_type_and_methods;

public class Program
{
    public static void Main(string[] args)
    {
       const int votingAge = 18;
 // COnditinal statements

 // CHecke the person is eligible for voting or not
 Console.WriteLine("Eneter your age");

 int age = int.Parse(Console.ReadLine()); //10




 //if - always check the condition(Boolean) and execute the block of code
 bool condition = age >= votingAge;

 /*  if (condition)
   {
       Console.WriteLine("Yes..! Your adult");
   }
   else if (age == 17)
   {
       Console.WriteLine("You are 17, you can vote next year");
   }
   else if(age == 16)
   {
       Console.WriteLine("You are 16, you can vote after 2 years");
   }
   else if (age == 15)
   {
       Console.WriteLine("You are 16, you can vote after 2 years");
   }
   else
   {
       Console.WriteLine("No..! Your not adult");
   }*/



 //explain switch case
 // switch case - check the value and execute the block of code
 /*  switch (age)
   {
       case >= votingAge:
           Console.WriteLine("Yes..! Your adult");
           break;
       case 17:
           Console.WriteLine("You are 17, you can vote next year");
           break;
       case 16:
           Console.WriteLine("You are 16, you can vote after 2 years");
           break;
       case 15:
           Console.WriteLine("You are 15, you can vote after 2 years");
           break;
       default:
           Console.WriteLine("No..! Your not adult");
           break;
   }*/



 /* I want to go shivaji miltry hotel 
  * i have 4 Routes to visit
    1.MG Road
    2.YPR
    3.Silk Board
    4.Hebbal
    5.Sit back
   if i take MG Road i will reach in 30 mins
 */




 /*
         Console.WriteLine("Choose your route to Shivaji Military Hotel:");
         Console.WriteLine("1. MG Road");
         Console.WriteLine("2. YPR");
         Console.WriteLine("3. Silk Board");
         Console.WriteLine("4. Hebbal");
         Console.WriteLine("5. Sit back");

         int route = int.Parse(Console.ReadLine());

         switch (route)
         {
             case 1:
                 Console.WriteLine("You chose MG Road, you will reach in 30 mins");
                 break;
             case 2:
                 Console.WriteLine("You chose YPR");
                 break;
             case 3:
                 Console.WriteLine("You chose Silk Board");
                 break;
             case 4:
                 Console.WriteLine("You chose Hebbal");
                 break;
             case 5:
                 Console.WriteLine("You chose to sit back");
                 break;
             default:
                 Console.WriteLine("Invalid choice");
                 break;
         }

 */    



    }

}
