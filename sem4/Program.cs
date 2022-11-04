void SumNumbers(int x)
{
    int sum=0;
    for (int i =1; i<=x;i++) 
        sum=sum+i;
    Console.WriteLine($"Сумма всех чисел от 1 до {x} равна {sum}");
}

int SumNumbers2(int x)
{
    int sum=0;
    for (int i =1; i<=x;i++) 
        sum=sum+i;
    return sum;
}


Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
//SumNumbers(n);
Console.WriteLine(SumNumbers2(n));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите целое число A");
// int a = Convert.ToInt32(Console.ReadLine());

// void Sum(int x)
// {
//     int sum = 0;
//     int st = (int)Math.Log10(x)+1;
//     for (int i =1; i<=st;i++)
//         {    sum = sum+ x % 10;
//         x = x/10;   
//      }
// Console.WriteLine(sum);}
// Sum(a);

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// SumNumbers(num);
// int razryad=0;
// while (num % 10 >0)
// {
//     razryad++;
//     num/=10;
// }
// Console.WriteLine(razryad);

// void SumNumbers(int num)
// {
//     int razryad=0;
//     while (num % 10 >0)
//     {
//         razryad++;
//         num/=10;
//     }
//     Console.WriteLine(razryad);
// }
// Console.WriteLine("Введите число: ");
// int x=Convert.ToInt32(Console.ReadLine()) ;
// int a = (int)Math.Log10(x)+1;
// Console.WriteLine($"Число символов {a}");

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// void FillArray(int[] collection)
// {
//     int lenght = 8;
//     int index = 0;
//     while (index<8)
// {
//     collection[index] = new Random().Next(0,1);
//     index++;
// }
//  }
//  Console.WriteLine(collection);
//  int[] array = new int[8];
// for (int i=0; i<8; i++)
// {
// array [i] = new Random().Next(0,2);
// Console.Write(array[i]+" ");
// }

//  void PrintArray (int[]col)
// { 
//     int count = col.Length;
//     int position = 0;
//     while (position < count )
//     {Console.WriteLine(col[position]);
//     position ++;
//     }
// }
