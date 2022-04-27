// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Xa = 7, Xb = 1;
int Ya = -5, Yb = -1;
int Za = 0, Zb = 9;
double dist = 0;
dist = Math.Sqrt(Math.Pow(Xa - Xb,2) + Math.Pow(Ya - Yb,2) + Math.Pow(Za - Zb,2));
Console.Write(Math.Round(dist,2));