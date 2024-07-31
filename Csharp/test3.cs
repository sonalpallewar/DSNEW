using System;

namespace OuterNamespace
{
    namespace InnerNamespace
    {
        class ExampleClass
        {
            public void DisplayMessage()
            {
                Console.WriteLine("Hello from the inner namespace!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InnerNamespace.ExampleClass example = new InnerNamespace.ExampleClass();
            example.DisplayMessage();
        }
    }
}
