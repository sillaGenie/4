namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)

        {
            int A = Convert.ToInt32(Console.ReadLine());
            
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int SumC = 0;
            int n = 0;
            if (B > A)
            {
                while (B >= (SumC+C))
                {
                    SumC += C;
                    n++;
                }
                
                while ((C+C) <= A)
                {
                    SumC += SumC;
                    C += C;
                    n += n;
                }
            }
            if (A >= B)
            {
                while (A >= (SumC + C))
                {
                    SumC += C;
                    n++;
                }

                while ((C + C) <= B)
                {
                    SumC += SumC;
                    C += C;
                    n += n;
                }
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}