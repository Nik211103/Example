/*Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-9, 10) + Math.Round(new Random().NextDouble(),2);
    }
}

void PrintArr(double[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arry[i, j]}\t");
        }
        System.Console.WriteLine("");
    }
}
PrintArr(arr);*/

/*Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-9, 10) + Math.Round(new Random().NextDouble(),2);
    }
}

void PrintArr(double[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //System.Console.Write(string.Format("{0:0.00}\t", arry[i, j])); 
            System.Console.Write($"{arry[i, j]:f2}\t");
        }
        System.Console.WriteLine("");
    }
}
PrintArr(arr);*/



/*Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];
int count = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = count;
        count ++;
    }
}

void PrintArr(double[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arry[i, j]}\t");
        }
        System.Console.WriteLine("");
    }
}
PrintArr(arr);*/

/*Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-9, 10);
    }
}

void PrintArr(double[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //System.Console.Write(string.Format("{0:0.00}\t", arry[i, j])); 
            System.Console.Write($"{arry[i, j]}\t");
        }
        System.Console.WriteLine("");
    }
}
PrintArr(arr);
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if((i % 2 == 1) && (j % 2 == 1))
        {
            arr[i, j] = Convert.ToInt32(Math.Pow(arr[i, j], 2));
        }
    }
}
System.Console.WriteLine();
PrintArr(arr);*/


/*Задача 51:Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/


/*Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-9, 10);
    }
}

void PrintArr(double[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //System.Console.Write(string.Format("{0:0.00}\t", arry[i, j])); 
            System.Console.Write($"{arry[i, j]}\t");
        }
        System.Console.WriteLine("");
    }
}

PrintArr(arr);

double sum = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if(i == j)
        {
            sum += arr[i, j];
        }
    }
}
System.Console.WriteLine(sum);*/


/*using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]}\t");
            }
            Console.WriteLine();
        }
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] matrix = new int[n,m];
        int num = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i,j] = num;
                num += k;
            }
        }
        return matrix;
    }
  
   public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
{  
    if (rowPosition < 0 || rowPosition >= matrix.GetLength(0) || columnPosition < 0 || columnPosition >= matrix.GetLength(1))
    {
        return new int[] {0, 1};
    }
    else
    {
        return new int[] {matrix[rowPosition, columnPosition], 0};
    }
}

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
        if (results[1] == 0)
        {
            Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        }
        else
        {
            Console.WriteLine("There is no such index");
        }
    }

    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
           x = 2;
           y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}*/