﻿// Задача 4: Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1");
int numA = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите число 2");
int numB = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите число 3");
int numC = int.Parse(Console.ReadLine()??"0");
int max = numA;
if (numB > max)
{
    max = numB;
}
if (numC > max)
{
    max = numC;
}
Console.WriteLine("Максимальное число: " + max);





