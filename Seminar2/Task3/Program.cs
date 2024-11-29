Console.Write("Введите первое двухзначное число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе двухзначное число ");
int num2 = Convert.ToInt32(Console.ReadLine());


if ((num1 > 9 && num1 < 100) && (num2 > 9 && num2 < 100))
{
    if (num1 > num2)
    {
        Console.WriteLine($"Число {num1} больше чем {num2}");
    }
    else
    {
        Console.WriteLine($"Число {num2} больше чем {num1}");
    }
}
else
{
    Console.WriteLine("Некорректный ввод");
}