// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray (int length) // метод создания рандомного массива
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
string PrintArrayToString (int[] array) // метод вывода массива в виде строки
{
    return String.Join (',', array);
}
Console.Write(PrintArrayToString(CreateRandomArray(8)));