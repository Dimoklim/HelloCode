// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System;

public class ProdMatrix
{
    public static void Main()
    {
        int row1, col1, row2, col2;

        int[,] a = {
                          {1, 3, 2},
                          {3, 1, 1},
                          {1, 2, 2}
                     };

        int[,] b = {
                         {2, 1, 1},
                         {1, 0, 1},
                         {1, 3, 1}
                     };

        row1 = a.GetLength(0);
        col1 = a.GetLength(1);

        row2 = b.GetLength(0);
        col2 = b.GetLength(1);

        if (col1 != row2)
        {
            Console.WriteLine("Невозможно перемножить 2 матрицы");
        }
        else
        {
            int[,] prod = new int[row1, col2];
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    for (int k = 0; k < row2; k++)
                    {
                        prod[i, j] = prod[i, j] + a[i, k] * b[k, j];
                    }
                }
            }

            Console.WriteLine("Произведение 2 матриц: ");
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    Console.Write(prod[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
