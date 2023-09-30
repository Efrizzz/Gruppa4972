// Задача №41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



//   Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//   (*) Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.


// using System.Text.RegularExpressions;
// Console.Clear();

// int numOfKeyPresses = ReadInt("Введите количество нажатий: ");  // Ввод пользователем количества нажатий.
// string data = KeyPresses("Введите строку: ", numOfKeyPresses);  // Получение нажатий с клавиатуры.
// //Console.WriteLine(data);
// int count = CountPositiveNumbers(data);                         // Подсчет положительных чисел в строке.
// PrintResult($"\nВведено чисел больше нуля: {count}");           // Вывод результата в консоль.

// //                                                     Методы
// //------------------------------------------------------------------------------------------------------------------

// // Ввод целого числа с клавиатуры.
// int ReadInt(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Получение нажатий с клавиатуры.
// string KeyPresses(string msg, int numOfKeyPresses)
// {
//     Console.Write(msg);
//     string data = string.Empty;
    
//     for (int i = 0; i < numOfKeyPresses; i++)
//     {
//         var keyInfo = Console.ReadKey();
//         data += keyInfo.KeyChar;
//     }

//     return data;
// }

// // Подсчет положительных чисел в строке с использованием регулярных выражений.
// int CountPositiveNumbers(string input)
// {
//     string pattern = @"[-]?[0-9]+";
//     MatchCollection matches = Regex.Matches(input, pattern);

//     int count = 0;
//     foreach (Match match in matches)
//     {
//         if (int.Parse(match.Value) > 0) { count++; }
//     }
//     return count;
// }

// // Вывод результата в консоль.
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }



//Вводим данные
int ReadData(string msg)

{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//Записываем числа в массив
int[] InputArray(int length)
{
    int[]array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadData($"Введите {i + 1}-й элемент");
    }
    return array;
}
//Выводим массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}
// Считаем кол-во чисел больше 0
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count ++;
        }
    }
    return count;
}

int length = ReadData("Введите количество элементов: ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");


