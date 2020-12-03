using System;
 
namespace PT60
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m = 1;
            Console.Write("Input number of rows : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("{0} ",m);
                }
                Console.WriteLine();
                m++;
            }
 
        }
    }
}
