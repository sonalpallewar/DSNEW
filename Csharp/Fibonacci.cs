using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Get the number of terms from the user
            Console.WriteLine("Enter the number of terms for the Fibonacci sequence:");
            int terms = Convert.ToInt32(Console.ReadLine());

            // Display the Fibonacci sequence
            Console.WriteLine("Fibonacci sequence:");
            for (int i = 0; i < terms; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }

            // Wait for the user to press a key before closing
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }

