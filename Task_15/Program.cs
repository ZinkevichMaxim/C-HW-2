﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7");
int num = int.Parse(Console.ReadLine());

void int WeakDay(int num)

{if (num < 6)
{
    Console.WriteLine("Это будний день");
}
else if (num <= 7)
{
    Console.WriteLine("Сегодня выходной");
}
else
{
   Console.WriteLine("ВНИМАТЕЛЬНО! Введите число от 1 до 7"); 
}
}

