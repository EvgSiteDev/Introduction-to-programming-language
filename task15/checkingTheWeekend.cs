Console.WriteLine("Проверка номера дня недели на выходной");
Console.WriteLine("______________________________________");
Console.Write("Введите номер дня недели от 1 до 7: ");
string stringDayNum = Console.ReadLine()!;
int dayNum = int.Parse(stringDayNum);
while (dayNum > 7 || dayNum == 0)
{
    if (dayNum > 7 || dayNum == 0)
    {
        Console.Write("Номер недели введен не корректно. Введите номер дня недели от 1 до 7: ");
        stringDayNum = Console.ReadLine()!;
        dayNum = int.Parse(stringDayNum);
    }
    else {
        break;
    }
}
if (dayNum == 6 || dayNum == 7)
{
    Console.Write("Данный день является выходным");
}
else
{
    Console.Write("Данный день является рабочим");
}

