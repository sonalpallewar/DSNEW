using System;

namespace Company
{
    interface IEmployee
    {
        void Work();
    }

    class Employee : IEmployee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }

    class Manager : Employee
    {
        public Manager(string name) : base(name) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }
    }

    class Developer : Employee
    {
        public Developer(string name) : base(name) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is writing code.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = {
                new Manager("Alice"),
                new Developer("Bob"),
                new Developer("Charlie")
            };

            foreach (var employee in employees)
            {
                employee.Work();
            }
        }
    }
}
