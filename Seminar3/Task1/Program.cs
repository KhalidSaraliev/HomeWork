int[] arr = { 3, 6, 11, 25, 78, 32, 4, 9, 86, 75 };
int index = 0;
int count = 0;

while(index < arr.Length)
{
    if(arr[index] > 9 && arr[index]<=90)
    count++;
    index++;
}
Console.WriteLine(count);