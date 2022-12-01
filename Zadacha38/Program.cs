// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// К сожалению, в этот раз нет времени делать несколько вариантов.

double[] FillArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        double D = Math.Round(new Random().Next(10, 1000) / 10D, 2);
        arr[i] = D;
    }
    return arr;
}

Console.Write("Задайте длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(num);
Console.WriteLine("В массиве: " + "[" + string.Join(", ", array) + "]");

double maxNum = array.Max();
double minNum = array.Min();
double difference=maxNum-minNum;

Console.WriteLine($"Максимальное число: {maxNum}");
Console.WriteLine($"Минимальное число: {minNum}");
Console.WriteLine($"Разница: {difference}");