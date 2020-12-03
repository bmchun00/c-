using System;
 
namespace bmc
{
    class Q69
    {
        static void Main()
        {
            int num;
            char check = 'y';
            while (check=='y')
            {
                Console.Write("Input the number of elements to store in the array : ");
                num = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[num];
                int[] rnk = new int[num];
                for (int i = 0; i < num; i++)
                {
                    Console.Write("Number {0} : ", i + 1);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                getRank(arr, rnk);
                Console.Write("Continue? (y/n) ");
                check = Convert.ToChar(Console.ReadLine());
            }
        }
        static void getRank(int[] arr, int[] rnk)
        {
            Console.WriteLine("----------------------------");
            for (int i = 0; i < arr.Length; i++) 
            {
                rnk[i]++; //1로 초기화
                for (int j = 0;j<arr.Length;j++)
                {
                    if (arr[i]<arr[j])
                    {
                        rnk[i]++;
                    }
                }
                Console.WriteLine("Number {0}: {1} (Rank: {2})",i+1,arr[i],rnk[i]);
            }
        }
    }
}
