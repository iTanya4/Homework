// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите целое пятизначное число n");
// int n = Convert.ToInt32 ( Console.ReadLine());
// int a1  = n/10000;
// int a5 = n%10;
// int a2 = (n - (a1*10000))/1000;
// int a4 = (n%100)/10;
// if ((a1==a5)&&(a2==a4))Console.WriteLine("да");
// else Console.WriteLine("нет");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.WriteLine("Введите координаты x1 точки A");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y1 точки A");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z1 точки A");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты x2 точки B");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y2 точки B");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z2 точки B");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Расстояние между двумя точками равно  {dist}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i=1; i<=n;i=i+1)
//     Console.Write($"{i*i*i} ");


// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.
Console.WriteLine("Введите размер пространства N");
int n = Convert.ToInt32(Console.ReadLine());
 int summa = 0;
for (int i=0; i<n;i++)
{Console.WriteLine($"Введите координаты {i} точки A");
 int a1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"Введите координаты {i} точки B");
 int b1 = Convert.ToInt32(Console.ReadLine());
int r = b1-a1;
summa = summa + r*r;}
double dist = Math.Sqrt(summa);
{Console.WriteLine($"Расстояние между двумя точками равно  {dist}");}

