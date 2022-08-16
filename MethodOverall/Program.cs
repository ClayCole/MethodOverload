using System;
using System.Threading;

namespace MethodOverall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Okay user lets count some money, please give a dollar amount: ");
            var a = double.Parse(Console.ReadLine());
            //var answer = (a % 1 == 0) ? "int" : "double";

            Console.WriteLine("Thank you, Now Please give me another dollar amount: ");
            var b = double.Parse(Console.ReadLine());
            //var banswer = (b % 1 == 0) ? "int" : "double";

            Console.WriteLine("Thank you, Now doing some simple math");
            Console.WriteLine();
            Console.WriteLine("Let's add the dollar amounts you gave me:");
            Thread.Sleep(1000);

            Console.WriteLine(Add(a, b, true));


            

        }
        
        public static void Add (int a, int b)
        {
             var sum = a + b;

            Console.WriteLine(sum); 
        }

        public static void Add (decimal a, decimal b)
        {
            var sum = a + b;

            Console.WriteLine(sum);

        }

        public static string Add(double a, double b, bool isTrue)
        {
            var sum = 0;
            var total = "";

            if (isTrue)
            {
                sum = (int)(a + b);

                if (sum == 1)
                {
                    total = $"{sum} dollar.";

                }
                else
                {
                    total = $"{a + b} dollars";
                }

            }
            return total;
            
        }
        

        
    }
}

