// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.


bool IsPalindrome(string a)
{
string normalized = new
string(a.Where(char.IsLetterOrDigit).ToArray()).ToLower();
return normalized.SequenceEqual(normalized.Reverse());
}





string input = "Hello World , dlroW olleH";
bool isPalindrome = IsPalindrome(input);
Console.WriteLine(isPalindrome ? "Да" : "Нет");

