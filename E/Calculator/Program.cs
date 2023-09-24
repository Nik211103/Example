
using System;
using System.Text.RegularExpressions;
System.Console.WriteLine("Выберите действие:");

System.Console.WriteLine("1.Простые действия");
System.Console.WriteLine("2.Сложные действия");
    double result = 0;
    int arg1 = Convert.ToInt32(Console.ReadLine());
    if (arg1 == 1) {
        System.Console.WriteLine("1.Умножение");
        System.Console.WriteLine("2.Сложение");
        System.Console.WriteLine("3.Деление");
        System.Console.WriteLine("4.Вычитание");

            int arg2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите первое число:");
            double a = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Введите второе число:");
            double b = Convert.ToInt32(Console.ReadLine());

            if (arg2 == 1) {
                result = a * b;
            }
            
            if (arg2 == 2) {
                result = a + b;
            }

            if (arg2 == 3) {
                    if (b == 0){
                    System.Console.WriteLine("Ошибка: Деление на ноль");
                    return;
                    }
                result = a / b;
            }

            if (arg2 == 4) {
                result = a - b;
            }
    }
    if (arg1 == 2) {
    System.Console.WriteLine("1.Возведение в квадрат");
    System.Console.WriteLine("2.Квадратный корень числа");
        int arg2 = Convert.ToInt32(Console.ReadLine());

            if (arg2 == 1){
            System.Console.WriteLine("Введите число");
            double a = Convert.ToInt32(Console.ReadLine());
            result = a * a;
            }

            if (arg2 == 2){
            System.Console.WriteLine("Введите число");
            double a = Convert.ToInt32(Console.ReadLine());
            double squareRoot = Math.Sqrt(a);
            result = squareRoot;
            }
           

}
            

System.Console.WriteLine("Результат:");
System.Console.WriteLine(result);

    





