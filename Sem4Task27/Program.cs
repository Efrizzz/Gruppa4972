//                                     Задача №27
// Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.


// // 1)ReadData
// // 2)PrintResult
// // 3)SumDigit


// //Вводим данные
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// //Печатаем результат
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }
// //Метод сложения цифр в числе
// int SumDigit(int num)
// {
//     int res = 0;
//     while (num > 0)
//     {
//         res +=num%10;
//         num /=10;
//     }
//     return res;
// }

// int num = ReadData("Введите число: ");

// int res = SumDigit(num);

// PrintResult($"Сумма чисел в числе = {res}");




//   Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//   * Сделать оценку времени алгоритма через вещественные числа и строк

int number = ReadData("Введите целое число: "); // Ввод числа с клавиатуры

CalculateAndPrintSum("Метод деления", number, SumDigitDiv); // Сумма методом деления
// CalculateAndPrintSum("Метод строки", number, SumDigitStr);  // Сумма методом строки



// Ввод данных с клавиатуры
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Вывод результата
void CalculateAndPrintSum(string methodName, int number, Func<int, int> calculator)
{
    DateTime startTime = DateTime.Now;
    int sum = calculator(number);
    TimeSpan executionTime = DateTime.Now - startTime;
    Console.WriteLine($"\n{methodName}:\nСумма цифр числа {number} = {sum}\nВремя исполнения {executionTime}");
}

// Вычисление суммы цифр через вещественные числа
int SumDigitDiv(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

//Вычисление суммы цифр через строку
int SumDigitStr(int number)
{
    string numberStr = number.ToString();
    int result = 0;

    foreach (char digitChar in numberStr) { result += int.Parse(digitChar.ToString()); }
    return result;
}


