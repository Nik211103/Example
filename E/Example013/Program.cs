
using System.Net.Sockets;
using System;
/*Напиши программу, которая будет запрашивать у пользователя число и выводить на экран таблицу умножения для этого числа.
System.Console.WriteLine("Введите число от 1 до 10, для показа таблицы умножения на это число:");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum < 1 || userNum > 10)
{
    System.Console.WriteLine("Введено число не от 1 до 10.");
}
else
{
    for (int i = 1; i <= 10; i++)
    {
        
        System.Console.WriteLine($"{userNum} x {i} = {userNum * i}");
        
    }
}*/

/*Создай программу, которая будет генерировать случайное число от 1 до 100 и предлагать пользователю угадать его.
Если пользователь угадал число, программа должна выводить сообщение об успехе, если нет - сообщение о неудаче.*/

System.Console.WriteLine("Привет, это игра: Угадай число. Тебе нужно отгадать число в диапозоне от 1 до 100.");
Random random = new Random();
int ranNum = random.Next(1, 100);

int userNum;
System.Console.WriteLine("Введите желаемое количество попыток:");
int count = Convert.ToInt32(Console.ReadLine()); 
do
{
    System.Console.WriteLine("Сгенерировано число. Какое это число?");
        System.Console.WriteLine("");
        userNum = Convert.ToInt32(Console.ReadLine()); 
            if (userNum < 1 || userNum > 100)
            {
            System.Console.WriteLine("Введено число вне диапозона.");
            }
    
            if (userNum > ranNum && userNum >= 1 && userNum <= 100)
            {
                
                System.Console.WriteLine($"Число {userNum} больше загаданного.");
                count = count - 1;
                System.Console.WriteLine($"Осталось {count} попыток.");
                continue;
            }


            if (userNum < ranNum && userNum >= 1 && userNum <= 100)
            {
                System.Console.WriteLine($"Число {userNum} меньше загаданного");
                count = count - 1;
                System.Console.WriteLine($"Осталось {count} попыток.");
                continue;
            }
        } while(userNum != ranNum && count != 0);
if( count == 0){
System.Console.WriteLine("Попытки закончились:(");
System.Console.Write($"Это было число {ranNum}");
}
else{
System.Console.WriteLine($"Вы угадали! Это было число {ranNum}! ");
}

