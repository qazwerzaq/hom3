﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine ("Введите число : ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine($"{number} чётное");
}
else
{
    System.Console.WriteLine($"{number} нечётное");
}
