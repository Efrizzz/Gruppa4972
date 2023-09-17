//                                     Задача №18
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

// 1) Ввести номер четверти
// 2) Ответить на вопрос
// 3) Вывести ответ


// Вывод сообщения и вызов метода CheckingCoordinates
// string Prompt(string message)
// {
//     Console.WriteLine(message);
//     string values = Console.ReadLine()??",";
//     int quarter = Convert.ToInt32(values);

//     return CheckingCoordinates(quarter);
// }

// // Проверка четверти
// string CheckingCoordinates(int quarter)
// {
//     switch(quarter)
//     {
//         case 1: return "(X > 0 ; Y > 0)";
//         case 2: return "(X < 0 ; Y > 0)";
//         case 3: return "(X < 0 ; Y < 0)";
//         case 4: return "(X > 0 ; Y < 0)";
//         default: return "0";
//     }
// }

// Console.WriteLine(Prompt("Введите номер четверти: "));

// int getQuarter()
// {
//     Console.Write("Введите номер четверти: ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// string pointsIdent(int quarterNum)
// {
//     if (quarterNum == 1) return "Возможные значения: X > 0, Y > 0";
//     if (quarterNum == 2) return "Возможные значения: X < 0, Y > 0";
//     if (quarterNum == 3) return "Возможные значения: X < 0, Y < 0";
//     if (quarterNum == 4) return "Возможные значения: X > 0, Y < 0";
//     return "Неверное значение";
// }

// int quarterNum = getQuarter();
// Console.WriteLine(pointsIdent(quarterNum));


int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string QuterBorderAsk(int numQut)
{
    if (numQut == 1) return "Возможные значения: X > 0, Y > 0";
    if (numQut == 2) return "Возможные значения: X < 0, Y > 0";
    if (numQut == 3) return "Возможные значения: X < 0, Y < 0";
    if (numQut == 4) return "Возможные значения: X > 0, Y < 0";
    return "Неверное значение";
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numQut = ReadData("Введите номер четверти: ");

PrintResult(QuterBorderAsk(numQut));

