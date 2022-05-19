// Факториал и Фибоначчи

int Factorial(int n) // метод нахождения факториала
{
    if (n == 1 || n == 0) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
int Fibonacci(int n) // метод нахождения чисел Фибоначчи
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}