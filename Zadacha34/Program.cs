// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}
Console.Write("Укажите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine(string.Join(", ", array));
int kolichestvo = 0;

for(int i=0;i<array.Length;i++)
{
    if(array[i]%2==0)
    {
        kolichestvo +=1;
    }
}
Console.WriteLine($"Количество чётных чисел в массиве: {kolichestvo}");