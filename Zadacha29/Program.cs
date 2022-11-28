// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// // ВВОД РАЗМЕРА С КЛАВЫ + любые элементы:

Console.WriteLine("Укажите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

string?[] array = new string[arraySize];
for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine("Введите символ: ");
    string? numString = Console.ReadLine();
    array[i] = numString;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
// ________________________________________________

// С проверкой на число (НЕ ПОЛУЧИЛОСЬ ИДЕАЛЬНО):

// string[] array = new string[8];

// for (int i = 0; i < 8; i++)
// {
//     Console.WriteLine("Введите число:");
//     string? num = Console.ReadLine();

//     if (int.TryParse(num, out int num1))
//     {
//         string numString = Convert.ToString(num);
//         array[i] = numString;
//         // Console.WriteLine("[" + string.Join(", ", array) + "]");
//     }

//     else
//     {
//         Console.WriteLine("Не является числом!");
//         break;
//     }
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");


// ____________________________________________________

// С ПРОВЕРКОЙ НА ЧИСЛО(КРИВОВАТО):

// string[] array = new string[8];

// for (int i = 0; i < 8; i++)
// {
//     Console.WriteLine("Введите число:");
//     string? num = Console.ReadLine();

//     if (int.TryParse(num, out int num1))
//     {
//         string numString = Convert.ToString(num);
//         array[i] = numString;
//         // Console.WriteLine("[" + string.Join(", ", array) + "]");
//     }

//     else
//     {
//         Console.WriteLine("Не является числом!");
//         break;
//     }
//     Console.WriteLine("[" + string.Join(", ", array) + "]");
// }

// _________________________________________

// РАБОЧАЯ С ЦИФРАМИ:

// string[] array = new string[8];
// for (int i = 0; i < 8; i++)
// {
//     Console.WriteLine("Введите число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     string numString = Convert.ToString(num);
//     array[i] = numString;
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");

// _________________________________________

// // // С ЛЮБЫМИ СИМВОЛАМИ:

// string[] array = new string[8];
// for (int i = 0; i < 8; i++)
// {
//     Console.WriteLine("Введите символ: ");
//     //int num = Convert.ToInt32(Console.ReadLine());
//     string? numString = Convert.ToString(Console.ReadLine());
//     array[i] = numString;
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// // __________________________________________________

