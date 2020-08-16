# Practical-Sheet-04 - Encapsulation
### Q-01
Create a class called “Employee” which has 3 private variables (empID, empName, empDesignation)
and create getters and setters for each field. Please note that this has no main method since this is
just an added class to the console application. Inside the main class take user inputs for employee id ,
employee name. employee designation and pass values to added class and set values.
From getters return relevant values and print the following message from main method.<br/>
“Hello – ```Employee name``` – Your Employee ID is – ```EMPID```—and You are a – ```EmpDesignation``` --.
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Designation:");
            string designation = Console.ReadLine();

            encap en = new encap();
            en.setempid(id);
            en.setempname(name);
            en.setempdesignation(designation);

            Console.WriteLine("Hello " + en.getempname() + " ,Your employee ID is " + en.getempid() + " , And you are a " + en.getempdesignation());

            Console.ReadLine();
        }
    }
}
```

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class encap
    {
        private int EmpID;
        private string EmpName;
        private string EmpDesignation;

        public void setempid(int id)
        {
            EmpID = id;
        }
        public int getempid()
        {
            return EmpID;
        }

       
    }
}

```
### Q-02
Create a Console application program which contain an encapsulation class for four basic arithmetic
operations.
Inside the encapsulation class you should have two private variables and getters and setters for basic
arithmetic operations. Then return answers for summation, subtraction, multiplication and division
and print them on main method.

### Q-03
Create a Console application with two classes (Main class + another class).<br/>
Inside the main class take a user input which is the size of the array.<br/>
Pass the user inserted size as a parameter to the added class method.<br/>
Inside the method create an integer array based on passed value from main method.<br/>
Then take user inputs for the created array inside the separate class.<br/>
Every user input value should be followed by value 0 inside the array.<br/>
Eg Assume array size is 9 and it should as follows<br/>
```U.Input 0```  ```U.Input 0``` ```U.Input 0``` ```U.Input 0``` ```U.Input```<br/>
Now print all the values inside the array.
