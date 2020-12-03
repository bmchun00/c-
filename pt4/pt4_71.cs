using System;
 
namespace bmc
{
    class Q71
    {
        static void Main()
        {
            int num, toFind;
            Console.Write("Input the number of elements to store in the array : ");
            num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write("Number {0} : ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The original array list is :");
            for (int i = 0;i<num;i++)
                Console.Write("{0,2}",arr[i]);
            Console.Write("\nInput the value to search :");
            toFind = Convert.ToInt32(Console.ReadLine());
            search(arr, toFind);
        }
        static void search(int[] arr, int toFind)
        {
            Console.Write("Item {0} is in position ",toFind);
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == toFind) Console.Write("{0,2}",i+1);
        }
    }
}
