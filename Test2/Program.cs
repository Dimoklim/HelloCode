
int[] CreateArray (int length) // метод создания массива
{
    int[] array = new int[length];
    return array;
}

int[] FillRandomArray (int[] array) // метод заполнения массива
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int SumArray(int[] array) // метод нахождения суммы элементов массива
{
    int len = array.Length;
    int sum = 0;
    for (int i = 0; i < len; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

/*void PrintArray (int[] array) // метод вывода массива
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
}*/

string PrintArrayToString (int[] array) // метод вывода массива в виде строки
{
    return String.Join (',', array);
}

int[] array = CreateArray(12);
FillRandomArray(array);
int sum = SumArray(array);
Console.WriteLine(sum);
//PrintArray(array);
Console.WriteLine (PrintArrayToString (array));