using System;
 
namespace bmc
{
    class Q72
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
            int minNum = 0;
            int maxNum = arr.Length - 1;
            Console.Write("Item {0} is in position ",toFind);
            
            while (minNum < maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (toFind == arr[mid])
                {
                    Console.WriteLine("{0,2}",++mid);
                }
                if (toFind < arr[mid]) maxNum = mid - 1;
                else minNum = mid + 1;
            }
        }
    }
}
