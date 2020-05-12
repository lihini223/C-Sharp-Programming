# C#-Input

In C#, the simplest method to get input from the user is by using the ```ReadLine()``` method of the Console class. However, ```Read()``` and ```ReadKey()``` are also available for getting input from the user. They are also included in Console class.

## Difference between ReadLine(), Read() and ReadKey() method:

- ```ReadLine()```: The ```ReadLine()``` method reads the next line of input from the standard input stream. It returns the same string.
- ```Read()```: The ```Read()``` method reads the next character from the standard input stream. It returns the ASCII value of the character.
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
		
## 2. 
