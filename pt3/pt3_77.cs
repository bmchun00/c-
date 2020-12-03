using System;
namespace PT77
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, choice;
            Console.Write("Enter the first Integer : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Integer : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHere are the options : \n1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n");
            Console.Write("Input your choice : ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("The Addition of {0} and {1} is: {2}",num1,num2,num1+num2);
                    break;
                case 2:
                    Console.WriteLine("The Substraction of {0} and {1} is: {2}", num1, num2, num1 - num2);
                    break;
                case 3:
                    Console.WriteLine("The Multiplication of {0} and {1} is: {2}", num1, num2, num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("The Division of {0} and {1} is: {2}", num1, num2, num1 / num2);
                    break;
            }
        }
    }
}
