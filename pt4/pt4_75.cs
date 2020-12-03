using System;
 
namespace bmc
{
    class Q75
    {
        static void Main()
        {
            string str, tocheck;
            char check = 'y';
            while (check == 'y')
            {
                Console.Write("Input a base string : ");
                str = Console.ReadLine();
                Console.Write("Input a string to preserve : ");
                tocheck = Console.ReadLine();
                extract(str, tocheck);
                Console.Write("\nContinue? (y/n) ");
                check = Convert.ToChar(Console.ReadLine());
            }
 
        }
        static void extract(string str, string tocheck)
        {
            int chk;
            for (int i = 0; i < str.Length ; i++)
            {
                chk = 1;
                if (i + tocheck.Length <= str.Length)
                {
                    for (int j = 0; j < tocheck.Length; j++)
                    {
                        if (tocheck[j] == str[i + j]) chk *= 1;
                        else chk *= 0;
                    }
                }
                else chk = 0;
                if(chk==0)
                {
                    Console.Write("*");
                }
                else
                {
                    for (int k = 0; k<tocheck.Length;k++)
                        Console.Write(str[i+k]);
                    i = i + tocheck.Length - 1;
                }
            }
        }
    }
}
