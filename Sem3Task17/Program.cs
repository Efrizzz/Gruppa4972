//                                     Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём х ≠ 0 и y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// 1) Ввести x
// 2) Ввести y
// 3) Поиск ответа
// 4) Вывести результат
// Решаем задачу через методы:
// Метод 1

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// Метод 2

// По координатам точки определяем номер четверти

int QuterTest(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
// Метод 3

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}


int x = ReadData("Введите координату X: ");
int y = ReadData("Введите координату Y: ");

int res = QuterTest(x, y);

PrintResult("Точка находится в четверти № "+res);

