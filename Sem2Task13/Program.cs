//                                     Задача 13
//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// double digit = Math.Log10(num);
// digit = (int)digit;
// if (digit > 1){
//     int count = 1;
//     int res = num;
//     while (count < digit -1){
//         res = res/10;
//         count++;
//     }
//     Console.Write("Третья цифра в числе: ");
//     Console.Write(num);
//     Console.Write(", равняется: ");
//     Console.WriteLine(res%10);
// }
// else{
//    Console.Write("Третья цифра в числе: ");
//    Console.Write(num);
//    Console.WriteLine(", отсутствует");
// }
Console.Write("Введите число: ");
string line = Console.ReadLine()??"0";
char[] digits = line.ToCharArray();
if (line.Length > 2){
   Console.WriteLine(digits[2]);
}
else {
    Console.WriteLine("Третьей цифры нет");
}

