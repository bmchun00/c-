using System;
 
namespace bmc
{
    class Q79
    {
        static string str;
        static void Main()
        {
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            Console.Write("The reverse of the string is : ");
            printR(str.Length);
 
        }
        static void printR(int num)
        {
            if (num > 0)
            {
                Console.Write(str[--num]);
                printR(num);
            }
        }
    }
}
