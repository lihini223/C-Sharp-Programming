# Welcome to my Practical sheet 05

## Q-01
- Create a Console application with two added classes called “Animal” and “Dog”.
- ‘Dog’ is the derived class (Child) of ‘Animal Class’ (Base Class).
- Inside the ‘Animal Class’ Create a method which for ‘Dog’ Class.
- Inside the method print “I am an Animal”.
- Inside the “Dog Class” Create a method and display “I have four legs”.
- Inside the main method create relevant class object and Display as follows.
-```“I am an animal I have four legs”```.
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.methodAnimal();
            d1.methodDog();

            Console.ReadKey();
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

namespace Quiz01
{
    class Animal
    {
        public void methodAnimal()
        {
            Console.WriteLine("I am an Animal");
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

namespace Quiz01
{
    class Dog : Animal
    {
        public void methodDog()
        {
            Console.WriteLine("I have four Legs");
        }
    }
}
```

## Q-02
- Create a Console application has six classes (including program.cs [main class]).
- Name your classes as GetNumbers.cs, Summation.cs, Substraction.cs, Multiplication.cs & Division.cs
- GetNumbers.cs is the base class of above-mentioned classes. Except program.cs.
- Inside GetNumbers.cs class take user input (Two numbers ) and make them available for
Summation.cs, Substraction.cs, Multiplication.cs & Division.cs classes. (Use inheritance).
- Inside above classes do the respective arithmetic operations and return answers.
- Display answers inside program.cs class.

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz02
{
    class Program
    {
        static void Main(string[] args)
        {
            Summation sum = new Summation();
            sum.GetUserInput();
            Console.WriteLine("The summation of the two numbers: " + sum.getSum());

            Substraction sub = new Substraction();
            sub.GetUserInput();
            Console.WriteLine("The summation of the two numbers: " + sub.getDiff());
           
            Multiplication multi = new Multiplication();
            multi.GetUserInput();
            Console.WriteLine("The summation of the two numbers: " + multi.getMul());
            
            Division div = new Division();
            div.GetUserInput();
            Console.WriteLine("The summation of the two numbers: " + div.getDiv());

            Console.ReadKey();
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

namespace Quiz02
{
    class GetNumbers
    {
        protected int num1, num2;
        public void GetUserInput()
        {
            Console.WriteLine("Enter The First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());
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

namespace Quiz02
{
    class Multiplication : GetNumbers
    {
    
        public int getMul()
        {
            int mul = (num1 * num2);
            return mul;
        }
    }
}
```

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quiz02
{
    class Substraction : GetNumbers
    {
 
        public int getDiff()
        {
            int difference = (num1- num2);
            return difference;
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

namespace Quiz02
{
    class Summation : GetNumbers
    {

        public int getSum()
        {
            int sum = (num1 + num2);
            return sum;
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

namespace Quiz02
{
    class Division : GetNumbers
    {
  
        public double getDiv()
        {
            double div = (double)num1 / (double)num2;
            return div;
        }

    }
}
```

## Q-03
Change the above code by getting user inputs from main class (Program.cs) and set values inside
GetNumbers.cs class.

## Q-04
Declare two single dimensional array with the size given by the user and find , display
the followings;
- Scalar Sum (Adding values of each element of an array)
- Vector Sum (Adding values of each relative elements of an array and store them
in third array)
- Vector Product (Multiply values of each relative elements of an array and store
them in third array)
- Scalar Product (Multiply values of each relative elements of an array and store
them in third array. After placing the values in third array add all the values)
