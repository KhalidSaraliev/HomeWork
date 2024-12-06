int[] array = {1,3,6,7,8,9,4};
int temp;

Console.Write("Исходный массив: ");
foreach (int number in array)
{
    Console.Write(number + " ");
}

for (int i = 0; i < array.Length/2; i++)
{
    temp = array[i];
    array[i] = array[array.Length-1-i];
    array[array.Length -1 - i] = temp;
}

Console.Write("\nПеревернутый массив: ");
foreach (int number in array)
{
    Console.Write(number + " ");
}