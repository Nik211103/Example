/*Задача №11. Работа в группах
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98*/

/*Задача №12. Работа в группах
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/

/*int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;
System.Console.WriteLine($"Число {num} без второй цифры -> {a1}{a2}");*/

/*System.Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());

    if (a % b == 0){
    System.Console.WriteLine($"{a}, {b} -> кратно.");
    }
    
    else {
    System.Console.WriteLine($"{a}, {b} -> не кратно.");
    }*/












    /*Задача №14. Работа в группах
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно _x000b_7 и 23.

14 -> нет
46 -> нет
161 -> да*/


/*Задача №16. Работа в группах
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет*/

/*int num1 = 7;
int num2 = 23;
System.Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
    if (a % num1 == 0 && a % num2 == 0){
    System.Console.WriteLine($"Число {a} кратно {num1} и {num2}.");
    }
    else{
    System.Console.WriteLine($"Число {a} не кратно {num1} и {num2}.");
    }*/

System.Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
    if (a / b == b){
    System.Console.WriteLine($"{b} является квадратом {a}.");
    }
    else{
    System.Console.WriteLine($"{b} не является квадратом {a}.");
    }

