// 8 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int DayOfWeek = 7;
if (DayOfWeek == 6 || DayOfWeek == 7) Console.Write("да");
if (DayOfWeek > 0 && DayOfWeek < 6) Console.Write("нет");
if (DayOfWeek <= 0 || DayOfWeek > 7) Console.Write("введите корректный день недели");