using System;
 
namespace PT79
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number of terms of sum of fibonacci series that exceeds input number:");
            Console.WriteLine("-------------------------------------------------------------------------\n");
            int num, front = 1, mid = 1, back = 1, sum=0, i=2;
            Console.Write("Input number of terms to be display : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} + {1} ", front, mid);
            sum = front + mid;
            while(sum<=num)
            {
                front = mid;
                mid = back;
                back = front + mid;
                sum += back;
                Console.Write("+ {0} ", back);
                i++;
            }
            Console.WriteLine("\n피보나찌 수열 {0}항까지의 합이 {1}을 넘음",i, num);
        }
    }
 
}
