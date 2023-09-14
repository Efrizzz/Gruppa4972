//                                     Задача 15
//  Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.


Console.WriteLine("Введите день недели");
string day = Console.ReadLine()??"0";

switch (day)
{
    case "1": Console.WriteLine("Этот день не выходной"); break;
    case "2": Console.WriteLine("Этот день не выходной"); break;
    case "3": Console.WriteLine("Этот день не выходной"); break;
    case "4": Console.WriteLine("Этот день не выходной"); break;
    case "5": Console.WriteLine("Этот день не выходной"); break;
    case "6": Console.WriteLine("Этот день выходной"); break;
    case "7": Console.WriteLine("Этот день выходной"); break;
    default: Console.WriteLine("Неверные данные"); break;
}
