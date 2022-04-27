// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int num = 14212;

int FirstDigit = (num / 10000) % 10;
int SecondDigit = (num / 1000) % 10;
int FourthDigit = (num / 10) % 10;
int FithDigit = num % 10;

if (FirstDigit == FithDigit && SecondDigit == FourthDigit) Console.Write("Да");
else Console.Write("Нет");