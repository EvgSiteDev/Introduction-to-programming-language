
void searchForTheThirdDigit(int theDesiredFigure)
{
    Console.WriteLine("Поиск третьей цифры в задданном числе");
    Console.WriteLine("______________________________________");
    Console.Write("Введите целое число: ");
    string stringNum = Console.ReadLine()!;
    if (stringNum.Length >= theDesiredFigure)
    {
        Console.WriteLine(theDesiredFigure + " цифра числа " + stringNum + " = " + stringNum[2]);
    }
    else
    {
        Console.WriteLine(theDesiredFigure + " цифры не существует");
    }
}
searchForTheThirdDigit(3);
