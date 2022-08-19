Console.Write("Введите число: ");
string numStr = Console.ReadLine()!;
string dataVerification(string numString)
{
    for (int i = 1; i > 0 ; i++ )
    {
        if (int.TryParse(numString, out int result) == false)
        {
            Console.Write("Ошибка. Введите числовое значение: ");
            numString = Console.ReadLine()!;
        }
        else if (int.Parse(numString) < 0)
        {
            Console.Write("Ошибка.Вы ввели отрицатильное значение. Введите числовое положительное значение: ");
            numString = Console.ReadLine()!;
        }
        else break;
    }
        return numString;
}

numStr = dataVerification(numStr);


int digitSearch(string numberString, int digit)
{
    int numForTheRemainder = 1,
        numForSearchForADigit = 1,
        result = 0,
        number = int.Parse(numberString);
    for (int i = numberString.Length; i >= 1; i--)
    {
        numForSearchForADigit *= 10;
    }
    for (int i = digit; i <= numberString.Length; i++)
    {
        numForTheRemainder *= 10;
    }
    for (int i = 1; i <= digit; i++)
    {
        numForSearchForADigit /= 10;

    }
    if (digit == 1)
    {
        result = number / numForSearchForADigit;
    }
    if (digit == numberString.Length)
    {
        numForTheRemainder = 10;
        result = number % numForTheRemainder;

    }
    else if (digit > 1 && digit < numberString.Length)
    {
        result = number % numForTheRemainder / numForSearchForADigit;
    }
    return result;
}

int digitSumm(string numberString)
{
    int digit = 0,
    result = 0;
    for (int i = 1; i <= numberString.Length; i++)
    {
        digit = digitSearch(numberString, i);
        result += digit;
    }
    return result;
}
Console.WriteLine("Сумма цифр равна: " + digitSumm(numStr));

