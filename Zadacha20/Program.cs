// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine("Введите x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

int TotalX = x1-x2;

int TotalY = y1-y2;

double lenght =Math.Round( Math.Sqrt (Math.Pow(TotalX,2)+Math.Pow(TotalY,2)),2);
System.Console.WriteLine(lenght);

// РЕШЕНИЕ ОТ ПРЕПОДАВАТЕЛЯ
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координату X точки А: ");
// int Ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y точки А: ");
// int Ay = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X точки B: ");
// int Bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y точки B: ");
// int By = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay,2)), 2);
// Console.WriteLine(distance);
