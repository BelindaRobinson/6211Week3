using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Teacher
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] id = new int[10];

            int[] list1 = { 1234, 2345, 3456, 4567, 5678, 6789, 7891, 8912, 9123, 2345 };

            string[] name = new string[10];

            string[] list2 = { "bob", "bill", "john", "sam", "ben", "dan", "fred", "paul", "simon", "brent", "adam" };

            Console.WriteLine(Array.IndexOf(list1, 2));

            foreach(int element in list1)
            {
                Console.WriteLine(element);
            }
        }
    }
}
