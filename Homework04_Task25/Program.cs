// Найти сумму чисел от 1 до А

int SumOfNumbers(int A) // Способ 1
{
    int res = 0;
    for (int i = 0; i <= A; i++)
    {
        res = res + i;
    }
    return res;
}
//Console.Write(SumOfNumbers(15)); 

int A = new Random().Next(2, 100); // Способ 2
int res = A * (A + 1) / 2;
Console.Write($"Сумма чисел от 1 до {A} равна {res}");