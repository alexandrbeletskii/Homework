// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int SumDigit(int num) 
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10; 
        num /= 10; 
    }
    return sum;
}

while (true)
{
       Console.WriteLine("Введите целое число. Для завершения введите 'q' или или число сумма цифр которого четная :");
    string input = Console.ReadLine()!;

        if (input.ToLower() == "q")
    {
        Console.WriteLine("Вы ввели 'q', программа завершена");
        break;
    }

       if (int.TryParse(input, out int number))
    {
                int digitSum = SumDigit(number);

        // Проверяем, является ли сумма цифр четной.
        if (digitSum % 2 == 0)
        {
            Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершается.");
            break;
        }
        else
        {
            Console.WriteLine("Продолжайте ввод.");
        }
    }
    else
    {
                Console.WriteLine("Некорректный ввод.");
    }
}
