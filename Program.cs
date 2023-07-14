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

            // Print the total number of elements in the ArrayList
            Console.WriteLine("Total number of elements in the ArrayList: " + fruits.Count);

            // Check if the ArrayList contains the element "date" and print the result
            bool containsDate = fruits.Contains("date");
            Console.WriteLine("ArrayList contains 'date': " + containsDate);

            // Insert the element "fig" at the second position in the ArrayList
            fruits.Insert(1, "fig");

            // Remove the element "banana" from the ArrayList
            fruits.Remove("banana");

            // Print all the elements in the ArrayList using a loop
            Console.WriteLine("Elements in the ArrayList:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadLine();
        }
    }
}
