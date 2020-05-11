using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, sum,substraction,multiplication;
            double division;

            //getting input for n1
            Console.WriteLine("Enter number 1 : ");
            n1 = int.Parse(Console.ReadLine());

            //getting input for n1
            Console.WriteLine("Enter number 2 : ");
            n2 = int.Parse(Console.ReadLine());

            //Arithmetic Operations
            sum = n1 + n2 ;
            substraction = n1 - n2 ;
            multiplication = n1 * n2 ;
            division = Convert.ToDouble(n1) / Convert.ToDouble(n2);

            Console.WriteLine("{0} + {1} = {2} ", n1,n2,sum);
            Console.WriteLine("{0} - {1} = {2} ", n1, n2, substraction);
            Console.WriteLine("{0} * {1} = {2} ", n1, n2, multiplication);
            Console.WriteLine("{0} / {1} = {2} ", n1, n2, division);

            Console.ReadKey();
        }
    }
}
