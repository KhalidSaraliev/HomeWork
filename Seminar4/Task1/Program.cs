while (true)
{
    string input = ReadInput();;

    if (IsExitCommand(input))
    {
        break;
    }

    if (IsNumber(input))
    {
        int number = Convert.ToInt32(input);
        if(IsSumOfDigitsEven(number))
        {
            Console.WriteLine("Сумма цифр числа четная. Программа завершает работу.");
            break;
        }
    }
    else
    {
        Console.WriteLine("Введено не целое число. Попробуйте снова.");
    }
}

string ReadInput()
{
    Console.Write("Введите целое число или 'q' для выхода: ");
    return Console.ReadLine();
}

bool IsExitCommand(string input)
{
    return input.ToLower() == "q";
}

bool IsNumber(string input)
{
    foreach(char c in input)
    {
        if (!char.IsDigit(c) && c != '-')
        {
            return false;
        }
    }
    return true;
}

bool IsSumOfDigitsEven(int number)
{
    int sumOfDigits = 0;
    int temp = Math.Abs(number);

    while (temp != 0)
    {
        sumOfDigits += temp % 10;
        temp /= 10;
    }
    return sumOfDigits % 2 == 0;
}