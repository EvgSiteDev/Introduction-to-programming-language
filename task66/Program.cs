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
int calculatingTheSumOfAllNaturalNumbers(int initialNumber, int theFinalNumber)
{
    int theSumOfNaturalNumbers = 0;
    for (int i = initialNumber; i <= theFinalNumber; i++)
    {
        theSumOfNaturalNumbers += i;
    }
    return theSumOfNaturalNumbers;
}
int theSumOfNaturalNumbers =
    calculatingTheSumOfAllNaturalNumbers(
        dataInput("Введите начальное число: "),
        dataInput("Введите конечное число: ")
    );

Console.WriteLine("Сумма всех натуральных чисел: " + theSumOfNaturalNumbers);