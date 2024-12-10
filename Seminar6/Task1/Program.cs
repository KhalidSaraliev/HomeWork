char[,] charArray = new char[,] {{ 'a', 'b' }, { 'c', 'd' } }; //двумерный массив символов
    
 string CreateStringFrom2DArray(char[,] array) // Метод для создания строки из двумерного массива символов
{
    string result = "";

    for (int i = 0; i < array.GetLength(0); i++) // Цикл по каждому элементу в двумерном массиве
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j]; // Добавление каждого символа в результирующую строку
        }
    }
    return result;
}

string result = CreateStringFrom2DArray(charArray); // Вызов метода для создания строки из 2D массива
Console.WriteLine(result); // Вывод результата