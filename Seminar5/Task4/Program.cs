int[,] CreateMatrixRdnInt(int rows, int columns, int min, int max)
{
    int[,] array2d = new int[rows,columns];
    Random rnd = new Random();

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i,j] = rnd.Next(min,max);
        }
    }
    return array2d;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write('|');
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine('|');
    }
}

void ReplaceNegativeNumbers(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (array[i, j] < 0)
            {
                array[i, j] = -array[i, j];
            }
        }
    }
    Console.WriteLine("Массив после замены отрицательных чисел:");
}

int[,] myMatrix = CreateMatrixRdnInt(3, 4, -10, 10);
PrintMatrix(myMatrix);

ReplaceNegativeNumbers(myMatrix);
PrintMatrix(myMatrix);