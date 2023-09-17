//                                     Задача №20
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// 1) ReadData
// 2) Calc2DDist
// 3) PrintResult


// double findDistance(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2));
// }

// int x1 = int.Parse(Console.ReadLine() ?? "0");
// int y1 = int.Parse(Console.ReadLine() ?? "0");
// int x2 = int.Parse(Console.ReadLine() ?? "0");
// int y2 = int.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine(findDistance(x1, y1, x2, y2));


// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// double Distance(int x,int y)
// {
//     double distance = Math.Sqrt(x*x+y*y);
//     return distance;
// }

// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// int x1 = ReadData("Введите координату x1: ");
// int y1 = ReadData("Введите координату y1: ");
// int x2 = ReadData("Введите координату x2: ");
// int y2 = ReadData("Введите координату y2: ");
// double res = Distance((x2-x1),(y2-y1));
// PrintResult("Расстояние равно " + $"{res}");


int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

double Calc2DDist(int x1,int x2, int y1, int y2)
{
    double res = Math.Sqrt((x1 - x2) * (x1 - x2)
    + (y1 - y2) * (y1 - y2));
    return res;
}

void PrintResult(string msg)

{
    Console.WriteLine(msg);
}

int x1 = ReadData("Введите координату x1: ");
int y1 = ReadData("Введите координату y1: ");
int x2 = ReadData("Введите координату x2: ");
int y2 = ReadData("Введите координату y2: ");

double res = Calc2DDist(x1, x2, y1 ,y2);

PrintResult("Расстояние между точками: "+res);


// для дз с 3 точками
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// double Calc3DDist(int x1,int x2, int y1, int y2, int z1, int z2)
// {
//     double res = Math.Sqrt((x1 - x2) * (x1 - x2)
//     + (y1 - y2) * (y1 - y2)
//     + (z1 - z2) * (z1 - z2));
//     return res;
// }

// void PrintResult(string msg)

// {
//     Console.WriteLine(msg);
// }

// int x1 = ReadData("Введите координату x1: ");
// int y1 = ReadData("Введите координату y1: ");
// int x2 = ReadData("Введите координату x2: ");
// int y2 = ReadData("Введите координату y2: ");
// int z1 = ReadData("Введите координату z1: ");
// int z2 = ReadData("Введите координату z2: ");

// double res = Calc2DDist(x1, x2, y1 ,y2);

// PrintResult("Расстояние между точками: "+res);

