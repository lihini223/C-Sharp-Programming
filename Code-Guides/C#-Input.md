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
The output will be:
```
Press any key to continue...
x
Input using Read() - Learning C#
Ascii Value = 76
```
From this example, it must be clear how ```ReadKey()``` and ```Read()``` method works. While using ```ReadKey()```, as soon as the key is pressed, it is displayed on the screen.

When ```Read()``` is used, it takes a whole line but only returns the ASCII value of first character. Hence, 76 (ASCII value of L) is printed.

## Reading numeric values (integer and floating point types)

Reading numeric values can be slightly tricky in C#. We’ll still use the same ```ReadLine()``` method we used for getting string values. But since the ```ReadLine()``` method receives the input as string, it needs to be converted into integer or floating point type.

One simple approach for converting our input is using the methods of Convert class.
