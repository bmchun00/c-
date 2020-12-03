using System;
 
namespace PT98
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nTmp, i = 0, bn=0;
            Console.Write("Enter a number to convert : ");
            n = Convert.ToInt32(Console.ReadLine());
            nTmp = n;
            while (nTmp != 0)
            {
                bn += (nTmp%2)* (int)Math.Pow(10, i);
                nTmp /= 2;
                i++;
            }
            Console.WriteLine("The Binary Number of {0} is {1}", n, bn);
        }
    }
 
}
