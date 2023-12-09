// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void ReplaceRows (int[,] matr){
    int temp;
    int length = matr.GetLength(0) - 1;
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
                temp = matr[0, j];
                matr[0, j] = matr[length, j];
                matr[length, j] = temp;
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

