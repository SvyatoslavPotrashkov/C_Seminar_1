// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
//Console.WriteLine();
int[,] resultMatrix = new int[m, n];
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        int temp = 0;

        for (int k = 0; k < resultMatrix.GetLength(0); k++)
        {
            for (int l = 0; l < resultMatrix.GetLength(1) - 1; l++)
            {
                if (matrix[k,l] < matrix[k,l + 1])
                {
                    temp = matrix[k,l + 1];
                    matrix[k,l + 1] = matrix[k,l];
                    matrix[k,l] = temp;
                }
            }
        }

        // for (int i = 0; i < matrix.Length; i++)
        //     Console.Write(matrix[i] + " ");
        resultMatrix[i, j] = matrix[i, j];
    }
    // Console.WriteLine();
}
Console.WriteLine();
PrintMatrix(resultMatrix);

