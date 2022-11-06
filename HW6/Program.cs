// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите M (количество чисел)");
// int length = Convert.ToInt32(Console.ReadLine());
// int []array = new int [length];
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

// void FindPozitive(int[] arr)
// {
//     int pozitive =0;
   
//     foreach (int el in arr)
//     {
//         if (el>0) pozitive=pozitive+1;
      
//     }
//     Console.WriteLine("");
//     Console.WriteLine($"Колличество положительных чисел {pozitive}");
// }
//  FillArray(array);
// PrintArray(array);
// FindPozitive(array);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите значение b1");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение k1");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение b2");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение k2");
// double k2 = Convert.ToDouble(Console.ReadLine());
// double x;
// double y;
// if (k1==k2) Console.WriteLine("точки пересечения нет");
// else 
//     {
//         x=(b2-b1)/(k1-k2);
//         y=k1*x+b1;
//         Console.WriteLine($"коордиаты точки пересечения ({x} ;{y})");
//     }

// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , 
// является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр,
//  значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

// Console.WriteLine("Введите число 1");
// double a1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// double a2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите число 3");
// double a3 = Convert.ToDouble(Console.ReadLine());

// bool Triangle(double a, double b, double c)
// {
//     bool x = false;
//    if ((a + b > c) && (b + c > a) && (a + c > b)) x = true; 
    
//     if (x) Console.WriteLine("треугольник может существовать");
//     else Console.WriteLine("треугольник не может существовать");
//     return x;
// }
// Triangle(a1, a2, a3);

//     if (a1==a2 && a2==a3) Console.WriteLine("треугольник равносторонний");
//     else if (a1==a2||a2==a3||a3==a1)Console.WriteLine("треугольник равнобедренный");
//     else if (((a1*a1)==(a2*a2)+(a3*a3))||((a2*a2)==(a1*a1)+(a3*a3))||((a3*a3)==(a2*a2)+(a1*a1)))Console.WriteLine("треугольник прямоугольный");

// double per = a1+a2+a3;
// double per2 = per/2;
// Console.WriteLine($"периметр треугольника равен {per}");
// double s = Math.Sqrt(per2*(per2-a1)*(per2-a2)*(per2-a3));
// Console.WriteLine($"площадь треугольника равна {s}");
// double corner1 = Math.Acos(((a2 * a2) + (a3 * a3) - (a1 * a1)) / (2 * a2* a3))* 180 / Math.PI;
// double corner2 = Math.Acos(((a1 * a1) + (a3 * a3) - (a2 * a2)) / (2 * a1 * a3))* 180 / Math.PI;
// double corner3 = 180-corner1-corner2;
// Console.WriteLine($"углы треугольника равны:  {corner1},   {corner2},    {corner3}"); 

// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с 
// клавиатуры). Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и 
// его индекс. Вывести эту информацию на экран.

// Console.WriteLine("Введите кол-во строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] mass = new int [m,n];

// void FillArray(int [,]matr)
// {
//     for (int i=0; i<matr.GetLength(0); i++)
//             {
//                 for (int j=0; j<matr.GetLength(1); j++)
//                 {
//                     matr[i,j] = new Random().Next(1,10);
//                 }
//             }
// }
// void PrintMas (int [,] matrix)
//     {
//         for (int i=0; i<matrix.GetLength(0); i++)
//             {
//                 for (int j=0; j<matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i,j]}  ");
//             }
//     Console.WriteLine();
//         }
//     }
// FillArray(mass);
// PrintMas(mass);
// int max = mass[0,0]; 
// for (int i=0; i<mass.GetLength(0); i++)
//             {
//                 for (int j=0; j<mass.GetLength(1); j++)
//             {
//                   if (mass[i,j]>max) max = mass[i,j];
//       }
//                 Console.WriteLine("    ");
// Console.WriteLine($"максимальное значение элемента = {max}");
// break;
//         }

// int min = mass[0,0]; 
// for (int i=0; i<mass.GetLength(0); i++)
//             {
//                 for (int j=0; j<mass.GetLength(1); j++)
//             {
//                   if (mass[i,j]<min) min = mass[i,j];
//       }
//                 Console.WriteLine("    ");
// Console.WriteLine($"минимальное значение элемента = {min}");
// break;
        }