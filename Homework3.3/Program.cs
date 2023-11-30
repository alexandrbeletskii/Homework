// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
double [] FillArray(int size)
{
    double[] array = new double [size];
    Random random = new Random ();
       for (int i = 0; i < array.Length; i++)
    {
        double randomNumber = Math.Round (random.NextDouble () *10, 2);
        array[i] = randomNumber;

    }
    return array;
}

void PrintArray(double[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write(inArray[i] + " ");
    }
    Console.WriteLine();
}

double DiffMinMaxElement (double [] array)
{
        double min = array [0];
        double max = array [0];
        for (int i = 0; i < array.Length; i++)
        {
        if(array [i] > max) max = array [i]; 
        if(array [i] < min) min = array[i];
        }
    double diff= max-min;
    diff= Math.Round (diff, 2);
    return diff;
}

int lengthArray = 10;
double[] arr = FillArray(lengthArray);
PrintArray(arr);
double diffMinMaxElement = DiffMinMaxElement (arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diffMinMaxElement}");