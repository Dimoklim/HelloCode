// Написать программу, которая принимает на вход 2 числа и выводит является ли второе число кратным первому
// Если не кратно выводит остаток от деления

int N = 34, B = 5;
if (N % B == 0) Console.Write("Кратно");
else Console.Write($"Не кратно, остаток {N % B}");