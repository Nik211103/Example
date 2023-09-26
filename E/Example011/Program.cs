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







System.Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    double powI = Math.Pow(i, 3);
    System.Console.Write($"{powI}, ");
}
System.Console.Write("\b\b ");
