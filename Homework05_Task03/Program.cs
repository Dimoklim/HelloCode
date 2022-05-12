// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

double[] newarray(int n) // Метод создания массива
{
    double[] array = new double[n];
    return array;
}

double[] randomArray(double[] array) // Метод заполнения массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*10;
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

double summ(double[] ar) // Метод нахождения разницы max и min
{
    double summ = 0;
    double min = ar[0];
    double max = ar[0];

    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] < min) min = ar[i];
        if (ar[i] > max) max = ar[i];
        summ = max - min;
    }
    return summ;
}

int n = 8;
double[] array = newarray(n);
array = randomArray(array);
double summa = summ(array);
Console.WriteLine(summa);