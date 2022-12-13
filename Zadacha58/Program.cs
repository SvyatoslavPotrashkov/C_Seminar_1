// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Первая матрица:");
int[,] matrix1 = new int[2, 2];
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        int D = Convert.ToInt32(new Random().Next(1, 10));
        matrix1[i, j] = D;
        Console.Write(matrix1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
int[,] matrix2 = new int[2, 2];
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        int D = Convert.ToInt32(new Random().Next(1, 10));
        matrix2[i, j] = D;
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Произведение матриц:");

int[,] matrix3 = new int[2, 2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            matrix3[i, j] += matrix1[i, k] * matrix2[k, j];

        }
        //Console.Write(matrix3[i, j] + " ");
    }
}
//Console.WriteLine("Суммы строк: " + string.Join(", ", matrix3));

void PrintMatrix(int[,] matrix3)
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            Console.Write(matrix3[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintMatrix(matrix3);