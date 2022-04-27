// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

int Xa = 7, Xb = 1;
int Ya = -5, Yb = -1;
double dist = 0;
dist = Math.Sqrt(Math.Pow(Xa - Xb,2) + Math.Pow(Ya - Yb,2));
Console.Write(Math.Round(dist,2));