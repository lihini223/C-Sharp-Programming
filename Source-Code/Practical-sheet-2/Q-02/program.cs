using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius,A,C;

            Console.WriteLine("Let's find the area and circumference of a circle !");
            Console.WriteLine("Enter Radius:");
            
            radius = Convert.ToDouble(Console.ReadLine());
            
            FindValues values = new FindValues();

            A = values.FindArea(radius);
            C = values.FindCircumference(radius);
            
            Console.WriteLine("Area = {0}",A);
            Console.WriteLine("Circumference = {0}",C);

            Console.ReadKey();
 
        }
    }
}

