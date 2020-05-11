## Question - 01
Write a Console Application Program to get Student Name and Student Marks. If student mark is in, 75 – 100 Grade A, 60 - 74 Grade B, 50 – 59 Grade C, 40- 49 Grade D and others are Fail. Display the Student name with Student Grade at the end of the program.

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


## Question - 02
Write a Console Application program to get two integer inputs from the user and display the answers for four basic arithmetic operations. (Sum, Subtraction, multiplication and division) When calculating division your answer should contain decimal points.

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
