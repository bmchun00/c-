using System;
 
namespace PT54
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double sum = 0;
            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("1/{0} ",1);
            sum++;
            for (int i = 2; i <= n; i++)
            {
                Console.Write("+ 1/{0} ", i);
                sum += (1.0 / i);
            }
            Console.WriteLine("\nSum of Series upto {0} terms : {1}",n,sum);
        }
    }
}
