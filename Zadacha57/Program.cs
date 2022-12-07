// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза
int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}


//
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();

for(int j = 0; j < matrix.GetLength(1); j++)
{
    int temp = matrix[0, j];
    matrix[0,j] = matrix[matrix.GetLength(0)-1,j];
    matrix[matrix.GetLength(0)-1,j] = temp;
}

PrintMatrix(matrix);


//

for(int k = 0; k < 10; k++)
 {   
    int count = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            { 
                if ( matrix[i,j] == k)
                {
                    count++;
                }
            }
        }
    if (count > 0) 
    {
        Console.WriteLine($"Число {k} встречается {count} раз.");
    }
}


// ______________________________
// ОТ ПРЕПОДАВАТЕЛЯ
// КОНЕЧНАЯ ЧАСТЬ

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = FillMatrix(m,n);
// PrintMatrix(matrix);
// Console.WriteLine();

// for(int k = 0; k < 10; k++)
// {
//     int count = 0;
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(matrix[i,j] == k)
//             {
//                 count++;
//             }
//         }
//     }
//     if(count != 0) Console.WriteLine($"Кол-во повторений для {k} = {count}");
// }


// ________________
// ЕЩЕ ОТ ПРЕПОДАВАТЕЛЯ

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrix(m, n);
// PrintMatrix(matrix);
// Console.WriteLine();

// int[] countArray = new int[10];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int index = matrix[i,j];
//         countArray[index]++;
//     }
// }

// for(int i = 0; i < countArray.Length; i++)
// {
//     if(countArray[i] != 0)
//     {
//         Console.WriteLine($"Кол-во повторений для {i} = {countArray[i]} раз");
//     }
// }
