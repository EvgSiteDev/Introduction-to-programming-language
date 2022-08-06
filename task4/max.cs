string  firstNumString,
        secondNumString,
        thirdNumString;

int firstNum,
    secondNum,
    thirdNum,
    maxNum;

Console.WriteLine("Нахождение максимального числа");
Console.Write("Введите первое число:");
firstNumString = Console.ReadLine()!;
firstNum = int.Parse(firstNumString);

Console.Write("Введите второе число:");
secondNumString = Console.ReadLine()!;
secondNum = int.Parse(secondNumString);

Console.Write("Введите третье число:");
thirdNumString = Console.ReadLine()!;
thirdNum = int.Parse(thirdNumString);

maxNum = firstNum;

if (maxNum < secondNum)
{
    maxNum = secondNum;
}
if (maxNum < thirdNum)
{
    maxNum = thirdNum;
}
Console.WriteLine("Максимальное число:" + maxNum);








