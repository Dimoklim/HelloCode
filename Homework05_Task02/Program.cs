// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] createArray(int elements) // Метод создания и заполнения массива
{
    int[] arr = new int[elements];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void PrintNew(int[] array) // Метод вывода массива
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int SumOfUneven(int[] numbers)  // Метод возвращает сумму элементов на нечетных позициях(с нечетным индексом)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
        if (i % 2 != 0) result += numbers[i];
    return result;
}
int[] test = createArray(10);
PrintNew(test);
Console.WriteLine();
Console.WriteLine(SumOfUneven(test));