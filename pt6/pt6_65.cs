using System;
 
namespace Test6
{
    class A
    {
        public static A a; 
        public static int num1 = 100; 
        public int num2 = 200;
        public static B b1; 
        public B b2; 
        public static B b3 = new B();
    }
    class B { public int num3 = 300; }
    class Tester
    {
        static void Main(string[] args)
        {
            A.a = new A();
            Console.WriteLine("A num1 = {0}", A.num1);
            Console.WriteLine("A num2 = {0}", A.a.num2); 
            Console.WriteLine("A num2 = {0}", A.b3.num3);
            A.b1 = new B();
            Console.WriteLine("B num3 = {0}", A.b1.num3); 
            A.a.b2 = A.b1; 
            A.b1 = A.b3; 
            A.b1.num3 += 100; 
            Console.WriteLine("A num2 = {0}", A.b3.num3);
            A.a.b2 = A.b3; 
            A.a.b2.num3 += A.b3.num3; 
            Console.WriteLine("B num3 = {0}", A.b3.num3);
        }
    }
}
