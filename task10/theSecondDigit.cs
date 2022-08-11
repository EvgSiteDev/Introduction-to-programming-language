Console.WriteLine("Поиск третьей цифры в задданном трёхзначном числе");
Console.WriteLine("_________________________________________________");
Console.Write("Введите трёхзначное целое число: ");
string stringNum = Console.ReadLine()!;
int length = stringNum.Length;
while (length != 3)
{
    if (length != 3)
    {
        Console.Write("Вы ввели не трёхзначное число. Введите трёхзначное целое число: ");
        stringNum = Console.ReadLine()!;
        length = stringNum.Length;
    }
    else if (length == 3)
    {
        break;
    }
};
Console.WriteLine("Вторая цифра числа " + stringNum + ": " + stringNum[1]);