// Напишите метод, который выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = new Random().Next(10, 100);
int max = 0;

void MaxDigit()         // Определяем метод
{
    int FirstDigit = num / 10;
    int SecondDigit = num % 10;
    if (FirstDigit > SecondDigit) max = FirstDigit;
    else max = SecondDigit;
    Console.Write ($"Наибольшая цифра числа {num} это {max}");          // Интерполяция
}

MaxDigit();         // Вызываем метод