//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32 ( Console.ReadLine());
// if (num1 > num2) Console.WriteLine("Первое число большее, второе меньшее");
// if (num2 > num1) Console.WriteLine("Второе число большее, первое меньшее");
// if (num1 == num2) Console.WriteLine("Первое и второе число равны");

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int num3 = Convert.ToInt32 ( Console.ReadLine());
// int maxim = num1;
// if (num2 > maxim) maxim = num2;
// if (num3 > maxim) maxim = num3;
// Console.WriteLine("Максимальным является число " + maxim);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// Console.WriteLine("Введите целое число");
// int x=Convert.ToInt32 ( Console.ReadLine());
// if ( x % 2 == 0) Console.WriteLine("Да, число четное");
// else Console.WriteLine("Нет, число нечетное");

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите натуральное число ");
int N = Convert.ToInt32 ( Console.ReadLine());
int i=1;

while (i <= N)
{ 
    if (i%2==0) 
    Console.WriteLine(i);
 i++;
 }
