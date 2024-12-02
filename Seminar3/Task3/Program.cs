double [] arr = {2.2,0.4,9.11,7.2,78.98};
int index = 0;
int index2 = 0;
double maxNum = arr[index];
double minNum = arr[index];

while (index < arr.Length) // find minimun number
{
    if(arr[index] < minNum)
    {
        minNum = arr[index];
    }
    index++;
}
while (index2 < arr.Length)// find maximum number
{
    if (arr[index2] > maxNum)
    {
        maxNum = arr[index2];
    }
    index2++;
}

double result = maxNum - minNum;
Console.WriteLine(result);