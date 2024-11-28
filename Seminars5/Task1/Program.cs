// Console.WriteLine("Ведите первое положительное число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите второе положительное число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());


// if (num1 == 0)
// {
//     Console.WriteLine("На ноль делить нельзя");
// }
// else if (num1 % num2 == 0)
// {
//     Console.WriteLine("Делится");
// }
// else
// {
//     Console.WriteLine("Не делится");
// }

// 2 задание

// Console.WriteLine("Ведите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// {
//     if ((a>=b && a<=c) || (a>= c && a<= b))
//     {
//         Console.WriteLine($"Среднее число {a} ");
//         return a;
//     }
//     else if ((b >= a && b <= c) || (b >= c && b <=a))
//     {
//         Console.WriteLine($"Среднее число {b} ");
//         return b;
//     }
//     else
//     {
//         Console.WriteLine($"Среднее число {c} ");
//         return c;
//     }
// }

 // 3 задание

// Console.WriteLine("Ведите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 >0)
// {
//     Console.WriteLine($"Число {num1} яаляется положительным");
// }
// else if (num1 < 0)
// {
//     Console.WriteLine($"Число {num1} отрицательное");
// }
// else if(num1 == 0)
// {
//     Console.WriteLine($"Число {num1} ноль");
// }

//4 задание

Console.Write("Ведите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= num1)
{
        Console.Write($"{i} ");
        i+= 2;
}