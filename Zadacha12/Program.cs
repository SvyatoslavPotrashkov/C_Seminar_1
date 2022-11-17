// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.Write("Введите первое число -> ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число -> ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num % num1 == 0){
    Console.WriteLine($"{num} кратно {num1}");
}
else{
    int os = num % num1;
    Console.WriteLine($"Число {num} не кратно {num1}, остаток {os}");
}


// Еще варик:
// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int mod = number1 % number2;
// if(mod == 0)
// {
//     Console.WriteLine("Числа кратные");
// }
// else
// {
//     Console.WriteLine("Числа не кратные, остаток " + mod);
// }
