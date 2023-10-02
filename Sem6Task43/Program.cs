//  Задача №43
//  Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-5,-5)



// // //(Задание со звездочкой) Найдите площадь треугольника образованного пересечением 3 прямых

// double K1 = ReadData("Input number K1: ");
// double B1 = ReadData("Input number B1: ");
// double K2 = ReadData("Input number K2: ");
// double B2 = ReadData("Input number B2: ");
// double K3 = ReadData("Input number K3: ");
// double B3 = ReadData("Input number B3: ");
// // Поиск координат пересечения
// (double x, double y) pointA = CrossPoint(K1, B1, K2, B2);
// (double x, double y) pointB = CrossPoint(K2, B2, K3, B3);
// (double x, double y) pointC = CrossPoint(K3, B3, K1, B1);

// double X1 = pointA.x;
// double Y1 = pointA.y;
// double X2 = pointB.x;
// double Y2 = pointB.x;
// double X3 = pointC.x;
// double Y3 = pointC.x;
// PrintData($"Cross points of 3 lines: X1= {X1}; Y1= {Y1}, X2= {X2}; Y2= {Y2}, X3= {X3}; Y3= {Y3}");
// double sideA = TriangleSide(X1, Y1, X2, Y2);
// double sideB = TriangleSide(X2, Y2, X3, Y3);
// double sideC = TriangleSide(X3, Y3, X1, Y1);
// PrintData($"The length of triangle sides: A= {sideA}; B= {sideB}, C= {sideC}");
// PrintData($"The square of triangle: S= {SquareTriangle(sideA, sideB, sideC)}");

// // Метод считывания введенных данных.
// double ReadData(string msg)
// {
//     Console.Write(msg);
//     return double.Parse(Console.ReadLine() ?? "0");
// }
// // Метод вывода данных.
// void PrintData(string msg)
// {
//     Console.WriteLine(msg);
// }
// // комплексный метод
// (double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
// {
//     double coorX1 = (b2 - b1) / (k1 - k2);
//     double coorY1 = (k1 * b2 - k2 * b1) / (k1 - k2);
//     return (coorX1, coorY1);
// }
// //Находим стороны треугольника, разбила на 3 отдельных метода, чтобы получить сразу переменные в double.
// double TriangleSide(double x1, double y1, double x2, double y2)
// {
//     double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
//     return result;
// }
// // Находим площадь треугольника через полумериметр (p=(a + b + c) / 2 )сторон и длины сторон.
// double SquareTriangle(double a, double b, double c)
// {
//     double squareT = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
//     return squareT;
// }



const int Coefficient = 0;
const int Constant = 1;
const int X = 0;
const int Y = 0;
const int Line1 = 1;
const int Line2 = 2;

double[] lineData1 = InputLineData(Line1);
double[] lineData2 = InputLineData(Line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords (lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y={lineData1[Coefficient]}*x+{lineData1[Constant]} и y={lineData2[Coefficient]}*x+{lineData2[Constant]}");
    Console.WriteLine($" Имеет координаты ({coord[X]},{coord[Y]})");
}

//Вводим данные
double ReadData(string msg)

{
    Console.WriteLine(msg); //вывести сообщение
    string value = Console.ReadLine() ?? "0"; //считывает с консоли строку
    double result = Convert.ToDouble(value); //преобразует строку в целое число
    return result; // возвращает результат
}

//Ввод данных по прямой
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[Coefficient] = ReadData($"Введите коэффициент для {numberOfLine}прямой: ");
    lineData[Constant] = ReadData($"Введите константу для {numberOfLine}прямой: ");
    return lineData;
}
//Поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X] = (lineData1[Constant] - lineData2[Constant]) / (lineData2[Coefficient] - lineData1[Coefficient]);
    coord[Y] = lineData1[Constant] * coord[X] + lineData1[Constant];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if(lineData1[Coefficient] == lineData2[Coefficient])
    {
        if(lineData1[Constant] == lineData2[Constant])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}


