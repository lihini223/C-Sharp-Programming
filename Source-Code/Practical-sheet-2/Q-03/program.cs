using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, ans=0;
            int index;
            
            Console.WriteLine("Welcome To My Calculator !!!");
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Substraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division");

            
            Console.WriteLine("Enter Your Choice:");
            index = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter first number:");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter first number:");
            n2 = Convert.ToDouble(Console.ReadLine());

            CalculateValues values = new CalculateValues();

            switch (index)
            {
                case 1:
                    ans = values.Addition(n1,n2);
                    break;
                case 2:
                    ans = values.Substraction(n1,n2);
                    break;
                case 3:
                    ans = values.Multiplication(n1,n2);
                    break;
                case 4:
                    ans = values.Division(n1,n2);
                    break;
                default:
                    Console.WriteLine("Enter a valid operation number !");
            }

            Console.WriteLine("Your Answer is : {0}", ans);

            Console.ReadKey();

        }
    }
}
