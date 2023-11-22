// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите значение координаты X: ");
 double x = double.Parse(Console.ReadLine()!);
 Console.Write("Введите значение координаты Y: ");
 double y = double.Parse(Console.ReadLine()!);

double coordinateQuater ( double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x > 0 && y < 0) return 3;
    if (x < 0 && y < 0) return 4;
    return 0;
   }
double quarter = coordinateQuater (x, y);

string result= quarter > 0 
            ? $"Указанные координаты соответствуют четверти ->  {quarter}"
            : "Введены некорректные координаты";
            Console.WriteLine(result);
