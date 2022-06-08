// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArray(int[,] matr) // Метод заполнения массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr) // Метод вывода массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void DescendingSort(int[,] matr) // Метод сортировки элементов в строке по убыванию
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - j - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int t = matr[i, k];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = t;
                }
            }
        }
    }
}

int[,] matrix = new int[4, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
DescendingSort(matrix);
PrintArray(matrix);