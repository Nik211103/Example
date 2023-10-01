/*System.Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

int Sum(int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
        sum += i;
    }
    return sum;
}
System.Console.WriteLine($"Сумма числе от 1 до {A} равна {Sum(A)}");*/
/*void Mass(int col)
{
    int[] array = new int[col];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        System.Console.Write($"{array[i]} ");
    }

    System.Console.WriteLine("_______________________");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        System.Console.Write($"{array[i]} ");
    }
    
}
System.Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Mass(n);*/

/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/
/*int NumCount(int a)
{
    int count = 0;
    while (a > 0)
    {
        a/=10;
        count++;
    }
    return count;
}
System.Console.WriteLine($"Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Количество цифр в числе = {NumCount(a)}");*/

/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120*/
/*int Factorial(int n)
{
int fact = 1 ;
for (int i = 1; i <= n; i++)
{
fact*= i;
}
return fact;
}
Console.Write($"Введите число: ");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Факториал числа {a} = {Factorial(a)}");*/

/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/
 /*int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
        System.Console.Write($"{array[i]} ");
    }*/

/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*System.Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите числе B: ");
int B = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = 1;
if (B > 0)
{
    while (count <= B )
    {
        result *= A;
        count++;   
    }
System.Console.WriteLine($"Число {A} в степени {B} = {result}.");
}
else
{
    System.Console.WriteLine($"Число B должно быть больше нуля. Число которое вы ввели {B}");
}*/

/*Задача 27.Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
/*int NumCount(int a)
{
   
    int sum = 0;
    int b;
    while (a > 0)
    {
        b = a % 10;
        sum += b;
        a /= 10;
    }
    return sum;
}
System.Console.WriteLine($"Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр в числе = {NumCount(a)}");*/
    
/*Задача 29.Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
/*int Lenght = 8;
int[] array = new int [Lenght];
System.Console.WriteLine("Введите число min ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число max ");
int max = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
        System.Console.Write($"{array[i]} ");
    }*/

/*Написать программу, которая запрашивает у пользователя два числа и выводит на экран все числа между ними включительно.*/
/*System.Console.Write("Введите начало диапозона: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец диапозона: ");
int b = Convert.ToInt32(Console.ReadLine());

    for (int i = a; i <= b; i++)
    {
        System.Console.Write($"{i}, ");
    }
System.Console.Write("\b\b ");*/
    
/*string Method4(int count, string c)
{
    string result ="";
    for(int i = 0; i < count; i++)
    {
        result = result + c;
       
    }
    return result;
}
string res = Method4(10, "qwerty ");
System.Console.WriteLine(res);*/

/*for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i*j}.");
    }
}*/

/*string text = "- Я думаю, - сказал кнзяь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = "";

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result+ $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();

newText = Replace(text, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();

newText = Replace(text, 'с', 'С');
System.Console.WriteLine(newText);
System.Console.WriteLine();*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);