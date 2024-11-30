int[] array1 = {1,8,4,19,5};
int digit = 20;

bool isExistNum = false;

for (int i = 0; i < array1.Length; i++)
{
    if( array1[i] == digit)
    {
        isExistNum = true;
        break;
    }
}
//string result = isExistNum ? "Да" : "Нет";
Console.WriteLine(isExistNum ? "Да" : "Нет");