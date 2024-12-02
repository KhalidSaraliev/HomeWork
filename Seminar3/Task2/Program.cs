int[] arr = {9,1,5,6,4,8,3,22,10,66};
int index = 0;
int count = 0;

while (index < arr.Length)
{
    if(arr[index] % 2 == 0)
    {
        count++;
    }
    index++;
}

Console.WriteLine($"Количество четных чисел в массиве {count} ");