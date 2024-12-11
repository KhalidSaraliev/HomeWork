void PrintRange(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m);
        if (m < n)
        {
            Console.Write(",");
            PrintRange(m + 1, n);
        }
    }
    else
    {
        Console.Write(m);
        if (m > n)
        {
           Console.Write(",");
           PrintRange(m - 1, n); 
        }
    }
}

int m = 1;
int n = 5;
Console.WriteLine($"Числа промежутке: ");
PrintRange(m, n);