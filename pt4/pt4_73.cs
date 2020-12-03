using System;
 
namespace bmc
{
    class Q73
    {
        static void Main()
        {
            string str;
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            extract(str);
        }
        static void extract(string str)
        {
            int tmp = 0, cnt = 0;
            for (int i = 1; i < str.Length; i++)
            {
                cnt++;
                if (str[i] == ' ')
                {
                    Console.WriteLine(str.Substring(tmp,cnt));
                    cnt = 0;
                    tmp = i+1;
                }
            }
            Console.WriteLine(str.Substring(tmp, str.Length-tmp));
        }
    }
}
