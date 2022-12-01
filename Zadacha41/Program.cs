// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите число {i + 1}:");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

Console.Write("Сколько чисел будем вводить: ");
int quantity = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(quantity);
Console.WriteLine($"Вы указали чисел: {quantity}");
Console.WriteLine("Вы ввели числа: " + string.Join(", ", array));
int count = 0;
int[] arr = array;

for (int i = 0; i < array.Length; i++)
{
    if (arr[i] > 0)
    {
        count = count + 1;
    }
}
Console.WriteLine($"Вы ввели чисел больше 0:  {count} ");