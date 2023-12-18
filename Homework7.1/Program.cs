// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.



void printNumbers(int a, int b)
{
    if (a > b)
        return;
{
    Console.Write($"{a} ");
}
printNumbers(a + 1, b);
}



Console.Clear();    
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите  число N: ");
int n = int.Parse(Console.ReadLine()!);
printNumbers(m,n);



