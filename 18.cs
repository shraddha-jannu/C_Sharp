using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] matrix2 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] resultMatrix = new int[3, 3];

        Thread[,] threads = new Thread[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int row = i;
                int col = j;

                threads[row, col] = new Thread(() =>
                {
                    int sum = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        sum += matrix1[row, k] * matrix2[k, col];
                    }
                    resultMatrix[row, col] = sum;
                });

                threads[row, col].Start();
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                threads[i, j].Join();
            }
        }

        Console.WriteLine("Result Matrix:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
