﻿

/*for (int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i*j}");
    }
    System.Console.WriteLine();
}*/

/*string text = "- Я думаю, - сказал кнзяь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');

System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(text, 'к', 'К');
System.Console.WriteLine(newText);*/

/*int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i ++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] > array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);*/