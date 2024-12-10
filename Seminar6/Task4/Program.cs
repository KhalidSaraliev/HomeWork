string input = "Hello my world"; // Входная строка со словами, разделенными пробелами

string ReverseWords(string str) 
{
    string[] words = str.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}

string result = ReverseWords(input); // Вызов метода для обращения порядка слов в строке
Console.WriteLine(result); // Вывод результата