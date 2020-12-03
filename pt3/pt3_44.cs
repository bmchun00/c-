using System;
 
namespace PT44
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double sum = 0;
            Console.Write("몇 개의 숫자를 입력하시겠습니까? ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("{0}개 숫자의 평균은 {1}입니다.",n,sum/3);
        }
    }
}
