using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_marks
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, grade;
            int mark;

            Console.Write("Enter Your Name:");
            name = Console.ReadLine();

            Console.Write("Enter Marks:");
            mark = int.Parse(Console.ReadLine());

            if(!(mark>=0 && mark <= 100))
            {
                Console.WriteLine("Enter a valid mark");   
            }

            if (mark >= 75 && mark <= 100)
            {
                grade = "A";
            }
            else if (mark >= 60 && mark <= 74)
            {
                grade = "B";
            }
            else if (mark >= 50 && mark <= 59)
            {
                grade = "C";
            }
            else if (mark >= 40 && mark <= 49)
            {
                grade = "D";
            }
            else
            {
                grade = "Fail";
            }

            Console.WriteLine("{0} You got : {1}" , name, grade);

            Console.ReadKey();
        }
    }
}
