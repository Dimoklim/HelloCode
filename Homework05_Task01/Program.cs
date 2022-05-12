// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] createArray(int elements) // метод создания и заполнения массива
{
    int[] arr = new int[elements];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void PrintNew(int[] array) // метод вывода массива
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int EvenNum(int[] array) // метод нахождения кол-ва четных элементов
{
    int length = array.Length;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) result += 1;
    }
    return result;
}

int [] test = createArray(10);
PrintNew(test);
Console.WriteLine();
Console.WriteLine(EvenNum(test));