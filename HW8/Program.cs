// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// Console.WriteLine("Введите количество строк");
//  int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j]= new Random().Next(0,21);
//     }
//     return array;
// }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] mas=FillArray(m,n);
// PrintArray(mas);

// void SortAr(int [,] sortarray)
//   {
//     for (int i = 0; i < sortarray.GetLength(0); i++)
//     {
//         for (int j = 0; j < sortarray.GetLength(1); j++)
//         {
//             for (int k=0; k < sortarray.GetLength(1)-1; k++)
//             {
//               if (sortarray[i,k]<sortarray[i,k+1])
//               {
//                 int temp = sortarray[i,k+1];
//                 sortarray[i,k+1]=sortarray[i,k];
//                 sortarray[i,k]=temp;
//               }
//             }
//         }
//     }
//   }

// Console.WriteLine();
// SortAr(mas);
// PrintArray(mas);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите количество строк");
//  int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j]= new Random().Next(0,21);
//     }
//     return array;
// }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] mas=FillArray(m,n);
// PrintArray(mas);

// int MinSum ( int [,] array, int k)
// { 
//   int sum = 0;
//        for (int j = 0; j < array.GetLength(1); j++)
//         {
            
//              sum = sum + array[k,j];   
//          }
//       return sum;
// }
// int num = 1;
// int minstr=MinSum(mas, 0);
// for (int i=1; i<m; i++)
//   {
//     if ((MinSum(mas,i))<minstr)
//       {
//       minstr=MinSum(mas,i);
//       num=i+1;
//       }
//   }
// Console.WriteLine($"наименьшая сумма элементов в {num} строке");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите количество строк матрицы A");
//  int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов матрицы A и строк матрицы B");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов матрицы B");
// int sb = Convert.ToInt32(Console.ReadLine());

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j]= new Random().Next(0,10);
//     }
//     return array;
// }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("");
// int[,] masA=FillArray(m,n);
// PrintArray(masA);

// Console.WriteLine("");
// int[,] masB=FillArray(n,sb);
// PrintArray(masB);

// int[,] NewMas(int[,] masa, int[,] masb)
// {
//     int[,] masc = new int[masa.GetLength(0), masb.GetLength(1)];
//     for (int i = 0; i < masc.GetLength(0); i++)
//     {
//         for (int j = 0; j < masc.GetLength(1); j++)
//         {
//             int rez = 0;
//             for(int k = 0; k < masa.GetLength(1); k++)
//             {
//                 rez += masa[i, k] * masb[k, j];
//             }
//             masc[i, j] = rez;
//         }
//     }
//     return masc;
// }

// ;
// Console.WriteLine("");
// PrintArray(NewMas(masA, masB));


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Введите количество строк");
//  int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите глубину массива");
// int p = Convert.ToInt32(Console.ReadLine());

// int [,,] array = new int[m,n,p];

// void FillArr3(int [,,]array)
// {
//     int[] mas = new int[m * n * p];
//     int num = 0;
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         mas[i] = new Random().Next(10, 100);
//         num = mas[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (mas[i] == mas[j])
//                 {
//                     mas[i] = new Random().Next(10, 100);
//                     j = 0;
//                     num = mas[i];
//                 }
//                 num = mas[i];
//             }
//         }
//     }
//   int count = 0; 
//   for (int x = 0; x < m; x++)
//   {
//     for (int y = 0; y < n; y++)
//     {
//       for (int z = 0; z < p; z++)
//       {
//         array[x, y, z] = mas[count];
//         count++;
//       }
//     }
//   }
// }

// void PrintArr (int[,,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
     
//       for (int k = 0; k < array.GetLength(2); k++)
//       {
//         Console.Write( $"{array[i,j,k]}({i},{j},{k}) ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }
// FillArr3(array);
// PrintArr(array);  


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] matr = new int[4, 4];
// int i = 0;
// int j = 0;

//   for (int k =1; k<16; k++)
//   {
//     matr[i, j] = k;
//   if (i <= j + 1 && i + j < 3) j++;
//   else if (i < j && i + j >= 3) i++;
//   else if (i >= j && i + j > 3) j--;
//   else    i--;
//   }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i,j] / 10<=0)
//             Console.Write($"{image[i, j]} \t");
//             else Console.Write($"{image[i,j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// PrintArray(matr);