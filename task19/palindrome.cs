Console.Write("Введите пятизначное положительное целое число : ");
string stringNum = Console.ReadLine()!;
int num = int.Parse(stringNum);
void checkingTheInput()
{
    for (int i = 1; i >= 1; i++)
    {
        if (num < 0)
        {
            Console.Write("Вы ввели отрицательное число. Введите положительное число: ");
            stringNum = Console.ReadLine()!;
            num = int.Parse(stringNum);
        }
        else if (stringNum.Length != 5)
        {
            Console.Write("Вы ввели не пятизначное число. Введите пятизначное число: ");
            stringNum = Console.ReadLine()!;
            num = int.Parse(stringNum);

        }
        else if (stringNum.Length == 5)
        {
            break;
        }
    }
}
void polydromeAnalysis(string numStr)
{
    int lastIndexDigit = numStr.Length - 1;
    int firstIndexDigit = 0;
    int matchsfound = 0;
    while (lastIndexDigit >= firstIndexDigit)
    {
        if (numStr[firstIndexDigit] == numStr[lastIndexDigit])
        {
            lastIndexDigit--;
            firstIndexDigit++;
            matchsfound++;

        }
        if (numStr[firstIndexDigit] != numStr[lastIndexDigit])
        {
            break;
        }
    }
    if (matchsfound == 3)
    {
        Console.WriteLine("Данное число является палиндромом");
    }
    if (matchsfound < 3)
    {
        Console.WriteLine("Данное число не является палиндромом");
    }
}

checkingTheInput();
polydromeAnalysis(stringNum);