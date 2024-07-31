using System;
using ProjectA = Company.ProjectA;
using ProjectB = Company.ProjectB;

namespace Company
{
    namespace ProjectA
    {
        class ProjectClass
        {
            public void DisplayMessage()
            {
                Console.WriteLine("Hello from Project A");
            }
        }
    }

    namespace ProjectB
    {
        class ProjectClass
        {
            public void DisplayMessage()
            {
                Console.WriteLine("Hello from Project B");
            }
        }
    }
}

namespace MainNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectA.ProjectClass projectA = new ProjectA.ProjectClass();
            ProjectB.ProjectClass projectB = new ProjectB.ProjectClass();

            projectA.DisplayMessage();
