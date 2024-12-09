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

int FindSumInCoArray(int[,] array1)
{
    int sum = 0;
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                sum += array1[i,j];
            }
        }
        return sum;
    }
}


void PrintMatrix(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        Console.Write('|');
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i,j], 4} ");
        }
        Console.WriteLine('|');
    }
}

int[,] array1 = CreateMatrixRdnInt(3,4,1,100);
PrintMatrix(array1);

Console.WriteLine();
int result = FindSumInCoArray(array1);
Console.WriteLine(result);
