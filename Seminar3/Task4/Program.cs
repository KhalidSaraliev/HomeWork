int number = 8741;
int temp = number;
int count = 0;

while (temp != 0)
{
    temp /= 10;
    count++;
}

int[] digits = new int[count];

for (int i = count - 1; i >= 0; i--)
{
    digits[i] = number % 10;
    number /= 10;
}
Console.Write('[');
foreach(int digit in digits)
{
    Console.Write($"{digit} ");
}
Console.Write(']');