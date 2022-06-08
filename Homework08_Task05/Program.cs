// Заполните спирально массив 4 на 4.

int a = 4, b = 4;

int[,] CreateArray(int a, int b) // Метод создания массива
{
    int[,] arr = new int[a, b];
    return arr;
}

void PrintArray(int[,] arr) // Метод вывода массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FillArray(int[,] arr, int count, int startI, int startJ) // Метод заполнения периметра массива
{
    for (int j = startJ; j < b; j++) // слева направо
    {
        if (arr[startI, j] == 0) arr[startI, j] = count;
        count++;
    }
    for (int i = startI + 1; i < a; i++) // сверху вниз
    {
        if (arr[i, b - 1] == 0) arr[i, b - 1] = count;
        count++;
    }
    for (int j = b - 2; j >= startJ; j--) // справа налево
    {
        if (arr[a - 1, j] == 0) arr[a - 1, j] = count;
        count++;
    }
    for (int i = a - 2; i > startI; i--) // снизу вверх
    {
        if (arr[i, startJ] == 0) arr[i, startJ] = count;
        count++;
    }
    return count;
}

int[,] arr = CreateArray(a, b);
int count = 1;
int startI = 0;
int startJ = 0;

while (a > 1 & b > 1) 
{
    count = FillArray(arr, count, startI, startJ);
    a--;
    b--;
    startI++;
    startJ++;
}

Console.WriteLine("Спирально заполненный массив:");
PrintArray(arr);