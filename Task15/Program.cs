﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число:");

int number = Convert.ToInt32(Console.ReadLine());

if(number > 7 || number < 1)
{
    Console.WriteLine("В неделе только 7 дней!");
}

if(number >= 1 & number <= 5)
{
    Console.WriteLine("Нет.");
}

if(number == 6 || number == 7)
{
    Console.WriteLine("Да.");
}
