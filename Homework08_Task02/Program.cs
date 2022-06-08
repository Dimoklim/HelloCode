//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int MinSum(int[,] matr) // Метод нахождения строки с минимальной суммой элементов
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 0) 
            {
                sum = sum + matr[i, j];
                minSum = minSum + matr[i, j]; 
            }
            else sum = sum + matr[i, j]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = i;
        }
        sum = 0;
    }
    return minNum;
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"{MinSum(matrix)} {"строка"}");