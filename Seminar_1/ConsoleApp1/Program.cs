﻿/* Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет */

Console.Write("Введи первое число:");
int number = int.Parse(Console.ReadLine());

Console.Write("Введи второе число:");
int number_2 = int.Parse(Console.ReadLine());

int number_3 = number_2 * number_2;

if (number_3 == number)
{
    Console.WriteLine("Первое число является кваратом второго");
}
else
{
    Console.WriteLine("Первое число не является кваратом второго");
}