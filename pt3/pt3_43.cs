using System;
 
namespace PT43
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, num = 1, k = 0;
            Console.Write("몇 항까지의 홀수의 합을 구할까요? ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                k++;
                Console.Write("{0,5}",num);
                sum += num;
                num += 2;
                if(k%10==0)
                    Console.WriteLine();
            }
            Console.WriteLine("\n{0} ~ {1}항까지의 홀수의 합은 : {2}",1,n,sum);
        }
    }
}
