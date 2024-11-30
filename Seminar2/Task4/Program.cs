Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int temp = n;
int count = 0;

while (temp > 0)
{
    temp /= 10;
    count++;
}

int [] digits = new int [count];

for(int i = count -1; i >= 0; i --)
{
    digits[i] = n % 10;
    n /= 10;
}

Console.Write("Цифры числа: ");
for (int i = 0; i < digits.Length; i++)
{
    if (i > 0)
    {
        Console.Write(", ");
    }
    Console.Write(digits[i]);
}
Console.WriteLine();
