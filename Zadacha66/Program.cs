// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Rec(int n, int m)
{
    if (m > n)
    {
        if (n == m)
        {
            return 1;
        }
        return m + Rec(n, m - 1);
    }
    else if (m < n)
    {
        if (m == n) return 1;
        return n + Rec(n - 1, m);
    }
    else
    return n;
}
Console.Write("Введите первое значение: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй значение: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Rec(N, M));