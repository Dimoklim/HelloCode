﻿// Задача 4. Написать программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N = 8;
int i = 1;
while (i <= N)
{
    if (i % 2 == 0) Console.WriteLine(i);
    i = i + 1;
}