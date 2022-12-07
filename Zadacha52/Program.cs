// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
            matr[i, j] = Convert.ToInt32(new Random().Next(0, 11));
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matr;
}

Console.WriteLine("Вот Ваш массив: ");
FillArray(matrix);

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double summa = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        summa = summa + matrix[j, i];
    }
    Console.WriteLine($"Среднее арифметическое столбца {i + 1}: {Math.Round(summa / matrix.GetLength(0), 2)}");
}