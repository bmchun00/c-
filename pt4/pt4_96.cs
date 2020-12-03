using System;
 
namespace bmc
{
    class Q96
    {
        static void Main()
        {
            char chk = 'y';
            while (chk == 'y')
            {
                int[] i = new int[2] { 0, 0 };
                int[] j = new int[2] { 0, 0 };
                int n, k = 1, index = 0;
                int[] s = new int[4] { 0, 1, 0, -1 };
                int[] h = new int[4] { 1, 0, -1, 0 };
 
                Console.Write("Insert the size of matrix (1 <= N <= 20) : ");
                n = Convert.ToInt32(Console.ReadLine());
                int tmp = n;
                int[,] matrix = new int[n, n];
                while (k < n * n)
                {
                    while (true)
                    {
                        matrix[i[0], j[0]] = k;
                        i[0] += s[index % 4];
                        j[0] += h[index % 4];
                        if (i[0] >= n || j[0] >= n || i[0] < 0 || j[0] < 0)
                        {
                            i[0] -= s[index % 4];
                            j[0] -= h[index % 4];
                            break;
                        }
                        else if (matrix[i[0], j[0]] != 0)
                        {
                            i[0] -= s[index % 4];
                            j[0] -= h[index % 4];
                            break;
                        }
                        k++;
                    }
                    index++;
                }
                for (int g = 0; g < n; g++)
                {
                    for (int o = 0; o < n; o++)
                    {
                        Console.Write("{0,2} ", matrix[g, o]);
                    }
                    Console.WriteLine();
                }
                Console.Write("Continue? (y/n) ");
                chk = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
