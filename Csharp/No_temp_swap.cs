using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Declare two variables
            int number1, number2, temp;

            // Get input from the user
            Console.WriteLine("Enter the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            // Display the numbers before swapping
            Console.WriteLine("\nBefore swapping:");
            Console.WriteLine("Number 1: " + number1);
            Console.WriteLine("Number 2: " + number2);

            // Swap the numbers
            temp = number1;
            number1 = number2;
            number2 = temp;

            // Display the numbers after swapping
            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine("Number 1: " + number1);
            Console.WriteLine("Number 2: " + number2);

            // Wait for the user to press a key before closing
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

