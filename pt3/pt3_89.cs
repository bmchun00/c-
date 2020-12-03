using System;
 
namespace PT89
{
    class Program
    {
        static void Main(string[] args)
        {
 
            int num, sum, tmp;
            String tmpStr;
            bool canConvert = false;
            while (true)
            {
                sum = 0;
                Console.Write("> 몇 개의 숫자를 입력하시겠습니까? ");
                num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= num; i++)
                {
                    while (true)
                    {
                        Console.Write("Num {0} : ", i);
                        tmpStr = Console.ReadLine();
                        canConvert = int.TryParse(tmpStr, out tmp);
                        if (canConvert)
                        {
                            sum += tmp;
                            break;
                        }
                        else
                            Console.WriteLine("{0}은(는) 숫자로 변환할 수 없습니다.", tmpStr);
                    }
                }
                Console.WriteLine("[ 합: {0}, 평균: {1:0.000000} ]", sum, (double)sum / num);
                Console.Write("====================== 계속 하실래요? (y/n) ");
                if (Console.ReadLine() == "n") break;
            }
        }
    }
 
}
