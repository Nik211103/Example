


/*Напишите функцию, которая принимает массив рандомных чисел в заданом диапозоне и возвращает среднее значение этих чисел.*/
System.Console.WriteLine("Введите начало диапазона:");
int arg1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите конец диапазона:");
int arg2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите желаемую длину массива:");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size]; 

Random random = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = random.Next(arg1, arg2 + 1);
}

System.Console.WriteLine($"Сгенерированный набор чисел: {string.Join(", ", array)}");

double average = array.Average();
System.Console.WriteLine($"Среднее арифметическое данного цикла: {average}");

