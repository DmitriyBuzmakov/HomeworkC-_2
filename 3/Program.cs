﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите цифру дня недели: ");
int a = int.Parse(Console.ReadLine());
if (a >= 1 && a <= 5)
    Console.Write("Рабочий день недели. Не является выходным днём.");
if (a == 6 | a == 7)
    Console.Write("Является выходным днём.");
if (a > 7 | a < 1)
    Console.Write("Неверно введён день недели.");  