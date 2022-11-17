// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное число {number}");
int digit1 = number/100;
int digit2 = number%10;
Console.WriteLine($"{digit1}{digit2}");


// Еще вариант:
// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Наше случайное число = {number}");
// int numberA = number/100;
// int numberC = number%10;
// Console.WriteLine($"Получается число {numberA*10+numberC}");

// Еще варик:
// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Наше случайное число = {number}");
// int numberA = number/100;
// int numberC = number%10;
// int result = numberA*10+numberC;
// Console.WriteLine($"Получается число {result}");
