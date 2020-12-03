using System;
 
namespace PT97
{
    class Program
    {
        static void Main(string[] args)
        {
            int bn, bntmp, num=0, i=0;
            Console.Write("Enter a binary number : ");
            bn = Convert.ToInt32(Console.ReadLine());
            bntmp = bn;
            while(bntmp!=0)
            {
                num += (bntmp % 10) * (int)Math.Pow(2, i);
                bntmp /= 10;
                i++;
            }
            Console.WriteLine("The Decimal Number of Binary {0} is {1}",bn,num);
        }
    }
 
}
