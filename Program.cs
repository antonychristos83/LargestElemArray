using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElemArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number  :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter element " + (i + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nARRAY ELEMENTS ARE ");
            Console.WriteLine("-------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.Write("\n");
            Array.Sort(arr);
            Console.WriteLine("1st largest element in the array is " + arr[(n - 1)] + " and the 2nd largest element in the array is " + arr[(n - 2)]);

        }
    }
}




