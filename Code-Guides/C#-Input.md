# C#-Input

In C#, the simplest method to get input from the user is by using the ```ReadLine()``` method of the Console class. However, ```Read()``` and ```ReadKey()``` are also available for getting input from the user. They are also included in Console class.

## How to Get String Input From User

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
