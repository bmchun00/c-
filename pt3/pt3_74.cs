using System;
 
namespace PT74
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Input upto the table number starting from 1 : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication table from 1 to {0}", num);
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0,2}x{1,2}={2,2}", 1, i, 1 * i);
                for (int j = 2; j <= num; j++)
                {
                    Console.Write(", {0,2}x{1,2}={2,2}", j, i, j * i);
                }
                Console.WriteLine();
            }
        }
    }
}
