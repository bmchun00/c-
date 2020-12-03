using System;
 
namespace PT58
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input number of rows : ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1;i<=n;i++)
            {
                for (int j = n - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for(int i =1;i<n-1;i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("||");
        }
    }
}
