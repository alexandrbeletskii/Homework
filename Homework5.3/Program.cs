// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

 void InputMatrix(int[,] matr){
for(int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i, j] = new Random().Next(1, 31);
}
}
 }


void PrintMatrix(int[,] matr){
for(int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($"{matr[i, j]} \t");
}
Console.WriteLine();
}
}

int [] SumRows(int[,] matr)
{
    int[] sum_array = new int[matr.GetLength(0)];
    int index = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        sum_array [index] = sum;
        index++;
        }
            return sum_array;
}

int  MinSumRows(int[] arr)
{
    int min = arr[0]; 
  
    for(int i = 0; i< arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;

}


Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int col = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[rows, col];
if (rows == col){
    Console.WriteLine("Массив не прямоугольный");
}
else if (rows == 1 || col == 1)
{
    Console.WriteLine("Массив не прямоугольный");
}
else {
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
}
Console.WriteLine($"Суммы строк: [{string.Join(", ", SumRows(matrix))}]");
Console.WriteLine($"Минимальная сумма строк: {MinSumRows(SumRows(matrix))}");