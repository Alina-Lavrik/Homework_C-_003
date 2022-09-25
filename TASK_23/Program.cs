/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125   */

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());

for (int index = 1; index <= number; index ++)
{
    double result = Math.Pow(index, 3);
    Console.Write($"{result} ");
}
