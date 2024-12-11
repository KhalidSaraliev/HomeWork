void PrintArrayReverse(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write(array[index]);
    PrintArrayReverse(array, index - 1);
}

int[] array = { 1, 2, 3, 4, 5 };
Console.Write("Элементы массива, начиная с конца: ");
PrintArrayReverse(array, array.Length - 1);