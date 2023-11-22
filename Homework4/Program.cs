// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
Console.Clear();
Console.Write("Введите натуральное число: ");
int n= int.Parse(Console.ReadLine()!);
int result = 0;
int y = n.ToString().Length;
 
while (n > 0)
 {
 result *= 10;
 result += n % 10;
 n /= 10;
}
 
 for (int i = 0; i < y; i++)
{
if (i < y - 1) Console.Write($"{result%10},");
else Console.Write($"{result%10}");
result /= 10;
}

 