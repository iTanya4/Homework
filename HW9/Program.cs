// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write ("Введите число N  ");
int n = Convert.ToInt32(Console.ReadLine());
string CountRec(int n)
{
    if (n==0) return "  ";
       return  $"{n} "+ CountRec(n-1); 
}
Console.WriteLine(CountRec(n));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Console.Write("Введите целое число M ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число N ");
// int n = Convert.ToInt32(Console.ReadLine());
// int SumRec(int n)
// {
//     if (n==m) return 0;
//     return n + SumRec(n-1);
// }
// Console.WriteLine($"сумма натуральных элементов в промежутке от M до N = {m+SumRec(n)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// Console.Write("Введите целое число m ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число n ");
// int n = Convert.ToInt32(Console.ReadLine());
// int FunAk (int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0 && m > 0) return FunAk(m - 1, 1);
//     else return (FunAk(m - 1, FunAk(m, n - 1)));
// }
// Console.WriteLine(FunAk(m,n));