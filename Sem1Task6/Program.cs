﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "0");
int rem = num % 2;
if (rem == 0)
{
    Console.WriteLine("Да: " + num);
}
else
{
    Console.WriteLine("Нет: " + num);
}