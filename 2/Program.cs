using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)

        {
            int Sp = 0;
            int So = 0;
            int n;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                    Sp++;
                if (n < 0)
                    So++;
            } while (n != 0);


            Console.WriteLine(Sp);
            Console.WriteLine(So);
            
            Console.ReadKey();
        }
    }
}