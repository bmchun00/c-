using System;
 
namespace bmc
{
    class Q25
    {
        static void Main()
        {
            char[,] arr = new char[,] {{ 'M', 'O', 'M' },{ 'D','A','D'} };
            Console.WriteLine("Original state :");
            for(int i = 0;i<2;i++)
            {
                for (int j = 0;j<3;j++)
                    Console.Write(arr[i,j]);
                Console.WriteLine();
            }
            ArrSwitch(arr);
            Console.WriteLine("After switch :");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(arr[i, j]);
                Console.WriteLine();
            }
        }
        static void ArrSwitch(char[,] arr)
        {
            char[] tmpArr = new char[3];
            for (int i = 0; i < 3; i++)
            {
                tmpArr[i] = arr[0, i];
                arr[0, i] = arr[1, i];
                arr[1, i] = tmpArr[i];
            }
        }
    }
} 
