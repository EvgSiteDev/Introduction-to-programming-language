int dataInput(string message)
{
dataValidation: Console.Write(message);
    string introducedNumberString = Console.ReadLine()!;
    if (!int.TryParse(introducedNumberString, out int introducedNumber) || introducedNumber < 0)
    {
        goto dataValidation;
    }
    return introducedNumber;
}
string calculationOfAllNaturalNumbers(int initialNumber, int theFinalNumber)
{
    string listOfNaturalNumbers = string.Empty;
    for (int i = initialNumber; i <= theFinalNumber; i++)
    {
        if (i < theFinalNumber) listOfNaturalNumbers += i + ", ";
        else listOfNaturalNumbers += i;
    }
    return listOfNaturalNumbers;
}

string listOfNaturalNumbers = calculationOfAllNaturalNumbers(dataInput("Введите начальное число: "), dataInput("Введите конечное число: "));
Console.WriteLine("Список натуральных чисел: " + listOfNaturalNumbers);