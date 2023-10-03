using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
int rows = matrix.GetLength(0); int cols = matrix.GetLength(1);

for (int i = 0; i < rows; i++)
{
  for (int j = 0; j < cols; j++)
  {
    Console.Write(matrix[i, j] + "\t");
  }
  Console.WriteLine();
}

    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
int[,] matrix = new int[n, m]; int count = 1;

for (int i = 0; i < n; i++)
{
  for (int j = 0; j < m; j++)
  {
    matrix[i, j] = count;
    count += k;
  }
}

return matrix;

    }
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
    Console.Write("The averages in columns are: ");
    Console.WriteLine();
    foreach (double num in list) { Console.Write(num.ToString("0.00") + "\t"); } Console.WriteLine(); 

    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
int rows = matrix.GetLength(0); int cols = matrix.GetLength(1);

double[] averages = new double[cols];

for (int j = 0; j < cols; j++)
{
  double sum = 0;
  for (int i = 0; i < rows; i++)
  {
    sum += matrix[i, j];
  }
  averages[j] = sum / rows;
}

return averages;

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}
