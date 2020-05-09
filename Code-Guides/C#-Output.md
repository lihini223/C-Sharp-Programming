# C# Output

In order to output something in C#, we can use<br/>
- ```Console.WriteLine()``` <br/>
- ```Console.Write()```<br/>

## Difference between WriteLine() and Write() method
The main difference between WriteLine() and Write() is that the Write() method only prints the data provided to it, while the WriteLine() method prints the data and moves to the start of next line as well.

**Let's see how they actually work in practical**
1. Printing a string using ```Console.WriteLine()```
        
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
The output will be like this:

	Hello World!
	Welcome to my C# journey ...
	
