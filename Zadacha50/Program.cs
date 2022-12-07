// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

int[,] FillArray(int[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = new Random().Next(0, 11);
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matr;
}

Console.WriteLine("Вот Ваш массив: ");
FillArray(matrix);

Console.Write("Укажите индекс элемента в строке: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите индекс элемента в столбце: ");
int column = Convert.ToInt32(Console.ReadLine());


if (row > m - 1 || column > n - 1 || row < 0 || column < 0)
{
    Console.WriteLine("Такого элемента нет");
}
else
    Console.WriteLine($"Ваш элемент: {matrix[row, column]}");









