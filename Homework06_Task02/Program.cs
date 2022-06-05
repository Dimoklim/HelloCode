// Найти произведение двух матриц. Кажется сделал неверно, подумаю ещё

int[,] CreateMatrix(int row, int col) // Метод создания и заполнения двумерного массива
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2) // Метод перемножения матриц
{
    int[,] product = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            product[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return product;
}

void PrintMatrix(int[,] array) // Метод вывода матриц
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = CreateMatrix(3,4);
int[,] matrix2 = CreateMatrix(3,4);
int[,] product = MultiplyMatrix(matrix1, matrix2);

PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(product);