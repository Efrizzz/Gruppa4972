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


