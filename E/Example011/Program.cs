/*System.Console.WriteLine("Введите число четверти координаты:");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
    {
        System.Console.WriteLine("x > 0, y > 0");
        break;
    }

    case 2:
    {
        System.Console.WriteLine("x < 0, y > 0");
        break;
        }
    case 3:
    {
        System.Console.WriteLine("x < 0, y < 0");
        break;       
        }
    case 4:
    {
        System.Console.WriteLine("x > 0, y < 0");
        break;
        }
    default:
    {
    System.Console.WriteLine("Введено не верное значение.");
    break;
    }
}*/




/*Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    double powI = Math.Pow(i, 3);
    Console.Write($"{powI}, ");
}
Console.Write("\b\b ");*/





/*System.Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
 
    if (9999 < number && number < 99999)
    {
    int first = number / 10000; //5 000
    int second = number / 1000%10;// 5 0 00
    int third = number / 100%10;
    int fourth = number /10%10;//500 0
    int fifth = number%10;

        if (first == fifth && second == fourth)
        {
        System.Console.WriteLine($"Число {number} палиндром");
        }
        else
        {
        System.Console.WriteLine($"Число {number} не палиндром");
        }
    }
    else
    {
    System.Console.WriteLine("Введенно не пятизначное число.");
    }*/




/*Console.WriteLine("Введите координату X1:");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1:");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1:");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2:");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2:");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z2:");
int Z2 = Convert.ToInt32(Console.ReadLine());




double arg1 = Math.Sqrt (Math.Pow((X1 - X2), 2) + Math.Pow((Y1 -Y2), 2) + Math.Pow((Z1 - Z2), 2));
double result = Math.Round(arg1, 2);
Console.WriteLine(result);*/