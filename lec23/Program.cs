// int Max(int arg1,  int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2>result) result = arg2;
//     if (arg3>result) result = arg3;
//     return result;
// }

// int[] array = {11,21 ,31, 41, 15 ,61, 17,18,};
// int  n = array.Length;
// int find = 18
// int index = 0;
// while (index<n)
// {
//     if (array[index]==find)
// {Console.WriteLine(index);
// break;
// }
// index++;}
// 
// void FillArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index<lenght)
// {
//     collection[index] = new Random().Next(1,10);
//     index++;
// }
//  }

// void PrintArray (int[]col)
// { 
//     int count = col.Length;
//     int position = 0;
//     while (position < count )
//     {Console.WriteLine(col[position]);
//     position ++;
//     }
// }
// int []array = new int [10]; // новый массив в котором 10 элементов
// FillArray(array);
// PrintArray(array);


// void FillArray(int[] collection)
// void PrintArray(int[] col);
// int Index0f(int [] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = 0;
//     while (index<count)
// {
//     if (collection[index] == find)
//     {position = index;
//     break;
//     }
    
//     index++;}
//     return position;
// }
// void PrintArray (int[]col)
// { 
//     int count = col.Length;
//     int position = 0;
//     while (position < count )
//     {Console.WriteLine(col[position]);
//     position ++;
//     }
// }
// int []array = new int [10]; // новый массив в котором 10 элементов
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// int pos = Index0f(array, 4);
// Console.WriteLine(pos);

// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum=0;
// for (int i =1; i<=n;i++) sum=sum+i;
// Console.WriteLine($"Сумма всех чисел от 1 до {n} равна {sum}");


// Лекция 3
// string Method4 (int count, string c)
// {

//     int i =0;
//     string result = String.Empty;
//     while (i<count)
//     result = result + text;
// }
// return result;
// for (int i=2; i<10; i++)
//         for (int j=2; j<=10;j++)
//         {Console.WriteLine ($"{i} х {j} = {i*j}");
//         }
//         Console.WriteLine();

// string res = Method4(10,"z");
// Console.WriteLine (res);

// string Replace (string text, char oldValue, char newValue)

// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// // Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// // сумма отрицательных равна -20.

// int[] CreateFillArray()

// {
//     int[] arr = new int[12];
//     for (int i=0;i<12;i++) 
//     {
//         arr[i]= new Random().Next(-9,10);
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
//     return arr;
// }

// void FindSums(int[] arr)
// {
//     int sumP=0;
//     int sumN=0;
//     foreach (int el in arr)
//     {
//         if (el>=0) sumP=sumP+el;
//         else sumN=sumN+el;
//     }
//     Console.WriteLine($"Сумма положительных чисел равна {sumP}");
//     Console.WriteLine($"Сумма отрицательных чисел равна {sumN}");
// }

// int[] mas = CreateFillArray();
// FindSums(mas);

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] arr = {-4, -8, 8, 2};

// for (int i=0;i<4;i++)
//     {arr [i] = 0-arr[i];
//     Console.Write($"{arr[i]}  ");
//     }


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> д

// int[] arr = {6, 7, 19, 345, 3};
// foreach (int el in arr)
// {
//     Console.Write($"{el} ");
// }
// Console.WriteLine();
// Console.WriteLine("Введите искомое число");
// int x = Convert.ToInt32(Console.ReadLine());
// bool find=false;
// for (int i=0; i<5;i++)
//     {
//         if (arr [i]==x)
//         {
//             find=true;
//             break;
//         }
//     }

// if (find) Console.WriteLine("Данное число есть в массиве");
// else Console.WriteLine("Такого числа нет в массиве");

// Задача 35: Задайте одномерный массив из 13 случайных чисел от 0 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [40,99]. 
//  int []array = new int [13];
// void FillArray(int[] collection)
// {
//     int lenght = 13;
//     int index = 0;
//     while (index<lenght)
// {
//     collection[index] = new Random().Next(0,101);
//     index++;
// }
//  }
//  void PrintArray (int[]array)
// { 
//     int count = 13;
//     for (int i=0; i<count;i++)
//     {Console.Write($"{array[i] }  ");
//        }
// }
// FillArray (array);
// PrintArray (array);
// //  for (int i=0; i<13;i++)
// //    { if (array[i]>40 && array[i]<100)
//     int count = 0;
   
// for (int i=0; i<13;i++)
//     {
//         if (array[i]>39 && array[i]<100)
//         {
      
//             count++;
//         }
//     }

// // if (find) 
// Console.WriteLine("    ");
// Console.WriteLine(count);



 // Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
// int [] array = new int [11];
// void FillArray(int[] collection)
// {
//    int  lenght = collection.Length;
//     int index = 0;
//     while (index<lenght)
// {
//     collection[index] = new Random().Next(0,10);
//     index++;
// }
//  }
 void PrintArray (int[]array)
{ 
    int count = array.Length;
    for (int i=0; i<count;i++)
    {Console.Write($"{array[i] }  ");
       }
Console.WriteLine("  ");
}
// FillArray (array);
// PrintArray (array);
// int prod = 1;
// for (int i=0;i<12; i++);
// {}

//          поиск максимального и минимального элемента
// void FindMax(int[] arr)
// {
//     int max=arr[0];
//     foreach (int el in arr)
//     {
//         if (el>max) max=el;
//             }
//     Console.WriteLine("    ");
//     Console.WriteLine($"Максимальный элемент массива {max}");
  
// }

// void FindMin(int[] arr)
// {
//     int min=arr[0];
//     foreach (int el in arr)
//     {
//         if (el<min) min=el;
//             }
//     Console.WriteLine("    ");
//     Console.WriteLine($"Минимальный элемент массива {min}");
// }

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void SelectionSort (int []array)
{
    for (int i=0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j<array.Length; j++)
            {if(array[j]< array[minPosition]) minPosition = j;
            }
        int temp = array[i];
        array[i]= array[minPosition];
        array [minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort (arr);

PrintArray(arr);