﻿
 Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b) {
            Console.WriteLine($"{a} больше {b}");
        } else if (a < b) {
            Console.WriteLine($"{b} больше {a}");
        } else {
            Console.WriteLine("Числа равны");
        }
    
