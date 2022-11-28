// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] num = new int[8];

// int length = num.Length;

// for (int i = 0; i < length; i++){
//     num[i] = new Random().Next(0, 2);
// }

// for (int i = 0; i < length; i++){
//     Console.Write(num[i]);
// }


int[] num = new int[8];

int length = num.Length;

for (int i = 0; i < length; i++){
    num[i] = new Random().Next(0, 2);
}

for (int i = 0; i < length; i++){
    Console.Write(" " + num[i]);
}


// РЕШЕНИЕ ОТ ПРЕПОДАВАТЕЛЯ:
// int [] arr = new int [8];
// for(int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(0,2);
//     //Console.Write(" " + arr[i]);
// }
// Console.Write('[' + string.Join(", ", arr) + ']');
