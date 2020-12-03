using System;
 
namespace PT75
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            for (int i = 1000; i < 2500; i++) 
            {
                num = i*4 % 10 * 1000 + (i * 4 % 100 - i * 4 % 10) * 10 + (i * 4 % 1000 - i * 4 % 100) / 10 + (i * 4 - i * 4 % 1000 )/1000;
                if(num==i)
                    Console.WriteLine(i);
            }
        }
    }
}
