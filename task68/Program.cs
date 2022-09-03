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
int akkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0) return akkermanFunction(m - 1, 1);
    else return akkermanFunction(m - 1, akkermanFunction(m, n - 1));
}
Console.WriteLine("Результат: " + akkermanFunction(dataInput("Введите m: "), dataInput("Введите n: ")));
