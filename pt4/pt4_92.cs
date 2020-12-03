using System;
 
namespace bmc
{
    class Q92
    {
        static void Main()
        {
            string str;
            Random random = new Random();
            int temp = 0;
            int ran = 0;
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("The shuffled string is : ");
            int[] a = new int[str.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }
 
            for (int i = 0; i < a.Length; i++)
            {
                temp = a[i]; 
                ran = random.Next(0, a.Length); 
                a[i] = a[ran]; 
                a[ran] = temp;
            }
            for (int i = 0; i < str.Length; i++)
                Console.Write(str[a[i]]);
        }
    }
}
