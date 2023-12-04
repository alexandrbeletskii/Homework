// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void inputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(100, 1000); 
}

int CountEvenNumbers (int[] arr)
{
    int count = 0;
    foreach (int element in arr)
    {
        if (element%2==0)
        count++;
    }
    return count;
}


Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int evenDigit = CountEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве: {evenDigit}");
