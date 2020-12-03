using System;
 
namespace PT78
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int choice;
            char yn;
            Console.WriteLine("A simple calculator\n----------------------------------------\n");
            Console.Write("Enter the first Integer : ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second Integer : ");
            num2 = Convert.ToDouble(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("\nHere are the options : \n1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n");
                Console.Write("Input your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The Addition of {0} and {1} is: {2:0}", num1, num2, num1 + num2);
                        break;
                    case 2:
                        Console.WriteLine("The Substraction of {0} and {1} is: {2:0}", num1, num2, num1 - num2);
                        break;
                    case 3:
                        Console.WriteLine("The Multiplication of {0} and {1} is: {2:0}", num1, num2, num1 * num2);
                        break;
                    case 4:
                        if (num2 != 0)
                            Console.WriteLine("The Division of {0} and {1} is: {2:0.00}", num1, num2, num1 / num2);
                        else
                            Console.WriteLine("The second integer is zero. Cannot devide by zero!!!");
                        break;
                    default:
                        Console.Write("Continue? (y/n) ");
                        yn = Convert.ToChar(Console.ReadLine());
                        if (yn == 'n')
                            return;
                        Console.Write("Enter the first Integer : ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second Integer : ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
        }
    }
}
