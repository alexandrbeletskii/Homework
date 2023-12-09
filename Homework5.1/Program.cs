// // // Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
Console.Write("Введите позицию строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int col = Convert.ToInt32(Console.ReadLine());
if(row < matrix.GetLength(0) && col < matrix.GetLength(1))
{
    Console.Write($"{matrix[row, col]}");
}
else 
{
    Console.Write("Параметры отсутствуют");
}
