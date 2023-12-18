// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

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

void ReverseArray(int[] array, int firstDigit=0)

   {
    if(firstDigit != array.Length) {
        ReverseArray(array, firstDigit + 1);
        Console.Write($"{array[firstDigit]} ");
    }
   }

int lengthArray = 10;
int[] arr = FillArray(lengthArray);
Console.WriteLine($" Начальный массив: ");
PrintArray (arr);
ReverseArray (arr);

