// for (int i=0; i<=10;i=i+2)
//     Console.Write($"{i} ");
// 
//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите координату x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y");
// int y = Convert.ToInt32(Console.ReadLine());
// string res;
// if (x>0 && y>0) res="Это первая четверть";
// else if  (x<0 && y>0) res="Это вторая четверть";
// else if  (x<0 && y<0) res="Это третья четверть";
// else if  (x>0 && y<0) res="Это четвертая четверть";
// else res = "точка находится на оси";
// Console.WriteLine(res);

// void CheckKoord(int x, int y)    //этот тип функции ничего не возвращает в основную программу, но что-то делает
// {
//     string res;
//     if (x>0 && y>0) res="Это первая четверть";
//     else if  (x<0 && y>0) res="Это вторая четверть";
//     else if  (x<0 && y<0) res="Это третья четверть";
//     else if  (x>0 && y<0) res="Это четвертая четверть";
//     else res = "точка находится на оси";
//     Console.WriteLine(res); 
// }

// try
// {
//     Console.WriteLine("Введите координату x");
//     int xx = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координату y");
//     int yy = Convert.ToInt32(Console.ReadLine());
//     CheckKoord(xx,yy);
// }
// catch 
// {
//     Console.WriteLine("Введены некорректные данные");
// }
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/
// catch
// {
//     Console.WriteLine("Вы ввели число некорhетный данные"); 
// }
// try
// {
// else Console.WriteLine("Вы ввели число некорhетный день недели");
// Console.WriteLine(res);


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату x1");
 int x1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите 
От Елена всем 09:50 PM
Console.WriteLine("Введите координаты x точки a");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки a");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x точки b");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки b");
int by = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
Console.WriteLine($"Расстояние между двумя точками равно  {dist}");
