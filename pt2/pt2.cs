using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, num2 = 0;

            if (args.Length != 2)
            {
                Console.WriteLine("두 개의 숫자를 입력하시오.");
                Console.WriteLine("Usage: Ex1 <num1> <num2>"); return;
            }
            try
            {
                num1 = Convert.ToDouble(args[0]); num2 = Double.Parse(args[1]);
            }
            catch (FormatException e)
            {
                Console.WriteLine("숫자로 변환할 수 없습니다.");
                return;
            }

            Console.WriteLine("{0} + {1} = {2}", num1, num2, AddThem(num1, num2));
            Console.WriteLine("{0} - {1} = {2}", num1, num2, SubtractThem(num1, num2));
            Console.WriteLine("{0} * {1} = {2:F2}", num1, num2, MultiplyThem(num1, num2));
            if (num2 == 0)
                Console.WriteLine("0으로 나눌 수 없습니다.");
            else
                Console.WriteLine("{0} / {1} = {2:F2}", num1, num2, DivideThem(num1, num2));

        }

        private static double AddThem(double num1, double num2) { return num1 + num2; }

        private static double SubtractThem(double num1, double num2) { return num1 - num2; }

        private static double MultiplyThem(double num1, double num2) { return num1 * num2; }

        private static double DivideThem(double num1, double num2) { return num1 / num2; }
  
    }
}
