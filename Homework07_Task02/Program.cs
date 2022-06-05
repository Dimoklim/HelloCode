// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.Write("Введите кол-во строк массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int b = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 100;

int[,] CreateMatrix(int a, int b, int min, int max) // Метод создания и заполнения двумерного массива
{
    int[,] matrix = new int[a, b];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintArray(int[,] array) // Метод вывода массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[] GetNumsMinRawColumn(int[,] array) // Поиск минимального элемента массива и номеров строки и столбца 
{
    int[] numbers = new int[] { 0, 0 };
    int minNumber = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minNumber)
            {
                minNumber = array[i, j];
                numbers[0] = i;
                numbers[1] = j;
            }
        }
    }
    return numbers;
}

int[,] RemoteRawColumn(int[,] matrix, int[] array) // Метод удаления строки и столбца с минимальным элементом
{
    int[,] matrix2 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)]; // Удаляем строку из исходного массива
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (i < array[0]) matrix2[i, j] = matrix[i, j];
            else matrix2[i, j] = matrix[i + 1, j];
        }
    }
    int[,] resultMatrix = new int[matrix2.GetLength(0), matrix2.GetLength(1) - 1]; // Удаляем столбец из массива с удаленной строкой
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                if (j < array[1]) resultMatrix[i, j] = matrix2[i, j];
                else resultMatrix[i, j] = matrix2[i, j + 1];
            }
        }
    }
    return resultMatrix;
}

int[,] matrix = CreateMatrix(a, b, min, max);
PrintArray(matrix);
int[] minPosition = GetNumsMinRawColumn(matrix);
int[,] matrixWithoutRawCol = RemoteRawColumn(matrix, minPosition);
PrintArray(matrixWithoutRawCol);