using System;
 
namespace bmc
{
    class Q80
    {
        static void Main()
        {
            char[] arr = new char[128];
            string str;
            int max=0;
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
                arr[(int)str[i]]++;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[max] < arr[i]) max = i;
            }
            Console.WriteLine("The most occurring character : {0}",(char)max);
            Console.WriteLine("The number of times of appearance : {0}",(int)arr[max]);
        }
    }
}
