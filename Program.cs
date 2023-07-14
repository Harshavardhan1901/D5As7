using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList fruits = new ArrayList();
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("cherry");
            fruits.Add("date");
            fruits.Add("elderberry");


            Console.WriteLine("Total number of elements: " + fruits.Count);
            Console.WriteLine("Total fruits in the list: ");
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }


            Console.Write("Enter an element to search: ");
            string searchElement = Console.ReadLine();
            bool containsSearchElement = fruits.Contains(searchElement);
            Console.WriteLine($"Contains '{searchElement}': {containsSearchElement}");

            Console.Write("Enter an element to insert at the second position: ");
            string insertElement = Console.ReadLine();
            fruits.Insert(1, insertElement);

            Console.Write("Enter an element to remove: ");
            string removeElement = Console.ReadLine();
            fruits.Remove(removeElement);

            Console.WriteLine("Elements in the ArrayList:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
