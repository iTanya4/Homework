// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.WriteLine("Введите целое число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целое число B");
// int b = Convert.ToInt32(Console.ReadLine());
// void Degree(int x, int y)
// {
//     int rez=1;
//     for (int i =1; i<=y;i++) 
//        { rez=rez*x;}
//     Console.WriteLine($"{x} в степени {y} равно {rez}");
// }
//  Degree (a,b);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sum(int x)
// {
//     int sum = 0;
//     int st = (int)Math.Log10(x)+1;
//     for (int i =1; i<=st;i++)
//         {sum = sum+ x % 10;
//         x = x/10;}   
//         return sum;
//      }
// Console.WriteLine("Введите целое число");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Sum(a);
// Console.WriteLine(b);


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33

//  int []array = new int [8];
//  void FillArray(int[] collection)
// {
//     int lenght = collection.Length;
//     for (int i =0; i<lenght;i++)
// {
//     Console.WriteLine($"Введите элемент {i}");
//     collection [i]= Convert.ToInt32(Console.ReadLine());
// }
//  }
//   void PrintArray (int[]col)
// { 
//     int count = col.Length;
//     int position = 0;
//     while (position < count )
//     {Console.Write($"{col[position]}  ");
//     position ++;
//     }
// }
//  FillArray(array);
// PrintArray(array);

// Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

// Console.WriteLine("Введите число: ");
// string s=Console.ReadLine();
// double x = Convert.ToDouble(s);
// int a = (int)Math.Log10(x)+1;
// double After (double b) 
//     {int i = 0;
//     while (b*Math.Pow(10,1 + i)%10 !=0)
//     {i++;}
//     return i;}
//     Console.WriteLine(After(x)+a);

// Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.. Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

// int []array = new int [8];
// void FillArray(int[] collection)
// {
//     int lenght = 8;
//     int index = 0;
//     while (index<lenght)
// {
//     collection[index] = new Random().Next(0,2);
//     index++;
// }
//  }
//  void PrintArray (int[]array)
// { 
//     int count = 8;
//     for (int i=0; i<count;i++)
//     {Console.Write($"{array[i] }  ");
//        }
// }
// FillArray (array);
// PrintArray (array);
// int p=0;
//     for (int i=0; i<8;i++)
//     {if (array[i]==1) 
//         p=p+1;}

// int num= 8-p;
// Console.WriteLine($",  число единиц в массиве равно {p}");
// bool comp = p>num;
// if (comp) Console.WriteLine("True");
// else Console.WriteLine("False");


