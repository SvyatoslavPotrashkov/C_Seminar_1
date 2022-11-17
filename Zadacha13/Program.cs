// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Ниже ДВА ВАРИАНТА РЕШЕНИЯ

// 1 Вариант, через while:

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0 && num >= -99)
{
    Console.WriteLine("Третьей цифры нет!");
}
else if (num < -99)
{
    while (num < -999)
    {
        num = num / 10;
    }
    num = -num % 10;
    Console.WriteLine($"Третья цифра: {num}");
}
else if (num < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else if (num < 1000)
{
    num = num % 10;
    Console.WriteLine($"Третья цифра: {num}");
}
else if (num > 999)
{
    while (num > 999)
    {
        num = num / 10;
    }
    num = num % 10;
    Console.WriteLine($"Третья цифра: {num}");
}

// 2 Вариант, через string:

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 0 && num >= -99)
// {
//     Console.WriteLine("Третьей цифры нет!");
// }
// else if (num < -99)
// {
//     num = -num;
//     string num1 = Convert.ToString(num);
//     Console.WriteLine($"Третья цифра: {num1[2]}");

// }
// else if (num < 100)
// {
//     Console.WriteLine("Третьей цифры нет!");
// }
// else if (num > 99 && num < 999)
// {
//     int modnum = num % 10;
//     Console.WriteLine($"Третья цифра: {modnum}");
// }
// else if (num > 999)
// {
//     string num1 = Convert.ToString(num);
//     Console.WriteLine($"Третья цифра: {num1[2]}");
// }






