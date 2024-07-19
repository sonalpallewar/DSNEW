using System;

namespace StudentManagement
{
    public class Student
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        // Method to display student details
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
        }
    }
}
