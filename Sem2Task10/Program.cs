﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Write("Введи трёхзначное число: ");
string stringNum = Console.ReadLine()??"0";
int num = Convert.ToInt32(stringNum);
Console.WriteLine("вторая цифра этого числа: "+stringNum[1]);








