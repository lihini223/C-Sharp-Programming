# Encapsulation 

- Encapsulation is the technique of making the fields in a class private and providing access to the fields via public methods.
- If a field is declared private, it cannot be accessed by anyone outside the class, thereby hiding the fields within the class.
- For this reason, Encapsulation is also referred to as ```Data Hiding```.
- Encapsulation can be described as a protective barrier that prevents the code and data being randomly accessed by other code defined outside the class.
- The main benefits of encapsulation is the ability to modify our implemented code without breaking the code of others who use our code.
- With this features Encapsulation gives ```Maintainability```, ```Flexibility``` and ```Extensibility``` to our code.

# Getters and Setters

- The get set accessors or modifiers mostly used for storing and retrieving value from the private field.
- In simple word, the ```get method used for retrieving value``` from private field where ```set method used for storing value``` in private variables.

## Getters and Setters sample code
```
namespace ConsoleApp
{
    class EncapClass
    {
        private int age;
        
        public void setAge(int ageFromUser)
        {
            age = ageFromUser;
        }
        
        public int getAge()
        {
            return age;
        }
        
     }
}
```

```
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EncapClass ec = new EncapClass();
            ec.setAge(25);
            Console.WriteLine("Your Age is" + ec.getAge());
            Console.ReadLine();
        }
    }
}
```

### Task

Write a complete C# code to declare two private integer variables to accept user inputs and display the sum of those two values
Hint – Take a separate class which contain get and set methods.

### Exercise 01
- Create a console application with a encapsulated class.
- Inside the class create a private variable to store the user's age.
- Create getters and setters set user's age and check whether the user is eligible for voting or not.
- From main class program should take user's age as a input.
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageIn;
            Console.WriteLine("Enter your age : ");
            ageIn=Convert.ToInt32(Console.ReadLine());

            EncapClass ec = new EncapClass();
            ec.setAge(ageIn);

            if (ec.getAge() >= 18)
            {
                Console.WriteLine("You are Eligible for voting !");
            }
            else
            {
                Console.WriteLine("Sorry, You are not Eligible for voting");
            }

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

namespace Inheritance
{
    class EncapClass
    {
        private int age;

        public void setAge(int ageIn)
        {
            age = ageIn;
        }


    }
}

```

### Exercise 02
Is it possible to access protected variables from other classes which are not derived from the class which has the variable? Explain Your answer.
