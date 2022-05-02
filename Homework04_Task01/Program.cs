//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int A = 2, B = 3;
int Result = 1;
for (int i = 1; i <= B; i++)
{
    Result = Result * A;
}
Console.WriteLine(Result);
