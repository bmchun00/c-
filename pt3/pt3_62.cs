using System;
 
namespace PT62
{
    class Program
    {
        static void Main(string[] args)
        {
            int startN,endN, cnt;
            Console.Write("Input starting number of range : ");
            startN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            endN = Convert.ToInt32(Console.ReadLine());
            for (int i = startN; i <= endN; i++)
            {
                cnt = 0;
                Console.Write("[{0}]", i);
                for (int j = i;j!=4;)
                {
                    if (j % 2 == 1) j = j * 3 + 1;
                    else j = j / 2;
                    Console.Write("->{0}",j);
                    cnt++;
                }
                Console.WriteLine(" (Chain: {0})",cnt);
            }
 
        }
    }
}
