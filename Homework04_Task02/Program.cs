// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = new Random().Next(1, 10000);
int sum = 0;

Console.Write($"Сумма цифр в числе {number} равна ");
for (int i = 0; number >= 1; i++)
{
    sum = sum + number % 10;
    number = number / 10;
}
Console.Write(sum);