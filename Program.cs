using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = [ 0, 1, 2, 3, 4, 5, 6, 7, 8 ];

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var evenNumQuery = from num in numbers
                   where (num % 2) == 0
                   select num;

            int evenNumCount = evenNumQuery.Count();
            foreach (int num in evenNumQuery)
                {
                    Console.WriteLine("{0,1} ", num);
                }
            Console.WriteLine($"There are {evenNumCount} even numbers");

    }
}

}