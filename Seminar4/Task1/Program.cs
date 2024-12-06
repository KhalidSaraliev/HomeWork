while (true)
{
    Console.Write("Введите число или 'q' для выхода: ");
    string n = Console.ReadLine();

    if (n == "q")
    {
        break;
    }

    int number = 0;
    if (int.TryParse(n, out number))
    {
        int sum = 0;
        while (number > 0)
        {
            sum+= number % 10; //Добавление последней цифры к сумме
            number /= 10; // Удаление последней цифры из числа
        }

        if (sum % 2 == 0)
        {
            Console.WriteLine("[STOP]");
            break;
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста введите целое число или 'q' ");
    }
}