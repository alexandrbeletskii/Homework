// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

 void InputMatrix(int[,] matrix){
for(int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1, 31);
}
}
 }


void PrintMatrix(int[,] matrix){
for(int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}

void ReplaceRows (int[,] matrix){
    int temp;
    int length = matrix.GetLength(0) - 1;
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                temp = matrix[0, j];
                matrix[0, j] = matrix[length, j];
                matrix[length, j] = temp;
                i++;
            }

        }
    }


Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
ReplaceRows(matrix);
Console.WriteLine("Конечный массив: ");
PrintMatrix(matrix);

