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

