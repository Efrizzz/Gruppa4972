//                                     Задача 13
//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


// int Getnum()
// {
//     return Convert.ToInt32(Console.ReadLine());
// }
// Получаем число и номер разряда
// Console.Write("Введите число: ");
// int num = Getnum();
// Console.Write("Введите номер разряда: ");
// int digit = Getnum();
// // Метод для получения числа искомого разряда
// int GetDigit(int num, int numOfDigit)
// {
//     while (num > Math.Pow(10, numOfDigit))
//     {
//         num /= 10;
//     }
//     return num = num % 10;

// }
// Console.WriteLine(num > Math.Pow(10, digit -1) ? "Число меньше" : GetDigit(num, digit));


// Console.Write("Введите число: ");
// string line = Console.ReadLine()??"0";
// char[] digits = line.ToCharArray();
// if (line.Length > 2){
//    Console.WriteLine(digits[2]);
// }
// else {
//     Console.WriteLine("Третьей цифры нет");
// }

    // Получим элемент по ключу == day


// Console.Clear();                     // Очистка терминала
// int number, numberLenght;            // Обьявление целочисленной переменной для числа и длины числа
// int index = 3;                       // Задаем индекс интересующей для вывода цифры (по условию это 3)

// // Ввод числа пользователем
// Console.Write("Введите положительное целое число, длина которого  не превышает 10 цифр: ");
// while ((!(int.TryParse(Console.ReadLine(), out number))) || (!(number >= 0 && (numberLenght = (int)Math.Floor(Math.Log10(number) +1)) <=10)))
// { Console.Write("Неверный формат числа, попробуйте еще раз: "); }

// // Проверка наличия третьей цифры в числе и вывод результата
// Console.Write (numberLenght >= 3
//                ? number + " -> " + (number / (int)Math.Pow(10, numberLenght - index)) % 10
//                : "Третья цифра в числе отсутствует");


// Console.WriteLine("Введите число");
// long number = long.Parse(Console.ReadLine()??"0";

// // Проверяем, чтобы было 3 и больше цифры в числе
// if (number > 100)
// {
//     Console.WriteLine("Число имеет меньше 3 цифр.");
// }
// else
// {
//     // Инициализируем массив чисел
//     long[] temp = new long[10];
//     // Инициализируем дополнительные переменные - флаги
//     int i = 1;
//     long j = 100;
//     long k = 10;
//     int thirdNumber = -2;
//     // Раскладываем число на цифры с помощью дополнительных переменных
//     temp[0] = number % 10;
//     number -= number % 10;
//     do
//     {
//         temp[i] = (number % j) / k;
//         number -= (number % j);
//         i++;
//         j *= 10;
//         k *= 10;
//         thirdNumber++;
//     } while (!(number == 0));

//     Console.WriteLine("Третья цифра: " + temp[thirdNumber]);
// }


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
double digit = Math.Log10(num);
digit = (int)digit;
if (digit > 1){
    int count = 1;
    int res = num;
    while (count < digit -1){
        res = res/10;
        count++;
    }
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.Write(", равняется: ");
    Console.WriteLine(res%10);
}
else{
   Console.Write("Третья цифра в числе: ");
   Console.Write(num);
   Console.WriteLine(", отсутствует");
}


