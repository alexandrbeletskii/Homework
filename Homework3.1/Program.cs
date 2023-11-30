// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] FillArray(int size)
{
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 100);
}
return array;
}

void PrintArray(int[] inArray)
{
for (int i = 0; i < inArray.Length; i++)
{
Console.Write(inArray[i] + " ");
}
Console.WriteLine();
}

int QuantityElemets (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i]>=20 && array[i]<=90) count++;
    }
    return count;
}

int lengthArray = 10;
int[] arr = FillArray(lengthArray);
PrintArray(arr);
int quantityElemets = QuantityElemets(arr);
Console.WriteLine ($"Количество элементов массива в диапозоне от 20 до 90 = {quantityElemets}");

