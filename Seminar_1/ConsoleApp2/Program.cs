﻿/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница*/

Console.WriteLine("Введите целое число от 1 до 7");
int number = int.Parse(Console.ReadLine());

switch(number)
{
    case (1):
        Console.WriteLine("Понедельник");
        break;
    case (2):
        Console.WriteLine("Втонрник");
        break;
    case (3):
        Console.WriteLine("Среда");
        break;
    case (4):
        Console.WriteLine("Четверг");
        break;
    case (5):
        Console.WriteLine("Пятница");
        break;
    case (6):
        Console.WriteLine("Суббота");
        break;
    case (7):
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Такого дня недели не сууществует");
        break;
}
