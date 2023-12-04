// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

void inputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(99, 1000); 
}

void ReverseArray (int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        int temp= arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReverseArray (array);
Console.WriteLine($"Перевернутый массив: [{string.Join(", ", array)}]");

