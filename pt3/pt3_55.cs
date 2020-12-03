using System;
 
namespace PT55
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, tmp = 0;
            Console.WriteLine("Calculate the sum of the series 1 + 11 + 111 + 1111 + .. n terms :");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("1 ");
            sum++;
            for (int i = 1; i < n; i++)
            {
                tmp = 0;
                for(int j = 0; j<=i;j++)
                {
                    tmp += (int)Math.Pow(10, j);
                }
                Console.Write("+ {0} ", tmp);
                sum += tmp;
            }
            Console.WriteLine("\nThe Sum is : {0}",sum);
        }
    }
}
