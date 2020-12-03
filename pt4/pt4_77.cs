using System;
 
namespace bmc
{
    class Q77
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string[] str = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            char[] shape = new char[] { '\u2663', '\u2660', '\u2666', '\u2665' };
            for (int i = 0; i < shape.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                    Console.Write("{0}{1} ",str[j],shape[i]);
                Console.WriteLine();
            }
 
        }
    }
}
