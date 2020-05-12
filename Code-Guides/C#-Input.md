# C#-Input

In C#, the simplest method to get input from the user is by using the ```ReadLine()``` method of the Console class. However, ```Read()``` and ```ReadKey()``` are also available for getting input from the user. They are also included in Console class.

## Difference between ReadLine(), Read() and ReadKey() method:

- ```ReadLine()```: The ```ReadLine()``` method reads the next line of input from the standard input stream. It returns the same string.
- ```Read()```: The ```Read()``` method reads the next character from the standard input stream. It returns the ASCII value of the character.
- ```ReadKey()```: The ```ReadKey()``` method obtains the next key pressed by user. This method is usually used to hold the screen until user press a key.

## 1. How to Get String Input From User

        using System;
 
        namespace Sample
        {
	        class Test
	        {
		        public static void Main(string[] args)
		        {
			        string testString;
              
			        Console.Write("Enter a string - ");
			        testString = Console.ReadLine();
			        Console.WriteLine("You entered '{0}'", testString);
		        }
	        }
         }

The output will be:

		Enter a string - Hello World
		You entered 'Hello World'
		
## 2. Difference between Read() and ReadKey() method in practical 
```
using System;
 
namespace Sample
{
	class Test
	{
		public static void Main(string[] args)
		{
			int userInput;

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
			Console.WriteLine();

			Console.Write("Input using Read() - ");
			userInput = Console.Read();
			Console.WriteLine("Ascii Value = {0}",userInput);
		}
	}
}
```
