// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

string input = "Hello my world";
string result = ReverseWords(input);
Console.WriteLine(result);

// Метод для обращения порядка слов в строке
 string ReverseWords(string str)
{
string[] words = str.Split(' ');
Array.Reverse(words);
return string.Join(" ", words);
}
