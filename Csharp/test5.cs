using System;

namespace SimpleConsoleApp
{
    // Define the Person class
    public class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Method to get full name
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        // Method to print person's details
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {GetFullName()}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Person object
            Person person = new Person("John", "Doe", 30);

            // Print the person's details
            person.PrintDetails();

            // Wait for user input to close the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
