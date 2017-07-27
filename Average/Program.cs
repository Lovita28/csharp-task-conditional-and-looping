using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter total Array :");
            int n = int.Parse(Console.ReadLine());
            int[] av = new int[n];

            for (int x = 0; x < n; x++) {
                Console.WriteLine("Input-{0} : ", x + 1);
                av[x] = int.Parse(Console.ReadLine());
            }

            int total = 0;

            for (int a = 0; a < n; a++) {
                total = total + av[a];
            }
            double average = total / n;
            Console.WriteLine("\nAverage is : {0}", average);

            Console.ReadKey();
        }
    }
}
