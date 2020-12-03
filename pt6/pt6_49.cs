using System;
 
namespace Test3
{
    class Tester
    {
        int x; static int y = 1;
        public Tester()
        {
            this.x++;
            Tester.y++;
        }
        public Tester(int i) : this()
        {
            int x = i;
            this.x += i;
        }
        static Tester() { y++; }
        static void Main(string[] args)
        {
            Tester t = new Tester(1);
            Console.WriteLine("x = {0}, y = {1}", t.x, y);
        }
    }
} 
