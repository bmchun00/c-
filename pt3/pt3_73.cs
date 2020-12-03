using System;
 
namespace PT73
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Input a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                Console.Write(num%10);
                num /= 10;
            }
        }
    }
}
