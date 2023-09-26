//                                     Задача №36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.



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

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int SumNegPos(int[] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i+=2)
    {
        sum +=arr[i];
    }
    return sum;
}

int[] arr = GenArray(123, 0, 1000);
PrintArray(arr);
int count = SumNegPos(arr);
PrintResult("Сумма элементов стоящих на нечетных позициях: "+count);
