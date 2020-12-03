using System;
 
namespace PT71
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, front = 1, mid = 1, back = 1;
            Console.Write("Input number of terms to be display : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The fibonacci series upto {0} terms : ", num);
            Console.Write("{0,3}{1,3}",front,mid);
            for(int i=1;i<num-1;i++)
            {
                front = mid;
                mid = back;
                back = front + mid;
                Console.Write("{0,3}", back);                
            }
        }
    }
}

