using System;
 
namespace PT72
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, check = -1;
            double sum = 1, w=0;
            Console.Write("Input number of terms : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("1/1 - ");
            for (int i = 2; i < num; i++) 
            {
                Console.Write("1/{0} ",i);
                if (check == -1)
                {
                    sum -= (1.0 / i);
                    Console.Write("- ");
                    check *= -1;
                }
                else
                {
                    sum += (1.0 / i);
                    Console.Write("+ ");
                    check *= -1;
                }
            }
            Console.WriteLine("1/{0}",num);
            if (check == -1)
                sum -= (1.0 / num);
            else
                sum += (1.0 / num);          
            Console.WriteLine(sum);
        }
    }
}

