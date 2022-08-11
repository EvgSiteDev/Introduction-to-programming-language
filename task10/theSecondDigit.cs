void searchForTheSecondDigit(int NumLength)
{
Console.WriteLine("Поиск второй цифры в задданном" + NumLength + "значном" + " числе");
Console.WriteLine("_________________________________________________");
Console.Write("Введите " + NumLength + " значное целое число: ");
    string stringNum = Console.ReadLine()!;
    int length = stringNum.Length;
    while (length != NumLength)
    {
        if (length != NumLength)
        {
            Console.Write("Вы ввели не " + NumLength  + " значное"+ " число. Введите " + NumLength + " значное целое число: ");
            stringNum = Console.ReadLine()!;
            length = stringNum.Length;
        }
        else if (length == NumLength)
        {
            break;
        }
    };
    Console.WriteLine("Вторая цифра числа " + stringNum + ": " + stringNum[1]);
}
searchForTheSecondDigit(3);