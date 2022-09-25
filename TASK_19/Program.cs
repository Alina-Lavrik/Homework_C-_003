/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да    */


Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int num1 = number % 10;
int num2 = number / 10000;
int num3 = (number / 10) % 10;
int num4 = (number / 1000) % 10;

if (num1 == num2 && num3 == num4)
{
    Console.Write($"Число является палиндромом ");
}
else
{
    Console.Write($"Число не является палиндромом ");
}