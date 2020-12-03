using System;
 
namespace PT63
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
                for (int j = i;j!=4;)
                {
                    if (j % 2 == 1) j = j * 3 + 1;
                    else j = j / 2;
                    cnt++;
                }
                if(cnt>=100) Console.WriteLine("Chain Number: {0} (count: {1})",i ,cnt);
            }
 
        }
    }
}
