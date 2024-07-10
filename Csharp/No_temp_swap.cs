// Program to swap two numbers without 
// using temporary variable 
using System; 

class Swap { 
	public static void Main() 
	{ 
		int x = 10; 
		int y = 5; 

		x = x + y; 
		y = x - y; 
		x = x - y; 
		Console.WriteLine("After swapping: x = "
						+ x + ", y = " + y); 
		 // Test the MathOperations class
        MathOperations mathOps = new MathOperations();
        int sumResult = mathOps.Sum(3, 7);
        int productResult = mathOps.Product(4, 5);

        Console.WriteLine("Sum: " + sumResult);
        Console.WriteLine("Product: " + productResult);
	} 
}
public class MathOperations
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Product(int a, int b)
    {
        return a * b;
    }
}
/*
 ** Sample I/O
 **
 ** INPUT: x = 10 
 	   y = 5
 
 ** OUTPUT: x = 5
 **         y = 10
 ** Sum till nth term.
 **
 ** Time complexity - O(n)
 ** 
 ** Space complexity - O(1)
 **
 */			