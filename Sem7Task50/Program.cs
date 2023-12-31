﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру



// Решение задачи с *

using System.Numerics;

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
void Fibonacci2DArray(BigInteger[,] array)
{
    array[0, 0] = 0;
    array[0, 1] = 1;

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = i == 0 ? 2 : 0; j < array.GetLength(1); j++)
            if (j == 0) array[i, j] = array[i - 1, array.GetLength(1) - 1] + array[i - 1, array.GetLength(1) - 2];
            else if (j == 1) array[i, j] = array[i, j - 1] + array[i - 1, array.GetLength(1) - 1];
            else array[i, j] = array[i, j - 1] + array[i, j - 2];
}
// Выводит элементы массива в консоль (Метод генерации чисел Фибоначчи)
void Output2DArray(BigInteger[,] array, string message, int[] elementPosition)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (i == elementPosition[0] && j == elementPosition[1])
                Console.ForegroundColor = ConsoleColor.Green;

            Console.Write(array[i, j]);
            Console.ResetColor();
            Console.Write(",\t ");
        }

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }
}

BigInteger[,] array = new BigInteger[5, 5];
int[] elementPosition = {-1, -1};
Fibonacci2DArray(array);
Output2DArray(array, "Массив: ", elementPosition);

elementPosition[0] = Prompt("Введите x (индекс первого элемента 0): ");
elementPosition[1] = Prompt("Введите y (индекс первого элемента 0): ");

if (elementPosition[0] < array.GetLength(0) && elementPosition[1] < array.GetLength(1))
    Output2DArray(array, "Массив: ", elementPosition);
else Console.WriteLine("Элемента в массиве нет.");



// Решение обычной задачи

// using System;

// public class Answer {
//     public static void PrintArray (int [,] matrix)
//     {
//         for (int i=0; i<matrix.GetLength(0); i++)
//         {
//             for (int j=0; j<matrix.GetLength(1);j++)
//             {
//                 Console.Write($"{matrix[i,j]}"+"\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//         int[,] newMatrix = new int[n,m];
//         int currentValue = 1;
//         for (int i=0; i<n; i++)
//         {
//             for (int j=0; j<m; j++)
//             {
//                 newMatrix[i,j] = currentValue;
//                 currentValue += k;
//             }
//         }
//         return newMatrix;
//     }

//     public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
//     {  
//         int [] number={0,-1};
//         if ((rowPosition-1) > 0 && (rowPosition-1)<=matrix.GetLength(0) && (columnPosition-1) > 0 && (columnPosition-1)<=matrix.GetLength(1) )
//         {
//             number[1]=0;
//             number[0]=matrix[rowPosition-1,columnPosition-1];
//             return number;
//         }
//         return number;
//     }

//     public static void PrintCheckIfError (int[] results, int X, int Y)
//     {
//         if (results[1]==-1){Console.WriteLine("There is no such index");}
//         else {Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//         }
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int n, m, k, x, y;

//         if (args.Length >= 5) {
//            n = int.Parse(args[0]);
//            m = int.Parse(args[1]);
//            k = int.Parse(args[2]);
//            x = int.Parse(args[3]);
//            y = int.Parse(args[4]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            n = 4;
//            m = 5;
//            k = 3;
//            x = 2;
//            y = 2;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
//     }
// }


