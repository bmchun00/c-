using System;
 
namespace PT53
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddCnt = 0, evenCnt = 0;
            char yn = 'y';
            Console.WriteLine("Find even & odd numbers from user input:");
            Console.WriteLine("-----------------------------------------");
            while (yn == 'y')
            {
                Console.Write("Enter a number : ");
                if (Convert.ToInt32(Console.ReadLine()) % 2 == 1)
                    oddCnt++;
                else
                    evenCnt++;
                Console.Write("=== Want to continue? (y/n) ");
                yn = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Total count of even numbers: {0}",evenCnt);
            Console.WriteLine("Total count of odd numbers: {0}", oddCnt);
        }
    }
}
