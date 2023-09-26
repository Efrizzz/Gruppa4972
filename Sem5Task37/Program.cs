//                                     Задача №37
// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.



int[] GenArray(int num, int lowBorder, int highBorder)
{
    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }

    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
    System.Console.Write(arr[arr.Length - 1] + " ]");
}

int[] ConvertArr(int[] arr)
{
    int[] outArr = new int[arr.Length/2];

    for (int i = 0; i < arr.Length/2; i++)
    {        
        outArr[i] = arr[i] * arr[arr.Length -1 - i];
    }

    return outArr;
}

int[] arr = GenArray(12, -9, 9);
PrintArray(arr);
PrintArray(ConvertArr(arr));

