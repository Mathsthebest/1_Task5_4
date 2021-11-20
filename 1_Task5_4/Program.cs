using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            const int a = -50;
            const int b = 50;
            int k = 0;
            int s = 0;
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(a, b);
                Console.Write("{0} ", array[i]);
            }

            for (int i = 0; i < n ; i+=2)
            {
                s = array[i] % 2;
                    if (s == 1) 
                    {
                    k++;
                    }
            }            
            Console.WriteLine();
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
