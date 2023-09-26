//                                     Задача №33
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.



// // Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine()??",";
//     int number = Convert.ToInt32(value);

//     return number;
// }

// // Проверяет, есть ли число
// string Check(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] == num)
//             return $"Есть, индекс {i}";
//     return "Нет";
// }

// // Выводит элементы массива в консоль
// void OutputArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//         Console.Write(array[i] + ", ");
//     Console.WriteLine(array[array.Length - 1] + "]");
// }


// int[] array = {1, -2, 5, 6, 58, 7, -3, -42, 63, 15};
// OutputArray(array);

// int element = Prompt("Введите число для поиска: ");

// Console.WriteLine(Check(array, element));



//Заполняем одномерный массив
int[] GenArray(int num, int lowBorder, int highBorder)
{

    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }

    return array;
}

// Печатаем результат
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");

    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Вводим данные
int ReadData(string msg)

{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Проверяет, есть ли число
string PrintData(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == num)
            return $"Есть, индекс {i}";
    return "Нет";
}

int FindElm(int[] arr, int elm)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elm)
        {
            return i;
        }
    }
    return -1;
}

int[] array=GenArray(12,-9,9);
int element = ReadData("Введите число для поиска: ");
PrintArray(array);
Console.WriteLine(PrintData(array, element));



