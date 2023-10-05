

using System;
// using System;
// using System.Numerics;
// string [, ] table = new string[2, 5];
// table[1, 2] = "слово";
// for( int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//         System.Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }



// void PrintArray(int[, ] matr)
// {
//     for( int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write($"{matr[i ,j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }
// void FillArray(int[, ] matr)
// {
//     for( int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//            matr[i, j] = new Random().Next(1,10);
//         }
//         System.Console.WriteLine();
//     }
// }
// int[, ] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// System.Console.WriteLine();
// PrintArray(matrix);

/*int[, ] pic = new int[, ]
{
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for(int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i, j] == 0) System.Console.Write($" ");
            else System.Console.Write($"+");
        }
        System.Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);

    }
}
PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);*/

/*double Fact(int n)
{
    if(n == 1) return 1;
    else return n * Fact(n - 1);
}
    for (int i = 1; i < 40; i++)
    {
        System.Console.WriteLine($" {i}! = {Fact(i)}");
    }*/

// double Fib(int n)
// {
//     if(n ==1 || n == 2) return 1;
//     else return Fib(n-1) + Fib(n - 2);
// }
// for(int i = 1; i < 10; i++)
// {
//     System.Console.WriteLine($"{i} = {Fib(i)}");
// }

/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
 0, 7, 8, -2, -2 -> 2
 1, -7, 567, 89, 223-> 3*/


/*Console.WriteLine("Введите количество чисел:");
int M = Convert.ToInt32(Console.ReadLine());

int count = 0;
Console.WriteLine("Введите числа:");
for (int i = 0; i < M; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        count++;
    }
}

Console.WriteLine("Количество чисел больше 0 = " + count);*/

/*int[] Count(int M)
{
    int[] numbers = new int[M];
    int countPositive = 0;
    int countNegative = 0;

    Console.WriteLine("Введите числа:");
    for (int i = 0; i < M; i++)
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        if (numbers[i] > 0)
        {
            countPositive++;
        }
        else if (numbers[i] < 0)
        {
            countNegative++;
        }
    }

    int[] result = { countPositive, countNegative };
    return result;
}

Console.WriteLine("Введите количество чисел:");
int M = Convert.ToInt32(Console.ReadLine());
int[] result = Count(M);
Console.WriteLine("Количество чисел больше 0: " + result[0]);
Console.WriteLine("Количество чисел меньше 0: " + result[1]);*/