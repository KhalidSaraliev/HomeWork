Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 7;
int num2 = 23;
if (num % num1 == 0)
{
    Console.WriteLine($"Да, {num} кратно {num1}");
}
else
{
    Console.WriteLine($"Нет, {num} не кратно {num1}");
}
if (num % num2 == 0)
{
    Console.WriteLine($"Да, {num} кратно {num2}");
}
else
{
    Console.WriteLine($"Нет, {num} не кратно {num2}");
}