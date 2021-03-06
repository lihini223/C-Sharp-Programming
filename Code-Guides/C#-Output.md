# C# Output

In order to output something in C#, we can use<br/>
- ```Console.WriteLine()``` <br/>
- ```Console.Write()```<br/>

## Difference between WriteLine() and Write() method
The main difference between WriteLine() and Write() is that the Write() method only prints the data provided to it, while the WriteLine() method prints the data and moves to the start of next line as well.

**1. Printing a string using ```Console.WriteLine()```**
        
        using System;
 
        namespace Sample
        {
	          class Test
	          {
		            public static void Main(string[] args)
		            {
			              Console.WriteLine("Hello World!");
                             Console.WriteLine("Welcome to my C# journey ..."); 
		            }
	           }
         }
The output will be:

	Hello World!
	Welcome to my C# journey ...
	
**2. Printing a string using ```Console.Write()```**

	   using system;
	   namespace sample
	   {
	   	class test
		{
			public static void Main(string[] args)
			{
				Console.Write("Prints on ");
				Console.Write("Same line");
			}
		 }
	   }

The output will be:

	Prints on Same line
	
**3. Printing Variables and Literals**
		
		using System;
 
		namespace Sample
		{
			class Test
			{
				public static void Main(string[] args)
				{
					int value = 10;

					// Variable
					Console.WriteLine(value);
					// Literal
					Console.WriteLine(50.05);
				}
			}
		}

The output will be:

	10
	50.05
	
**4. Combining (Concatenating) two strings using ```+``` operator and printing them**

		using System;
 
		namespace Sample
		{
			class Test
			{
				public static void Main(string[] args)
				{
					int val = 55;
					Console.WriteLine("Hello " + "World");
					Console.WriteLine("Value = " + val);
				}
			 }
		 }

The output will be:

		Hello World
		Value = 55

**5. Printing Concatenated string using String formatting**

		using System;
 
		namespace Sample
		{
			class Test
			{
				public static void Main(string[] args)
				{
					int firstNumber = 5, secondNumber = 10, result;
					result = firstNumber + secondNumber;
					Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
				}
			}
		}

Here you can see something like ```{0}``` , ```{1}``` and ```{2}``` in the ```Console.WriteLine()``` function. These elements are called as formatted string. This approach of printing output is more readable and less error prone than using + operator. 
In the ```Console.WriteLine()``` function, after the quoted text we have indicated the variables which should be printed in the console. Imagine you have mistakenly indicated the variables in the in a wrong order. In this method you can easily fix the issue with giving the right index of variable inside ```{ }```. Here the ```firstNumber```,```secondNumber```,```result``` are considered as an array. Because of that ```{0}``` represents firstNumber , ```{1}``` represents ```secondNumber``` and ```{2}``` represents ```result``` respectively.
