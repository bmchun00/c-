using System;
 
namespace PT46
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input upto the table number starting from 1 : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMultiplication table from 1 to {0}",n);
            for(int i = 1;i<=n;i++)
            {
                for(int j = 1;j<=9;j++)
                {
                    Console.Write("{0,2}x{1,2}={2,2}",i,j,i*j);
                }
                Console.WriteLine();
            }
        }
    }
}
