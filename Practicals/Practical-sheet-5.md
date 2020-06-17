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
