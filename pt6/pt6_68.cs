using System;
 
namespace Ex1
{
    public class MyDate
    {
        private int day = 1;
        private int month = 1;
        private int year = 2000;
        public MyDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public MyDate(MyDate date)
        {
            this.day = date.day;
            this.month = date.month;
            this.year = date.year;
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public MyDate AddDays(int moredays)
        {
            MyDate newdate = new MyDate(this);
            newdate.day = newdate.day + moredays;
            return newdate;
        }
        public void Print()
        {
            Console.WriteLine("MyDate: " + day + "-" + month + "-" + year);
        }
    }
    class ObjReturn
    {
        static void Main(string[] args)
        {
            MyDate today = new MyDate(15, 12, 2009);
            MyDate theNextWeek = today.AddDays(7);
            theNextWeek.Print();
        }
    }
}
