using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] id = new int[10];

            int[] list1 = { 1234, 2345, 3456, 4567, 5678, 6789, 7891, 8912, 9123, 2345 };

            string[] name = new string[10];

            string[] list2 = { "bob", "bill", "john", "sam", "ben", "dan", "fred", "paul", "simon", "brent", "adam" };

            Console.WriteLine(list1.Length);
            Console.WriteLine(id.Length);

            
            Array.Copy(list1, id, 10);

           for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(id[i]);
            }

            
            Console.WriteLine(name.GetType());
            Console.WriteLine(id.GetType());

            
            Console.WriteLine(list2.GetValue(5));

            Array.IndexOf(list1, 4);

            for (int i = 0; i <= 9; i++) 
            {
                Console.WriteLine(list2[i]);
            }

            Console.WriteLine();


            
        }
    }
}
