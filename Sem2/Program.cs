// // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 


// Console.WriteLine("Введите натуральное число ");
// int x=Convert.ToInt32 ( Console.ReadLine());
// if (x % 7 == 0 && x % 23 ==0) Console.Write("Да");
// else Console.Write("Нет");






// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет
// Console.WriteLine("Введите натуральное число 1");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число 2");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x * x == y || y * y == x)
//     Console.WriteLine("Правда");
// else Console.Write("Нет");



//Напишите программу, которая выводит целое  число любой разрядности и удаляет вторую цифру слева этого числа.

Console.WriteLine("Введите натуральное число ");
int N = Convert.ToInt32 ( Console.ReadLine());
int i=1;

while (i <= N)
{ 
    if (i%2==0) 
    Console.WriteLine(i);
 i++;
 }

 Console.WriteLine("Введите натуральное число ");
int x=Convert.ToInt32 ( Console.ReadLine());
int y1 = x % 100;
int y2 = y1 / 10;
Console.WriteLine(y2);