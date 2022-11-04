//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Console.WriteLine("Введите длину массива");
// int length = Convert.ToInt32(Console.ReadLine());
//  int []array = new int [length];
//  void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index<length)
// {
//     collection[index] = new Random().Next(100,999);
//     index++;
// }
//  }

// void PrintArray (int[]col)
// { 
//     int count = col.Length;
//     int position = 0;
//     while (position < count )
//     {Console.Write($"{col[position]} ");
//     position ++;
//     }
// }
// FillArray(array);
// PrintArray(array);
// int count = 0;
// for (int i = 0; i < length; i++)
//     if (array[i] % 2 == 0)
//     count++;
// Console.WriteLine("    ");
// Console.WriteLine($"{count} четных чис.");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите длину массива");
// int length = Convert.ToInt32(Console.ReadLine());
//  int []array = new int [length];
//  void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index<length)
// {
//     collection[index] = new Random().Next(-20,20);
//     index++;
// }
//  }

// void PrintArray (int[]col)
// { 
//     int count = col.Length;
//     int position = 0;
//     while (position < count )
//     {Console.Write($"{col[position]} ");
//     position ++;
//     }
// }
// FillArray(array);
// PrintArray(array);
// int sum = 0;
// for (int i = 1; i < length; i=i+2)
//     sum = sum + array[i];     
// Console.WriteLine("    ");
// Console.WriteLine($"сумма элементов, стоящих на нечетных позициях = {sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
double []array = new double [length];
 void FillArray(double[] collection)
{
    int lenght = collection.Length;
    for (int i =0; i<lenght;i++)
{
    Console.WriteLine($"Введите элемент {i}");
    
    collection [i]= Convert.ToDouble(Console.ReadLine());
    
}
 }
  void PrintArray (double[]col)
{ 
    int count = col.Length;
    int position = 0;
    while (position < count )
    {Console.Write($"{col[position]}  ");
    position ++;
    }
}
 FillArray(array);
PrintArray(array);
double max = array[0];
for(int i=1;i<length;i++)
   { if (array[i]>max)
    {max = array[i];}
      }
Console.WriteLine("    ");
Console.WriteLine($"максимальное значение элемента = {max}"); 

double min = array[0];
for(int i=1;i<length;i++)
   { if (array[i]<min)
    {min = array[i];}
      }
Console.WriteLine("    ");
Console.WriteLine($"минимальное значение элемента = {min}"); 
Console.WriteLine("    ");
Console.WriteLine($"разница между максимальным и минимальным элементом массива = {max-min}"); 


// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

//  Console.WriteLine("Введите длину массива");
// int length = Convert.ToInt32(Console.ReadLine());
//  int []array = new int [length];
//  void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index<length)
// {
//     collection[index] = new Random().Next(0,30);
//     index++;
// }
//  }

// void PrintArray (int[]col)
// { 
//     int count = col.Length;
//     int position = 0;
//     while (position < count )
//     {Console.Write($"{col[position]} ");
//     position ++;
//     }
//     Console.WriteLine("  ");
// }
// FillArray(array);
// PrintArray(array);
// int max = array[0];
// int imax = 0;
// for(int i=1;i<length;i++)
//    { if (array[i]>max)
//     {max = array[i];
//         imax=i;
//         }
//       }
// Console.WriteLine("    ");
// Console.WriteLine($"максимальное значение элемента = {max}, его индекс {imax}"); 

// int min = array[0];
// int jmin = 0;
// for(int j=1;j<length;j++)
//   { if (array[j]<min)
//     {min = array[j];
//         jmin=j;}
//       }
// Console.WriteLine("    ");
// Console.WriteLine($"минимальное значение элемента = {min}, его индекс {jmin}");

// int AverageArray (int[]arr)
// { 
//     int lenght = arr.Length;
//     int sum = 0;
//     int aver = 0;
//     for (int num = 0; num<lenght;num++)
//         {sum = sum+arr[num];
//         aver = sum/(num+1);
//         }
// return aver;
//     }
// Console.Write($"среднее арифметическое {AverageArray(array)} ");
// Console.WriteLine("   ");
// int[] newarray = {max, imax, min, jmin, AverageArray(array)};
// PrintArray(newarray);

// void SelectionSort (int []array)
// {
//     for (int i=0; i < array.Length-1; i++)
//     {
//         int minPosition = i;
//         for (int j = i+1; j<array.Length; j++)
//             {if(array[j]< array[minPosition]) minPosition = j;
//             }
//         int temp = array[i];
//         array[i]= array[minPosition];
//         array [minPosition] = temp;
//     }
// }
// SelectionSort(array);
// int median = 0;
// int index1 = length/2;
// int index2 = ((length-1)/2) + (length/2);
// if (length%2!=0) median = array[index1];
// else median = array[index2];
// Console.WriteLine($"медиана первого массива {median}");