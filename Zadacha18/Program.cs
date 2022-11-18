// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1)
// {
//     Console.WriteLine("x > 0 и y > 0");
// }
// else if (num == 2)
// {
//     Console.WriteLine("x < 0 и y > 0");
// }
// else if (num == 3)
// {
//     Console.WriteLine("x < 0 и y < 0");
// }
// else if (num == 4)
// {
//     Console.WriteLine("x > 0 и y < 0)");
// }

//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string[] arr = { "x>0 и y>0", "x<0 и y>0", "x<0 и y<0", "x>0 и y<0" };
System.Console.WriteLine("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());
//НЕ ХВАТАЕТ ПРОВЕРКИ НА ДРУГИЕ ЧИСЛА    
if (num == 1)
{
    System.Console.WriteLine($"Номер четверти{arr[num - 1]}");
}
else if (num == 2)
{
    System.Console.WriteLine($"Номер четверти{arr[num - 1]}");
}
else if (num == 3)
{
    System.Console.WriteLine($"Номер четверти{arr[num - 1]}");
}
else if (num == 4)
{
    System.Console.WriteLine($"Номер четверти{arr[num - 1]}");
}


// РЕШЕНИЕ ОТ ПРЕПОДАВАТЕЛЯ:
// string [] quarters = {"x > 0; y > 0",// 0
//                       "x < 0; y > 0",// 1
//                       "x < 0; y < 0",// 2
//                       "x > 0; y < 0"// 3
// };
// Console.WriteLine("Введите номер четверти: ");
// int quarter = Convert.ToInt32(Console.ReadLine());
// if(quarter >= 1 && quarter <= 4)
// {
//     Console.WriteLine(quarters[quarter-1]);
// }
// else
// {
//     Console.WriteLine("Такой четверти нет");
// }
