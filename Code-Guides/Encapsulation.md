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
