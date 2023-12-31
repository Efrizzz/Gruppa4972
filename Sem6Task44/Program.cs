﻿// Задача №44
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



// Console.Clear();
// int n = ReadData("Введите количество чисел Фибоначчи (N): ");
// PrintFibonacciNumbers(n);

// //                                                     Методы
// //------------------------------------------------------------------------------------------------------------------
// // Ввод числа с клавиатуры
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Метод печати чисел Фибоначчи
// void PrintFibonacciNumbers(int n)
// {
//     int first = 0;
//     int second = 1;
//     int next = 0;

//     for (int i = 0; i < n; i++)
//     {
//         Console.Write(first + " ");
//         next = first + second;
//         first = second;
//         second = next;
//     }
// }



//Вводим данные
int ReadData(string msg)

{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Печатаем результат
void PrintFibNum(int num)
{
    int buf = 0;
    int first = 0;
    int second = 1;
    Console.Write(first + " " + second);
    for (int i = 2; i < num; i++)
    {
        Console.Write(" " + (first + second));
        buf = first + second;
        first = second;
        second = buf;
    }
}

int num = ReadData("Введите  число: ");
Console.Write("В системе Фибоначчи : ");
PrintFibNum(num);



