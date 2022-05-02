// Найти сумму чисел от 1 до А

int SumOfNumbers(int A)
{
    int res = 0;
    for (int i = 0; i <= A; i++)
    {
        res = res + i;
    }
    return res;
}
Console.Write(SumOfNumbers(15));
