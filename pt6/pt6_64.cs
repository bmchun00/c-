using System;
 
namespace Test4
{
    class MyClassA
    {
        int num;
        public MyClassA(int num) { this.num = num; }
        public int Num { set { this.num = value; } get { return this.num; } }
    }
    class MyClassB 
    {
        MyClassA ma; 
        public MyClassA Ma { set { this.ma = value; } get { return ma; } } }
    class Tester 
    { 
        static void Main(string[] args) 
        { 
            MyClassA ma = new MyClassA(5); 
            MyClassB mb = new MyClassB(); 
            mb.Ma = new MyClassA(5); 
            mb.Ma.Num++; 
            Console.WriteLine("{0}", ma.Num); 
            Console.WriteLine("{0}", mb.Ma.Num); 
        } 
    }
}
