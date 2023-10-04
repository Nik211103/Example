/*int[] GerAraay(int size, int min, int max)
{
    int[] res = new int[size];
    for( int i =0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
        System.Console.Write($"{res[i]}, ");
    }
    System.Console.WriteLine("\b\b ");
    System.Console.WriteLine();
    return res;
}
Console.WriteLine("Введите число элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите минимальный элемент массива ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите максимальный элемент массива ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = GerAraay(n, min, max);

int sumPos = 0;
int sumNeg = 0;

 for( int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPos += arr[i];
        else sumNeg += arr[i];
    }
System.Console.WriteLine($"Сумма положительных = {sumPos}");
System.Console.WriteLine($"Сумма отрицательных = {sumNeg}");*/

/*int[] GerAraay(int size, int min, int max)
{
    int[] res = new int[size];
    for( int i =0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
        System.Console.Write($"{res[i]}, ");
    }
    System.Console.WriteLine("\b\b ");
    
    return res;
}
Console.WriteLine("Введите число элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите минимальный элемент массива ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите максимальный элемент массива ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = GerAraay(n, min, max);

for(int i = 0; i < arr.Length; i++)
{
    arr[i] *=-1;
    System.Console.Write($"{arr[i]}, ");
}
System.Console.Write("\b\b ");*/

/*int[] GerArray(int size, int min, int max)
{
    int[] res = new int[size];
    System.Console.Write("[");
    for( int i =0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
        System.Console.Write($"{res[i]}, ");
    }
    System.Console.WriteLine("\b\b]");
    
    return res;
}
Console.WriteLine("Введите число элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите минимальный элемент массива ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите максимальный элемент массива ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = GerArray(n, min, max);
bool ChekArray(int num, int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(Math.Abs(array[i]) == Math.Abs(num))
        {
            return true;
        }
    }
    return false;
}
System.Console.WriteLine(ChekArray(-3, arr));*/

/*1 задача
public class Answer
{
    public static int CountEvenElements(int[] array)
    { 
    // Введите свое решение ниже
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenCount++;
        }
    }
    return evenCount;
    
    }
    private static void PrintArray(int[] array)
    {
        // Введите свое решение ниже
        for (int i = 0; i < array.Length; i++)
        {
           System.Console.Write($"{array[i]}\t");
        }
        System.Console.WriteLine("");
    }
    

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
} */
    
// Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
// Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает сумму элементов с нечетными индексами в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// Аргументы, передаваемые в метод/функцию:

//2 задача
/*using System;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1)
            {
                sum = sum + array[i];
            }
        }
        return sum;
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}\t");
        }
        Console.WriteLine("");
    }

    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}*/

// Напишите программу для работы с массивом вещественных чисел.
// Реализуйте класс ArrayOperations, который содержит следующие статические методы:
// FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.
// FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.
// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array
// и возвращает разницу между максимальным и минимальным числами в массиве.
// PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array 
//и выводит его элементы с двумя знаками после запятой через табуляцию.

/*using System;

public class ArrayOperations
{
    public static double FindMax(double[] array)
    {
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    public static double FindMin(double[] array)
    {
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {
        double max = array[0];
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return max - min;
    }

    public static void PrintArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]:f2}\t");
        }
        Console.WriteLine();
    }
}

public class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        ArrayOperations.PrintArray(array);
        double diff = ArrayOperations.CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}*/