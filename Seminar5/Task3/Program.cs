int[,] originalMatrix = CreateMatrixRdnInt(3, 4, 1, 100);

Console.WriteLine("Оригинальная матрица:");
PrintMatrix(originalMatrix);

int[,] transposedMatrix = TransposeMatrix(originalMatrix);
Console.WriteLine("Транспонированная матрица:");
PrintMatrix(transposedMatrix);


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

int[,] TransposeMatrix(int[,] original)
{
    int rows = original.GetLength(0);
    int columns = original.GetLength(1);
    int[,] transposed = new int[columns, rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            transposed[j, i] = original[i, j];
        }
    }
    return transposed;
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