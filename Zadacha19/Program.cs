// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
string num1 = Convert.ToString(num);

if (num>9999&&num<100000)
{
    if(num1[0]==num1[4]&&num1[1]==num1[3]){
        Console.WriteLine($"Число {num1} является палиндромом!");
    }
    else
    {
        Console.WriteLine($"Число {num1} НЕ является палиндромом!");
    }
}
else
{
    Console.WriteLine($"Число {num1} не пятизначное!");
}