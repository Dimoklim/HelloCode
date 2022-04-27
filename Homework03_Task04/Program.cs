// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int x = 1; 
int y = -5; 
 
int QuarterNum = 0; 
if (x > 0 && y > 0) QuarterNum = 1; 
if (x < 0 && y > 0) QuarterNum = 2; 
if (x < 0 && y < 0) QuarterNum = 3; 
if (x > 0 && y < 0) QuarterNum = 4; 
Console.WriteLine(QuarterNum);