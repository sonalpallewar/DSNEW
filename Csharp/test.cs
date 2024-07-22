using System;

namespace GreetingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");

            // Read the user's input
            string name = Console.ReadLine();

            // Greet the user
            Console.WriteLine("Hello, " + name + "!");

            // Wait for the user to press a key before closing
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
