using System;
 
namespace PT39
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            char yn ='y';
            Console.Write("무엇을 찍을까요? ");
            str = Console.ReadLine();
            do
            {
                Console.WriteLine(str);
                Console.Write("계속할까요? ");
                yn = Convert.ToChar(Console.ReadLine());
            }
            while (yn == 'y');
        }
    }
}
