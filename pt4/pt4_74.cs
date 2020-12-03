using System;
 
namespace bmc
{
    class Q74
    {
        static void Main()
        {
            string str, tocheck;
            char check = 'y';
            while (check == 'y')
            {
                Console.Write("Input a base string : ");
                str = Console.ReadLine();
                Console.Write("Input a string to check : ");
                tocheck = Console.ReadLine();
                extract(str, tocheck);
                Console.Write("\nContinue? (y/n) ");
                check = Convert.ToChar(Console.ReadLine());
            }
 
        }
        static void extract(string str, string tocheck)
        {
            int chk;
            for (int i = 0; i < str.Length - tocheck.Length + 1; i++)
            {
                chk = 1;
                for (int j = 0; j < tocheck.Length; j++)
                {
                    if (tocheck[j] == str[i + j]) chk *= 1;
                    else chk *= 0;
                }
                if(chk==1)
                {
                    if ((i - 1) >= 0) Console.Write(str[i - 1]);
                    if ((i + tocheck.Length) < str.Length) Console.Write(str[i + tocheck.Length]);
                }
            }
        }
    }
}
