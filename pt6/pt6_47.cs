using System;
 
namespace Test1
{
    public class A
    {
        public static int num = 10;
        public A(int num)
        { 
            num++;
            PrintIt(num);
        }
        public static int AddNum()
        { return ++num; }
        static A()
        { 
            --num; 
            PrintIt(num); 
        }
        public static void PrintIt(int integer)
        { Console.WriteLine("num = {0}", integer); }
    }
    class Tester 
    { 
        static void Main(string[] args)
        {
            A a = new A(10);
            A.AddNum();
            A.PrintIt(A.num); 
        } 
    }
} 
