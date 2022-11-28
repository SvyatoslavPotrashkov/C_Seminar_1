// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// РЕШЕНИЕ С МИНУСОМ:

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    string numString = Convert.ToString(num);
    int lenght = numString.Length;
    int sum = 0;
    string firstNumString = Convert.ToString(numString[1]);
    int firstNumInt = Convert.ToInt32(firstNumString);
    int firstNumIntMinus = firstNumInt * -1;

    for (int index = 2; index < lenght; index++)
    {
        //if (numString[index] == 1)
        //{
            string currentNumString = Convert.ToString(numString[index]);
            int currentNumInt = Convert.ToInt32(currentNumString);
            sum = sum + currentNumInt;
        //}
    }
    sum = sum + firstNumIntMinus;

    Console.WriteLine(sum);
}

else

{
    string numString = Convert.ToString(num);
    int lenght = numString.Length;
    int sum = 0;

    for (int index = 0; index < lenght; index++)
    {
        string currentNumString = Convert.ToString(numString[index]);
        int currentNumInt = Convert.ToInt32(currentNumString);
        sum = sum + currentNumInt;
    }

    Console.WriteLine(sum);
}
// _________________________________

// РЕШЕНИЕ С ПРОВЕРКОЙ НА МИНУС:

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num<0)
// {
//     Console.WriteLine("Введите положительное число!");
// }
// else
// {
// string numString = Convert.ToString(num);
// int lenght = numString.Length;
// int sum = 0;

// for (int index = 0; index < lenght; index++)
// {
//     string currentNumString = Convert.ToString(numString[index]);
//     int currentNumInt = Convert.ToInt32(currentNumString);
//     sum = sum + currentNumInt;
// }

// Console.WriteLine(sum);
// }


// __________________________________________________
