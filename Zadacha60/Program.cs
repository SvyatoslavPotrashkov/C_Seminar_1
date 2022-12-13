// Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] matrix1 = new int[2, 2, 2];
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            int D = Convert.ToInt32(new Random().Next(10, 99));
            matrix1[i, j, k] = D;
        }
    }
}
Console.WriteLine();

void PrintMatrix(int[,,] matrix1)
{
    for (int k = 0; k < matrix1.GetLength(0); k++)
    {
        for (int i = 0; i < matrix1.GetLength(1); i++)
        {
            for (int j = 0; j < matrix1.GetLength(2); j++)
            {
                Console.Write(matrix1[i, j, k] + "(" + i + ", " + j + ", " + k + ") ");
            }
            Console.WriteLine();
        }
    }
}
PrintMatrix(matrix1);
Console.WriteLine();