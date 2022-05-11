//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] array = { 203, 511, 516, 612 };

void PrintNew(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int[] createArray(int elements)
{
    //int num = new Random().Next(10,50);
    int[] arr = new int[elements];
    int i = 0;
    while (i < arr.Length)
    {
        arr[i] = new Random().Next(100, 1000);
        i++;
    }
    return arr;
}

int EvenNum(int[] array)
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
*/

int SumOfUneven(int[] numbers)  //Возвращает сумму элементов, находящихся на нечетных позициях(с нечетн индексом)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
        if (i % 2 != 0) result += numbers[i];
    return result;
}
int[] test = createArray(5);
PrintNew(test);
Console.WriteLine();
Console.WriteLine(SumOfUneven(test));


double[] newarray(int n)
{
    double[] array = new double[n];
    return array;
}

double[] randomArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*10;
        Console.Write(" " + array[i]);
    }
    Console.WriteLine();
    return array;
}

double summ(double[] ar)
{
    double summ = 0;
    double min = ar[0];
    double max = ar[0];

    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] < min)
        {
            min = ar[i];
        }
        if (ar[i] > max)
        {
            max = ar[i];
        }
        summ = max - min;
    }
    return summ;
}
int n = 5;
double[] array = newarray(n);
array = randomArray(array);
double summa = summ(array);
Console.WriteLine(summa);
