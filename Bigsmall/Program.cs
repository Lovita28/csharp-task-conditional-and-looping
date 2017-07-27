using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigsmall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input 3 random numbers ;");
            int[] bis = new int[3];
            for (int x = 0; x < 3; x++) {
                Console.Write("{0}. input :  ", x + 1);
                bis[x] = int.Parse(Console.ReadLine());
                
            }
            
             
            for (int a = 0; a < 3; a++) {
                for (int b = 0; b < 3 - 1; b++) {
                    if (bis[b + 1] > bis[b]) {
                         int temp = bis[b];
                        bis[b] = bis[b + 1];
                        bis[b + 1] = temp;
                    }
                }
            }
            Console.WriteLine("The Biggest number : {0}", bis[0]);
            Console.WriteLine("The Smallest number : {0}", bis[2]);
            if (bis[0] > 0)
            {
                Console.WriteLine("the Biggest number is Positive");
            }
            else {
                Console.WriteLine("The Biggest number is Negative");
            }
            if (bis[2] < 0)
            {
                Console.WriteLine("The Smallest number is Negative");
            }
            else {
                Console.WriteLine("the Smallest number is Positive");
            }

           
            Console.ReadKey();
        }
    }
}
