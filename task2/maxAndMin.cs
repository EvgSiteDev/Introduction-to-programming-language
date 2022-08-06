string  firstNumString,
        secondNumString;

int firstNum,
    secondNum;

Console.WriteLine("Нахождение максимального и минимального числа");
Console.Write("Введите первое число:");
firstNumString = Console.ReadLine()!;
firstNum = int.Parse(firstNumString);

Console.Write("Введите второе число:");
secondNumString = Console.ReadLine()!;
secondNum = int.Parse(secondNumString);

if (firstNum > secondNum)
    {
        Console.WriteLine("Максимальное число:" + firstNumString);
        Console.WriteLine("Минимальное число:" + secondNumString);
    }

else 
    {
        Console.WriteLine("Максимальное число:" + secondNumString);
        Console.WriteLine("Минимальное число:" + firstNumString);
    }





