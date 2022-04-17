// Задача 2. Найти наибольшее из 3 целых чисел.
int a = 22;
int b = 3;
int c = 9;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max = ");
Console.Write(max);