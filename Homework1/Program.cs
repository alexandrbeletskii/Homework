        // Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
        Console.Clear();
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()!);
        number = Math.Abs(number);
        if (number % 7 == 0 && number % 23 == 0)
            Console.WriteLine($"Число {number} одновременно кратно числам 7 и 23");
        else if (number % 7 == 0 && number % 23 > 0)
            Console.WriteLine($" Число {number}  кратно числу 7, но не кратно 23");
            else if (number % 7 > 0 && number % 23 == 0)
             Console.WriteLine($" Число {number} одновременно  кратно числу 23, но не кратно 7");
             else if (number % 7 > 0 && number % 23 > 0)
               Console.WriteLine($" Число {number} не кратно ни числу 23, ни числу 7");
