// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10,10);
    }
    return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine("Ваш массив:"+ string.Join(" ",array));
int [] newarray= new int [array.Length];
for(int i = 0; i < array.Length; i++)
{
newarray[i]=array[i];

}
System.Console.WriteLine("Ваш массив:"+ string.Join(" ",newarray));


// _________________________________

// ОТ ПРЕПОДАВАТЕЛЯ
// int[] FillArray(int size)
// {
    
//     int[] arr = new int[size];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-9,10);
//     }
//     return arr;
// }

// Console.Write("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(num);
// Console.WriteLine(string.Join(", ", array));

// int[] newArray = new int[num];
// for(int i = 0; i < array.Length; i++)
// {
//     newArray[i] = array[i];
// }
// Console.WriteLine(string.Join(", ", newArray));
