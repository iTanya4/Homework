// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] FillArray(int m, int n)
// {
//     double[,] array = new double[m,n];
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j]= new Random().NextDouble()*100;
//     }
//     return array;
// }

// void PrintArray(double [,] image)
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

// double[,] mas=FillArray(m,n);
// PrintArray(mas);

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение элемента");
// int f = Convert.ToInt32(Console.ReadLine());

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
// int indi = 0;
// int indj = 0;
// bool find=false;
// for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         for (int j = 0; j < mas.GetLength(1); j++)
//         {
//         if (mas[i,j]==f)   
//             {
//              indi=i;
//              indj=j;
//              find = true;
//              break;
//              }   
//         }
//     }                
// if (find) Console.WriteLine($"число {f} есть в массиве, его индекс [{indi}, {indj}]");
// else Console.WriteLine("Такого числа нет в массиве");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
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

// Console.WriteLine();
// int[,] mas=FillArray(m,n);
// PrintArray(mas);
// for (int j = 0; j < mas.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         sum = sum +mas[i, j];
//     }
   
//     Console.Write($"Среднее арифметическое столбца {j+1} = { sum / m} \t");
//     Console.WriteLine();
// }


// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо
//  и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

Console.WriteLine("Введите количество строк"); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов"); 
int n = Convert.ToInt32(Console.ReadLine()); 
 
int[,] FillArray(int m, int n) 
{ 
 int[,] array = new int[m,n]; 
 for (int i=0;i<array.GetLength(0);i++) 
 { 
 for (int j=0;j<array.GetLength(1);j++) 
 array[i,j]= new Random().Next(0,10); 
 } 
 return array; 
} 
 
void PrintArray(int[,] image) 
{ 
 for (int i = 0; i < image.GetLength(0); i++) 
 { 
 for (int j = 0; j < image.GetLength(1); j++) 
 { 
 Console.Write($"{image[i, j]} \t"); 
 } 
 Console.WriteLine(); 
 } 
} 
 
int[,] mas=FillArray(m,n); 
PrintArray(mas); 
Console.WriteLine(); 

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
    
 
     int[] newarray = new int[m*n];

     for (int i = 0; i < mas.GetLength(1); i++)
     {
         for (int j = 0; j < mas.GetLength(0); j++)
             {
                for (int k= 0; k < newarray.Length; k++) 
                    {
                        //  mas[i, j] = newarray [k];
                        int perem = mas[i,j];
                        mas[i, j] = newarray [k];
                        newarray [k] = perem;
                                             }
             }

            SelectionSort(newarray); 
     }       
    void PrintAr (int[]col)
{ 
    int count = col.Length;
    int position = 0;
    while (position < count )
    {Console.Write($"{col[position]} ");
   
    if (((position)%(n+1)) == 0); Console.WriteLine (col[position]);
    }
    position ++;
    
}  
PrintAr(newarray);
    






// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. 
// Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно переместился на другое место
//  и выполнить это за m*n / 2 итераций. То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран
//   как таблицу.