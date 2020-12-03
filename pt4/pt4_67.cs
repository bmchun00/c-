using System;
 
namespace bmc
{
    class Q67
    {
        static void Main()
        {
            int num, min, temp;
            Console.Write("Input the number of elements to store in the array : ");
            num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++) 
            {
                Console.Write("Number {0} : ",i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The original array:");
            printArr(arr);
            for (int i = 0; i < num - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < num; j++)
                {
                    if (arr[j] > arr[min]) min = j;
                }
                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            Console.WriteLine("\nThe sorted array:");
            printArr(arr);
        }
        static void printArr(int[] arr)
        {
            for(int i = 0;i<arr.Length;i++)
            {
                Console.Write("{0,3}",arr[i]);
            }
        }
    }
}
