﻿class Program {
    static void Main(string[] args) {
        Console.WriteLine("Введите первое число:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = int.Parse(Console.ReadLine());

        if (a > b) {
            Console.WriteLine($"{a} больше {b}");
        } else if (a < b) {
            Console.WriteLine($"{b} больше {a}");
        } else {
            Console.WriteLine("Числа равны");
        }
    }
