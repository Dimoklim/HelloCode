// Принимает на вход 3-значное число и выводит вторую цифру этого числа

//int num = new Random().Next(100, 1000);
//Console.WriteLine(num);
//num = num / 10;
//num = num % 10;
//Console.WriteLine(num);

int num = 918;
if (num > 100 && num < 1000)
{
    num = num / 10;
    num = num % 10;
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Число не входит в диапазон");
}