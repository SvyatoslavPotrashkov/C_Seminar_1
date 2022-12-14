// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Задайте прямоугольный двумерный массив:");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m==n)
{
    Console.WriteLine("Вы задали квадратный массив! Задайте прямоугольный!");
}
else
{
int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}




int[,] matrix = FillMatrix(m, n);
Console.WriteLine();
Console.WriteLine("Ваш массив:");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();

int[] Array = new int[m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];
    }
    Array[i] = sum;
}

Console.WriteLine("Суммы строк: " + string.Join(", ", Array));
int z = 0;
int minSum = Array[0];
for (int i = 0; i < Array.Length; i++)
{
    if (minSum >= Array[i])
    {
        minSum = Array[i];
        z = i+1;
    }
}
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов находится в строке {z}");
}