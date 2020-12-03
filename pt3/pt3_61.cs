using System;
 
namespace PT61
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.Write("Input number of rows : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                k = 'A';
                for(int j = 1; j<=i; j++)
                {
                    Console.Write((char)k++);
                }
                Console.WriteLine();
            }
        }
    }
}
