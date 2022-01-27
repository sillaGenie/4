using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
       
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int S = 0;
            for (int j = 1; j <= n; j++)
            {
                S += 2 * j - 1;
                Console.WriteLine("Квадрат числа {0} равен {1}", j, S);
            }
            Console.ReadKey();
        }
    }
}