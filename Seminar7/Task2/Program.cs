int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    else
    {
        return 0;
    }
}

Console.WriteLine("Введите значение m (неотрицательное число):");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n (неотрицательное число):");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m, n);
Console.WriteLine($"Результат функции Аккермана A({m}, {n}) = {result}");