// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = num;
// int count = 0;

// while(num > 0){
//     num /= 10;
//     count++;
// }

// Console.WriteLine($"Количество цифр в числе {num1} равно {count}");

// РЕШЕНИЯ ОТ ПРЕПОДАВАТЕЛЯ:

// int A = Convert.ToInt32(Console.ReadLine());
// string A1 = A.ToString();
// Console.Write("Цифр в числе " + A1.Length);

// int count = 0;
// while(A > 0)
// {
//     A/=10;
//     count++;
// }
// Console.Write("Цифр в числе " + count);

// ________________________________________________

// string? A = Console.ReadLine();
// if (int.TryParse(A, out int num))
//     Console.Write("Количество цифр в числе: " + A.Length);
// else
//     Console.Write("В строке не только цифры, напишите число");