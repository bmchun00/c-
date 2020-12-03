using System;
 
namespace Heap8
{
    class MyClass
    {
        private int num;
        public MyClass mc2;
        public MyClass() { }
        public MyClass(int num) { this.num = num; }
        public int Num { set { num = value; } get { return num; } }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            MyClass mc1 = new MyClass();
            mc1.Num++;
            Console.WriteLine(mc1.Num);
            mc1.mc2 = new MyClass(mc1.Num);
            mc1.mc2.Num++;
            Console.WriteLine(mc1.mc2.Num);
        }
    }
}
