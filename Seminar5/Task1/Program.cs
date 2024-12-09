using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

int[,] array2d = CreateMatrixRdnInt(3, 4, 1, 10);
PrintMatrix(array2d);

int[] maxValues = FindMaxInEachRow(array2d);
Console.WriteLine("Максимальные значения в каждой строке:");
PrintArray(maxValues);

int[,] CreateMatrixRdnInt(int rows, int columns, int min, int max)
{
    int[,] array1 = new int[rows,columns];
    Random rnd = new Random();

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i,j] = rnd.Next(min,max);
        }
    }
    return array1;
}

void PrintMatrix(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i,j]} ");
        }
        Console.WriteLine();
    }
}

int FindMaxInRow(int[,] array, int row) //находит максимальный элемент в одной строке двумерного массива
{
    int max = array[row, 0]; //Считаем, что максимальный элемент — первый элемент строки

    for (int j = 1; j < array.GetLength(1); j++) //Проходим по всем элементам строки и обновляем максимальное значение, если находим большее
    {
        if (array[row, j] > max)
        {
            max = array[row, j];
        }
    }
    return max; //Возвращаем максимальное значение
}

int[] FindMaxInEachRow(int[,] array) //находит максимальные элементы во всех строках двумерного массива
{
    int[] maxValues = new int[array.GetLength(0)]; //Создаем массив для хранения максимальных значений каждой строки

    for (int i = 0; i < array.GetLength(0); i++) //Проходим по всем строкам и для каждой строки находим максимальное значение, используя функцию FindMaxInRow
    {
        maxValues[i] = FindMaxInRow(array, i);
    }
    return maxValues; //Возвращаем массив максимальных значений
}

void PrintArray(int[] array) //выводит одномерный массив на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) //Проходим по всем элементам массива
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, "); //Выводим каждый элемент массива, разделяя запятыми
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]"); //Закрываем квадратные скобки после вывода всех элементов
}