using System;
 
namespace bmc
{
    class Q93
    {
        static void Main()
        {
            int num, min, temp, tomod;
            Console.Write("Input the size of array : ");
            num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            int[] modarr = new int[num + 1];
            for (int i = 0; i < num; i++)
            {
                Console.Write("Number {0} : ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The current list of the array :");
            printArr(arr);
            for (int i = 0; i < num - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < num; j++)
                {
                    if (arr[j] < arr[min]) min = j;
                }
                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            Console.WriteLine("\nThe list of the array after sorting :");
            printArr(arr);
            Console.Write("\nInput the value to be inserted : ");
            tomod = Convert.ToInt32(Console.ReadLine());
            for (int i = 0;true;i++)
            {
                modarr[i] = arr[i];
                if (arr[i] >= tomod)
                {
                    temp = i;
                    break;
                }
            }
            modarr[temp] = tomod;
            for (int i = temp;i<arr.Length;i++)
            {
                modarr[i+1] = arr[i];
            }
            Console.WriteLine("\nAfter Insert, the element of the array is :");
            printArr(modarr);
        }
        static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,3}", arr[i]);
            }
        }
    }
} 
