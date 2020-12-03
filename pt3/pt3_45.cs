using System;
 
namespace PT45
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            char yn = 'y';
            while (yn == 'y')
            {
                Console.Write("> 몇 개의 숫자를 입력하시겠습니까? ");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    sum += Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("[ 합: {0}, 평균: {1} ]", sum, sum / n);
                Console.Write("======== 계속 하실래요? (y/n) ");
                yn = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
