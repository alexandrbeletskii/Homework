// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

Console.Clear();
char[,] chars = new char[,] { { 'f', 'g' }, { 'k', 'd' } };
string result = string.Empty;
for (int i = 0; i < chars.GetLength(0); i++)
{
for (int j = 0; j < chars.GetLength(1); j++)
{
result += chars[i, j];
}
}
Console.WriteLine($"{result}");


