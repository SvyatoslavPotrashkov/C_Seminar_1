// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (100 <= num && num < 1000)
{
    int firstNum = num / 10;
    int secondNum = firstNum % 10;
    Console.Write($"Число {secondNum}");
}
else if (-100 >= num && num > -1000)
{
    int firstNum = num / 10;
    int secondNum = firstNum % 10;
    secondNum = -secondNum;
    Console.Write($"Вторая цифра: {secondNum}");
}
else
{
    Console.Write("Вы ввели НЕ трехзначное число!");
}