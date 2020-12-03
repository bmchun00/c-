using System;
 
namespace bmc
{
    class Q70
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
                getRank(arr, rnk, "Entered numbers and ranks -------------");
                Array.Sort(arr);
                getRank(arr, rnk, "Ascending order by numbers ------------");
                Array.Reverse(arr);
                getRank(arr, rnk, "Ascending order by ranks --------------");
                Console.Write("Continue? (y/n) ");
                check = Convert.ToChar(Console.ReadLine());
            }
        }
        static void getRank(int[] arr, int[] rnk, String str)
        {
            Console.WriteLine( str );
            for (int i = 0; i < arr.Length; i++) 
            {
                rnk[i]=1; //1로 초기화
                for (int j = 0;j<arr.Length;j++)
                {
                    if (arr[i]<arr[j])
                    {
                        rnk[i]++;
                    }
                }
                Console.WriteLine("Number: {0} - Rank: {1}",arr[i],rnk[i]);
            }
        }
    }
}
