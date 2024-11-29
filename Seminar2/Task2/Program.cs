Console.Write("Введите координаты точки X ");
int coordinatesX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Y ");
int coordinatesY = Convert.ToInt32(Console.ReadLine());

 if (coordinatesX > 0 && coordinatesY > 0)
 {
     Console.WriteLine($"Номер координатной четверти {coordinatesX} и {coordinatesY} равно 1");
 }
 else if (coordinatesX < 0 && coordinatesY > 0)
 {
     Console.WriteLine($"Номер координатной четверти {coordinatesX} и {coordinatesY} равно 2");
 }
 else if (coordinatesX < 0 && coordinatesY < 0)
{
     Console.WriteLine($"Номер координатной четверти {coordinatesX} и {coordinatesY} равно 3");
}
else if ( coordinatesX > 0 && coordinatesY < 0)
{
    Console.WriteLine($"Номер координатной четверти {coordinatesX} и {coordinatesY} равно 4");
}
else
{
    Console.WriteLine("Некорректный ввод!");
}