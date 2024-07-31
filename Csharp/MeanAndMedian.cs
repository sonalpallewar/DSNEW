using System;
using System.Collections.Generic;

namespace Utilities
{
    public class GenericRepository<T>
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void RemoveItem(T item)
        {
            items.Remove(item);
        }

        public IEnumerable<T> GetAllItems()
        {
            return items;
        }
    }
}

namespace MainApp
{
    using Utilities;

    class Program
    {
        static void Main(string[] args)
        {
            GenericRepository<string> stringRepository = new GenericRepository<string>();
            stringRepository.AddItem("Hello");
            stringRepository.AddItem("World");

            foreach (var item in stringRepository.GetAllItems())
            {
                Console.WriteLine(item);
            }

            GenericRepository<int> intRepository = new GenericRepository<int>();
            intRepository.AddItem(1);
            intRepository.AddItem(2);

            foreach (var item in intRepository.GetAllItems())
            {
                Console.WriteLine(item);
            }
        }
    }
}
