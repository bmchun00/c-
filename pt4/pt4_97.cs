using System;
 
namespace bmc
{
    class Q97
    {
        static void Main()
        {
            int i, j;
            int tmp;
            int[] array = new int[61];
            int[,] rand_array = new int[6, 10];
            Random rand = new Random();
            for (i = 0; i <= 60; i++)
            {
                array[i] = i + 1;
            }
 
            Console.WriteLine("초기 상태:");
            for (int k = 0; k < 6; k++)
            {
                for (int q = 0; q < 10; q++)
                {
                    Console.Write("{0,2} ", array[k*10+q]);
                }
                Console.WriteLine(); ;
            }
            Console.WriteLine("\n11번째 숫자로 재 배열후:");
            
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (i == 0 && j < 5)
                    {
                        rand_array[i, j] = array[10] * (j + 1);
                        array[11 * (j + 1)] = 0;
                    }
 
                    else
                    {
                        while (true)
                        {
                            tmp = rand.Next(1, 61);
 
                            if (array[tmp] == 0)
                            {
                                continue;
                            }
                            else
                            {
                                rand_array[i, j] = array[tmp] - 1;
                                array[tmp] = 0;
                                break;
                            }
                        }
                    }
                }
            }
            for (int k = 0; k < 6; k++)
            {
                for (int q = 0; q < 10; q++)
                {
                    Console.Write("{0,2} ", rand_array[k, q]);
                }
                Console.WriteLine(); ;
            }
        }
    }
}
