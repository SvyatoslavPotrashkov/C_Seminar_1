// Задача 22
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


System.Console.WriteLine("Введите число N:");
int x = Convert.ToInt32(Console.ReadLine());
int i=1;
System.Console.Write("квадратs чисел от 1 до N: ");
while(i<=x){
    System.Console.Write(i*i+ " ");
    i++;
    
}

// ЗАДАЧА ОТ ПРЕПОДАВАТЕЛЯ
// 1.
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i <= number; i++)
// {
//     Console.WriteLine(i*i);
// }
// 2.
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while(count <= number)
// {
//     Console.WriteLine(count*count);
//     count++;
// }
