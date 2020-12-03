using System;
 
namespace PT59
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 1;
            Console.Write("Input number of rows : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for(int j = 1; j<=i; j++)
                {
                    Console.Write("{0} ",k++);
                }
                Console.WriteLine();
            }
        }
    }
}
