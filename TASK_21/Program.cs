/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53  */

Console.Write("Введите координаты точки X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y: ");
int Y = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Z: ");
int Z = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки X1: ");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y1: ");
int Y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Z1: ");
int Z1 = int.Parse(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(X1 - X, 2) + Math.Pow(Y1 - Y, 2) + Math.Pow(Z1 - Z, 2));  
Console.Write($"Расстояние между двумя точками в 3D пространстве равно {dist:f3}"); // :f3 - количество цифр после запятой
